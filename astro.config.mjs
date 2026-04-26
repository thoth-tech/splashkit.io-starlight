import { defineConfig } from "astro/config";
import starlight from "@astrojs/starlight";
import react from "@astrojs/react";
import starlightLinksValidator from "starlight-links-validator";
import sitemap from "@astrojs/sitemap";
import remarkMath from "remark-math";
import rehypeMathjax from "rehype-mathjax";
import starlightBlog from "starlight-blog";
import starlightDocSearch from "@astrojs/starlight-docsearch";
import remarkHeadingID from "remark-heading-id";
import { loadEnv } from "vite";

const env = loadEnv("", process.cwd(), "");

const DOCSEARCH_API_ID = env.DOCSEARCH_API_ID;
const DOCSEARCH_API_SEARCH_KEY = env.DOCSEARCH_API_SEARCH_KEY;
const DOCSEARCH_INDEX_NAME = env.DOCSEARCH_INDEX_NAME;

const hasDocSearchConfig =
  DOCSEARCH_API_ID &&
  DOCSEARCH_API_SEARCH_KEY &&
  DOCSEARCH_INDEX_NAME;

if (!hasDocSearchConfig) {
  console.warn("Algolia DocSearch is not configured. Search will be disabled locally.");
}

export default defineConfig({
  site: "https://splashkit.io/",

  integrations: [
    starlight({
      title: "SplashKit",
      description:
        "SplashKit is a cross-platform game engine for C, C++ and Objective-C. It provides a simple API for 2D game development.",

      components: {
        ThemeSelect: "./src/components/ThemeToggle.astro",
      },

      plugins: [
        starlightBlog({
          title: "Announcements",
          recentPostCount: 5,
          prevNextLinksOrder: "chronological",
        }),

        starlightLinksValidator({
          errorOnRelativeLinks: true,
        }),

        ...(hasDocSearchConfig
          ? [
              starlightDocSearch({
                appId: DOCSEARCH_API_ID,
                apiKey: DOCSEARCH_API_SEARCH_KEY,
                indexName: DOCSEARCH_INDEX_NAME,
              }),
            ]
          : []),
      ],

      expressiveCode: {
        styleOverrides: { borderRadius: "0.5rem" },
        useDarkModeMediaQuery: true,
      },

      customCss: [
        "/src/styles/custom.css",
        "/src/styles/background.css",
        "/src/styles/cards.css",
      ],

      social: [
        {
          icon: "github",
          label: "GitHub",
          href: "https://github.com/splashkit",
        },
        {
          icon: "youtube",
          label: "YouTube",
          href: "https://www.youtube.com/@splashkit7674",
        },
      ],

      favicon: "/images/favicon.svg",

      logo: {
        src: "./src/assets/favicon.svg",
      },

      sidebar: [
        {
          label: "Installation",
          collapsed: false,
          items: [
            { label: "Installation Overview", link: "installation/" },
            {
              label: "Windows",
              collapsed: true,
              items: [
                {
                  label: "MSYS2",
                  autogenerate: {
                    directory: "installation/Windows (MSYS2)",
                  },
                  collapsed: false,
                },
                {
                  label: "WSL",
                  autogenerate: {
                    directory: "installation/Windows (WSL)",
                  },
                  collapsed: false,
                },
              ],
            },
            {
              label: "MacOS",
              autogenerate: { directory: "installation/MacOS" },
              collapsed: true,
            },
            {
              label: "Linux",
              autogenerate: { directory: "installation/Linux" },
              collapsed: true,
            },
            {
              label: "Virtual Machine",
              autogenerate: { directory: "installation/Virtual Machine" },
              collapsed: true,
            },
          ],
        },

        {
          label: "Troubleshooting",
          collapsed: true,
          items: [
            { label: "Troubleshooting Overview", link: "troubleshoot/" },
            {
              label: "Windows",
              collapsed: true,
              items: [
                {
                  label: "MSYS2",
                  autogenerate: {
                    directory: "troubleshoot/Windows (MSYS2)",
                  },
                  collapsed: false,
                },
                {
                  label: "WSL",
                  autogenerate: {
                    directory: "troubleshoot/Windows (WSL)",
                  },
                  collapsed: false,
                },
              ],
            },
            {
              label: "MacOS",
              autogenerate: { directory: "troubleshoot/MacOS" },
              collapsed: true,
            },
            {
              label: "Linux",
              autogenerate: { directory: "troubleshoot/Linux" },
              collapsed: true,
            },
          ],
        },

        {
          label: "API Documentation",
          autogenerate: { directory: "api", collapsed: false },
        },

        {
          label: "Tutorials and Guides",
          collapsed: false,
          items: [{ label: "Overview", link: "guides/" }],
        },
      ],
    }),

    react(),
    sitemap(),
  ],

  server: {
    host: true,
    port: 4321,
  },

  markdown: {
    remarkPlugins: [remarkMath, remarkHeadingID],
    rehypePlugins: [rehypeMathjax],
  },
});