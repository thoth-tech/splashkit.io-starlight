<!-- Copilot / AI agent instructions for thoth-tech/splashkit.io-starlight -->

This short doc helps GitHub Copilot / AI agents to be productive in the SplashKit docs site repo.

Key points
- Site is built with Astro + Starlight; code + components live in `src/` and content in `src/content/docs/` (MDX).
- API docs and Usage example pages are generated from JSON + `public/usage-examples/` via scripts in `scripts/`.
- `public/usage-examples/` is the authoritative source for example assets and naming conventions.

Local / CI workflows
- Dev (hot-reload): `npm install && npm run dev` (runs `npm run setup` before `astro dev`).
- Build / preview: `npm run build` (runs setup), `npm run preview` to preview build.
- Setup: `npm run setup` executes `node ./scripts/json-files-script.cjs` and `node ./scripts/api-pages-script.cjs` (must be run before dev/build to rebuild MDX pages from JSON).
- Generate usage example page: `npm run generate-usage-examples-pages <exampleKey>` (script reads `public/usage-examples/`).
- Validate example naming & files: `node scripts/usage-examples-testing-script.cjs <exampleKey>` (checks required files exist and are correctly named).
 - Generate / validate usage example pages: `node scripts/usage-examples-testing-script.cjs <exampleKey>` — running without an argument will generate MDX pages for every category and supports both layouts: nested `public/usage-examples/<category>/<function>/<files>` and flat `public/usage-examples/<category>/<files>`.
- Link checks: `npm run check-links` - sets `CHECK_LINKS` then builds; used in CI.

Repository conventions & patterns (concrete)
- MDX auto-generation: `scripts/api-pages-script.cjs` reads `scripts/json-files/api.json` and writes `src/content/docs/api/*.mdx`.
- Usage examples: each example must include the 6 files described in `public/usage-examples/CONTRIBUTING.mdx` — `.cpp`, `.cs` (top-level), `.cs` (oop), `.py`, screenshot (.png/.gif/.webm) and `.txt` description. Filenames use the `unique_global_name-1-example.*` pattern. See `scripts/usage-examples-testing-script.cjs`.
- `api.json` drives API docs; `guides.json` maps guides -> functions. Use `npm run setup` to keep MDX in sync.
- Naming: `unique_global_name` keys in JSON -> used to map examples to API functions and generate links; signatures and code tabs use language-specific conventions.

Coding & style tips specific to this repo
- Examples are beginner-friendly and short. For multi-language examples use:
  - C++: snake_case, braces on a new line, 4-space indent.
  - C#: PascalCase functions; provide both top-level + OOP variants (use `-top-level.cs` & `-oop.cs` conventions).
  - Python: snake_case.
- Use `?raw` imports for inline code in MDX (scripts expect this when generating MDX). Review `scripts/api-pages-script.cjs` for examples.

Components & cross-cutting conventions
- `src/components/` contains site components used by MDX (e.g., `Signatures.astro`) — prefer reusing such components for consistent UX.
- `public/json-files/api.json` contains structured data for functions, signatures, types and is the single source of truth for API docs.
- `src/styles/` stores CSS conventions; update only when UI changes propagate across pages.

When making changes (PR checklist for AI assistance suggestions)
1. Ensure `npm run generate-json` and/or `npm run generate-mdx` produce expected MDX output locally.
2. Run `node scripts/usage-examples-testing-script.cjs <exampleKey>` when adding examples.
3. Run `npm run build` and `npm run check-links` (if link changes were made) to validate CI.
4. Add or update `src/content/docs/*` MDX with correct frontmatter: `title`, `description` & `sidebar.label`.

Examples for prompts and tasks
- Create usage example: "Use `public/usage-examples/<category>/<unique_global_name>` naming; include the 6 files; run `node scripts/usage-examples-testing-script.cjs unique_global_name-1-example` to validate." 
- Regenerate API docs: "Update `scripts/json-files/*` if new guides are added, then run `npm run setup` to re-create MDX pages."

Where to read more
- `README.md` — project features & commands
- `public/usage-examples/CONTRIBUTING.mdx` — usage example rules
- `scripts/*.cjs` — canonical behaviour for MDX generation & testing

If anything here is unclear or you want more examples (e.g., function-level MDX snippet to create), ask and I'll add samples.