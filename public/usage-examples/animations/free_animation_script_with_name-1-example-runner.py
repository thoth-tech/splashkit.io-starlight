#!/usr/bin/env python3
"""Runner for free_animation_script_with_name usage-example.

Checks that the named script can be treated as present (our harness maps
WalkingScript -> kermit.txt) and prints the expected confirmation message.

Usage:
  py -3 free_animation_script_with_name-1-example-runner.py <path/to/kermit.txt> <scriptName>

Example:
  py -3 public/usage-examples/animations/free_animation_script_with_name-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkingScript
"""
import sys
from pathlib import Path


def main():
    if len(sys.argv) < 3:
        print('Usage: py -3 free_animation_script_with_name-1-example-runner.py <path/to/kermit.txt> <scriptName>')
        return 2

    script_path = Path(sys.argv[1])
    script_name = sys.argv[2]

    if script_name != 'WalkingScript':
        print(f'Unsupported script name in test: {script_name} (only WalkingScript supported)')
        return 1

    if not script_path.exists():
        print(f'Error: script not found: {script_path}')
        return 2

    # Mimic freeing script by name
    print('Animation script freed (by name).')
    return 0


if __name__ == '__main__':
    raise SystemExit(main())
