# Description

**Category:** geometry

**What this PR adds:**

- Ensures the Geometry usage examples are complete and validate cleanly.
- Improves the usage-example validator script so individual examples can be validated reliably with the repo's flat-file usage-example layout.

## Type of change

- [x] Documentation / examples (usage examples and supporting assets)
- [x] Tooling / scripts (validation improvements)
- [ ] Bug fix (non-breaking change which fixes an issue)
- [ ] New feature (non-breaking change which adds functionality)
- [ ] Breaking change

## How Has This Been Tested?

- `npm run build`
- Validated a full pass over Geometry usage examples (27 example keys) using the validator script in single-example mode.

## Testing Commands

**Single example**

```sh
node ./scripts/usage-examples-testing-script.cjs center_point-1-example
```

**All Geometry examples (PowerShell)**

```powershell
$dir = "public/usage-examples/geometry"; $examples = Get-ChildItem -Path $dir -Filter "*-example.txt" | Select-Object -ExpandProperty BaseName | Sort-Object -Unique; if (-not $examples) { Write-Error "No *-example.txt files found in $dir"; exit 1 }; $failed = @(); foreach ($ex in $examples) { Write-Host "`n=== Validating $ex ==="; node .\scripts\usage-examples-testing-script.cjs $ex; if ($LASTEXITCODE -ne 0) { $failed += $ex } }; if ($failed.Count -gt 0) { Write-Host "`nFAILED examples:"; $failed | ForEach-Object { Write-Host " - $_" }; exit 1 } else { Write-Host "`nAll Geometry examples validated successfully: $($examples.Count)" }
```

## Checklist

- [x] I have performed a self-review of my changes
- [x] `npm run build` completes successfully
- [x] Usage examples follow repo conventions (C++, C# top-level, C# OOP, Python, .txt, and output image/gif)
- [x] My changes generate no new warnings

## Files Modified/Added

- `public/usage-examples/geometry/` (validated example sets)
- `scripts/usage-examples-testing-script.cjs` (single-example validation mode)

## Additional Notes

- This PR uses the validator's single-example mode to avoid assumptions about nested example folders.
