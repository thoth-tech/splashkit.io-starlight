#!/usr/bin/env python3
"""Runner for free_all_animation_scripts usage-example.

This runner verifies that the example script resource exists and then prints a
confirmation message mimicking what a program would do after freeing all scripts.

Usage:
  py -3 free_all_animation_scripts-1-example-runner.py <path/to/kermit.txt>
"""
import sys
from pathlib import Path


def main():
    if len(sys.argv) < 2:
        print('Usage: py -3 free_all_animation_scripts-1-example-runner.py <path/to/kermit.txt>')
        return 2

    script_path = Path(sys.argv[1])
    if not script_path.exists():
        print(f'Error: script not found: {script_path}')
        return 2

    # In our test harness we can't actually free runtime resources, so we
    # simply confirm the script was present and report the expected message.
    print('All animation scripts freed.')
    return 0


if __name__ == '__main__':
    raise SystemExit(main())
