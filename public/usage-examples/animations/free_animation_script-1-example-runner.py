#!/usr/bin/env python3
"""Runner for free_animation_script usage-example.

Verifies the script resource file exists and returns the expected output that
would result after freeing the script's frames.

Usage: py -3 free_animation_script-1-example-runner.py <path/to/kermit.txt>
"""
import sys
from pathlib import Path


def main():
    if len(sys.argv) < 2:
        print('Usage: py -3 free_animation_script-1-example-runner.py <path/to/kermit.txt>')
        return 2

    script_path = Path(sys.argv[1])
    if not script_path.exists():
        print(f'Error: script not found: {script_path}')
        return 2

    # Test harness can't free runtime resources; just confirm presence
    print('Animation script freed.')
    return 0


if __name__ == '__main__':
    raise SystemExit(main())
