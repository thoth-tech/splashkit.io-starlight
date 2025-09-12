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

// API endpoint handler
export async function GET({ url }: { url: URL }) {
  try {
    // Parse query parameters
    const limitParam = url.searchParams.get('limit');
    const limit = limitParam ? parseInt(limitParam, 10) : 6;
    
    // Sort by views only (future: custom algorithm combining multiple factors)
    const sortedTutorials = [...mockTutorialData].sort((a, b) => b.views - a.views);
    const limitedTutorials = sortedTutorials.slice(0, Math.max(1, Math.min(limit, 20)));
    
    // Return JSON response
    return new Response(JSON.stringify({
      items: limitedTutorials,
      meta: {
        total: mockTutorialData.length,
        returned: limitedTutorials.length,
        ismock: true // Phase 1 indicator
      }
    }), {
      status: 200,
      headers: {
        'Content-Type': 'application/json',
        'Cache-Control': 'public, max-age=300' // 5 minute cache
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
