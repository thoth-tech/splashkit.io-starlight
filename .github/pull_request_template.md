# Description

This PR adds usage examples for the `open_connection` function in the networking category. The examples demonstrate how to use the function across different programming languages (C++, C#, Python) with both OOP and top-level implementations.

The examples include:
- Code implementations in multiple languages
- Visual demonstration (PNG screenshot)
- Text description of the functionality

These examples will be automatically integrated into the API documentation through the build process.

## Type of change

- [ ] Bug fix (non-breaking change which fixes an issue)
- [ ] New feature (non-breaking change which adds functionality)
- [ ] Breaking change (fix or feature that would cause existing functionality to not work as
      expected)
- [x] Documentation (update or new)

## How Has This Been Tested?

The examples have been tested by:
1. Running the build process to ensure the examples are properly integrated
2. Verifying that the API documentation generates correctly with the new examples
3. Testing the example code in each supported language to ensure it compiles and runs correctly

To reproduce testing:
1. Run `npm install` to install dependencies
2. Run `npm run build` to generate the API documentation
3. Check that the networking API documentation includes the new `open_connection` examples

## Testing Checklist

- [x] Tested in latest Chrome
- [ ] Tested in latest Firefox
- [x] npm run build
- [ ] npm run preview

## Checklist

### If involving code

- [x] My code follows the style guidelines of this project
- [x] I have performed a self-review of my own code
- [ ] I have commented my code in hard-to-understand areas
- [x] I have made corresponding changes to the documentation
- [x] My changes generate no new warnings

### If modified config files

- [ ] I have checked the following files for changes:
  - [ ] package.json
  - [ ] astro.config.mjs
  - [ ] netlify.toml
  - [ ] docker-compose.yml
  - [ ] custom.css

## Folders and Files Added/Modified

- Added:
  - [x] public/usage-examples/networking/open_connection-1-example-oop.cs
  - [x] public/usage-examples/networking/open_connection-1-example-top-level.cs
  - [x] public/usage-examples/networking/open_connection-1-example.cpp
  - [x] public/usage-examples/networking/open_connection-1-example.png
  - [x] public/usage-examples/networking/open_connection-1-example.py
  - [x] public/usage-examples/networking/open_connection-1-example.txt
- Modified:
  - [ ] None

## Additional Notes

These usage examples follow the established pattern for SplashKit API documentation:
- Each function has examples in C++, C# (both OOP and top-level), and Python
- Visual demonstrations are provided via PNG screenshots
- Text descriptions explain the functionality and usage
- Files are organized in the standard naming convention: `function_name-example_number-example.extension`

The examples will be automatically integrated into the API documentation website through the existing build pipeline.
