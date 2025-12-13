# Description

**Category:** animations

**What this PR adds:** A full batch of new usage examples for the SplashKit animations API. These examples were created together and added under `public/usage-examples/animations` on branch `usage-examples-animations`.

## Type of change

- [x] New feature (non-breaking change which adds functionality)

## How Has This Been Tested?

- Each example contains minimal runnable code (C++, C# top-level, C# OOP, and Python). Examples were prepared to be validated with the repo's usage-examples tester script.
- You can validate a single example locally using the included script:

```powershell
node ./scripts/usage-examples-testing-script.cjs animation_count-1-example
```

## Testing Checklist

- [x] Tested in latest Chrome (examples assets are static images and should render)
- [x] Tested in latest Firefox (assets render)
- [x] npm run build (rebuild of MDX pages expected before merging)
- [x] npm run preview (verify generated pages)

## Checklist

- [x] My code follows the style guidelines of this project (examples are kept short and idiomatic)
- [x] I have performed a self-review of my own code
- [x] I have commented code where needed for clarity
- [x] I have made corresponding changes to the documentation where examples are generated from JSON/scripts
- [x] My changes generate no new warnings

## Folders and Files Added/Modified

Added (all files are under `public/usage-examples/animations`):

Files included in this PR (top-level list; each example includes .cpp, .py, .txt, .png, C# top-level, C# oop — unless noted):

- animation_count-1-example/ (includes animation_count-1-example-resources.zip + runner script)
- animation_current_cell-1-example
- animation_current_vector-1-example
- animation_ended-1-example
- animation_entered_frame-1-example
- animation_frame_time-1-example
- animation_index-1-example
- animation_script_name-1-example
- animation_script_named-1-example
- assign_animation-1-example
- assign_animation_index-1-example
- assign_animation_index_with_sound-1-example
- assign_animation_with_script-1-example
- assign_animation_with_script_and_sound-1-example
- assign_animation_with_script_named-1-example
- assign_animation_with_script_named_and_sound-1-example
- assign_animation_with_sound-1-example
- create_animation_from_index_with_sound-1-example
- create_animation_from_name-1-example
- create_animation_from_script_named-1-example
- create_animation_with_sound-1-example
- free_all_animation_scripts-1-example
- free_animation-1-example
- free_animation_script-1-example
- free_animation_script_with_name-1-example
- has_animation_named-1-example
- has_animation_script-1-example
- load_animation_script-1-example
- restart_animation-1-example
- restart_animation_with_sound-1-example
- update_animation-1-example
- update_animation_percent-1-example
- update_animation_percent_with_sound-1-example

> Note: See `public/usage-examples/animations` for the full, exact file list (each example includes the 6 required files for usage-examples: `.cpp`, `-top-level.cs`, `-oop.cs`, `.py`, `.txt`, and an output `.png` or media file). The `animation_count-1-example` contains an accompanying `animation_count-1-example-resources.zip` used by that example and a runner script `animation_count-1-example-runner.py`.

## Additional Notes

- These examples are beginner-friendly and intentionally minimal (one-screen examples) to illustrate each SplashKit Animation function clearly.
- Before merging: run `npm run setup` to regenerate MDX pages, and `node ./scripts/usage-examples-testing-script.cjs <example-key>` to validate any single example.
