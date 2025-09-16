// ------------------------------------------------------------------------------
// API Route: Popular Tutorials Data
// Returns mock tutorial statistics for the popular tutorials feature
// Phase 1: Mock data, Phase 2: Real analytics integration
// ------------------------------------------------------------------------------

export interface TopDoc {
  path: string;          // Page URL path as stable ID
  title: string;         // Tutorial title
  views: number;         // Total page views
  avgTimeSpent: number;  // Average time spent on page (seconds)
  category: string;      // Auto-extracted from path (first segment)
}

// Mock tutorial data based on real SplashKit documentation paths
const mockTutorialData: TopDoc[] = [
  {
    path: '/guides/graphics/drawing-sprites/',
    title: 'Drawing',
    views: 3247,
    avgTimeSpent: 145,
    category: 'guides'
  },
  {
    path: '/installation/windows-msys2/4-vscode/',
    title: 'VS Code Setup for Windows',
    views: 2891,
    avgTimeSpent: 220,
    category: 'installation'
  },
  {
    path: '/guides/animations/simple-animations/',
    title: 'Simple Animations',
    views: 2654,
    avgTimeSpent: 180,
    category: 'guides'
  },
  {
    path: '/guides/audio/playing-sounds/',
    title: 'Playing Sounds',
    views: 2103,
    avgTimeSpent: 95,
    category: 'guides'
  },
  {
    path: '/guides/input/handling-input/',
    title: 'Handling User Input',
    views: 1987,
    avgTimeSpent: 165,
    category: 'guides'
  },
  {
    path: '/installation/ubuntu/',
    title: 'Ubuntu Installation Guide',
    views: 1845,
    avgTimeSpent: 280,
    category: 'installation'
  },
  {
    path: '/guides/physics/collision-detection/',
    title: 'Collision Detection',
    views: 1672,
    avgTimeSpent: 200,
    category: 'guides'
  },
  {
    path: '/api/graphics/#draw-bitmap-named',
    title: 'Draw Bitmap API Reference',
    views: 1534,
    avgTimeSpent: 75,
    category: 'api'
  }
];

// Attempt to load GA4 when env is present
async function fetchFromGA4(limit: number, host?: string) {
  const propertyId = process.env.GA4_PROPERTY_ID;
  const clientEmail = process.env.GA4_CLIENT_EMAIL;
  let privateKey = process.env.GA4_PRIVATE_KEY;

  if (!propertyId || !clientEmail || !privateKey) {
    return { items: null as TopDoc[] | null, reason: 'missing-env' as const };
  }

  // Handle escaped newlines in env var
  privateKey = privateKey.replace(/\\n/g, '\n');

  // Lazy import GA client so build works even if not configured locally
  const { BetaAnalyticsDataClient } = await import('@google-analytics/data');
  const analytics = new BetaAnalyticsDataClient({
    credentials: {
      client_email: clientEmail,
      private_key: privateKey
    }
  });

  // Request: last 30 days, by pagePath
  const request: any = {
    property: `properties/${propertyId}`,
    dateRanges: [{ startDate: '30daysAgo', endDate: 'yesterday' }],
    dimensions: [{ name: 'hostName' }, { name: 'pagePath' }, { name: 'pageTitle' }],
    metrics: [{ name: 'screenPageViews' }, { name: 'userEngagementDuration' }],
    orderBys: [{ metric: { metricName: 'screenPageViews' }, desc: true }],
    limit: BigInt(Math.max(1, Math.min(limit, 50)))
  };

  if (host) {
    request.dimensionFilter = {
      filter: {
        fieldName: 'hostName',
        stringFilter: { matchType: 'EXACT', value: host }
      }
    };
  }

  const [response] = await analytics.runReport(request);

  const rows = (response.rows ?? []) as any[];
  const items: TopDoc[] = rows.map((r: any) => {
    const path = r.dimensionValues?.[1]?.value || '/';
    const title = r.dimensionValues?.[2]?.value || 'Untitled';
    const views = parseInt(r.metricValues?.[0]?.value ?? '0', 10) || 0;
    const totalEngagement = parseFloat(r.metricValues?.[1]?.value ?? '0') || 0;
    const avgTime = views > 0 ? Math.round(totalEngagement / views) : 0; // seconds
    const category = path.split('/').filter(Boolean)[0] ?? 'site';
    return { path, title, views, avgTimeSpent: avgTime, category };
  });

  return { items, reason: 'ok' as const };
}

// API endpoint handler
export async function GET({ url }: { url: URL }) {
  try {
    // Parse query parameters
    const limitParam = url.searchParams.get('limit');
    const limit = limitParam ? parseInt(limitParam, 10) : 6;
    const source = (url.searchParams.get('source') || 'auto').toLowerCase();

    // Prefer GA4 if requested or auto and env is present
    if (source === 'ga4' || source === 'auto') {
      const host = url.searchParams.get('host') || undefined;
      try {
        const ga = await fetchFromGA4(limit, host);
        if (ga.items && ga.items.length > 0) {
          return new Response(JSON.stringify({
            items: ga.items,
            meta: { source: 'ga4', returned: ga.items.length, ismock: false, host: host ?? null }
          }), { status: 200, headers: { 'Content-Type': 'application/json', 'Cache-Control': 'public, max-age=120' } });
        }
      } catch (e) {
        console.warn('GA4 fetch failed, falling back to mock:', e);
      }
    }

    // Fallback to mock data (Phase 1)
    const sortedTutorials = [...mockTutorialData].sort((a, b) => b.views - a.views);
    const limitedTutorials = sortedTutorials.slice(0, Math.max(1, Math.min(limit, 20)));

    return new Response(JSON.stringify({
      items: limitedTutorials,
      meta: {
        total: mockTutorialData.length,
        returned: limitedTutorials.length,
        source: 'mock',
        ismock: true
      }
    }), {
      status: 200,
      headers: {
        'Content-Type': 'application/json',
        'Cache-Control': 'public, max-age=60'
      }
    });
  } catch (error) {
    console.error('Error in top-docs API:', error);
    return new Response(JSON.stringify({
      error: 'Internal server error',
      message: 'Failed to fetch tutorial data'
    }), {
      status: 500,
      headers: { 'Content-Type': 'application/json' }
    });
  }
}
