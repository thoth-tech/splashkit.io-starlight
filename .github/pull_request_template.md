# Description
Please include a summary of the changes and the related issue. Please also include relevant motivation and context. List any dependencies that are required for this change.

## Type of change
Please delete options that are not relevant.

- [ ] Bug fix (non-breaking change which fixes an issue)
- [ ] New feature (non-breaking change which adds functionality)
- [ ] Breaking change (fix or feature that would cause existing functionality to not work as expected)
- [ ] Documentation (update or new)

## How Has This Been Tested?
Please describe the tests that you ran to verify your changes. Provide instructions so we can reproduce. Please also list any relevant details for your test configuration.

### Testing Checklist
- [ ] Tested in latest Chrome
- [ ] Tested in latest Firefox
- [ ] `npm run build`
- [ ] `npm run preview`

## Checklist
Please delete options that are not relevant.

### If involving code
- [ ] My code follows the style guidelines of this project
- [ ] I have performed a self-review of my own code
- [ ] I have commented my code in hard-to-understand areas
- [ ] I have made corresponding changes to the documentation
- [ ] My changes generate no new warnings

### If modified config files
- [ ] I have checked the following files for changes:
    - [ ] package.json
    - [ ] astro.config.mjs
    - [ ] netlify.toml
    - [ ] docker-compose.yml
    - [ ] custom.css

## Folders and Files Added/Modified
Please list the folders and files added/modified with this pull request and delete options that are not relevant.

### Added:
- folder/folder
- folder/folder

### Modified:
- folder/file
- folder/file

## Additional Notes
Please add any additional information that might be useful for the reviewers.

---

### Geometry Example Validation (Optional)
<!-- 
To validate a single geometry example:
node ./scripts/usage-examples-testing-script.cjs <example_key>

To validate all geometry examples (PowerShell):
$dir = "public/usage-examples/geometry"; $examples = Get-ChildItem -Path $dir -Filter "*-example.txt" | Select-Object -ExpandProperty BaseName | Sort-Object -Unique; if (-not $examples) { Write-Error "No *-example.txt files found in $dir"; exit 1 }; $failed = @(); foreach ($ex in $examples) { Write-Host "`n=== Validating $ex ==="; node .\scripts\usage-examples-testing-script.cjs $ex; if ($LASTEXITCODE -ne 0) { $failed += $ex } }; if ($failed.Count -gt 0) { Write-Host "`nFAILED examples:"; $failed | ForEach-Object { Write-Host " - $_" }; exit 1 } else { Write-Host "`nAll Geometry examples validated successfully: $($examples.Count)" }
-->
