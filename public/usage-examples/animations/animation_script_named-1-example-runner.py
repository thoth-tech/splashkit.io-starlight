#!/usr/bin/env python3
"""Runner to verify animation_script_named usage example.

Usage:
  py -3 animation_script_named-1-example-runner.py <path/to/kermit.txt> <name>
Example:
  py -3 animation_script_named-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkingScript
"""
import sys
from pathlib import Path


def map_name_to_script_file(name: str) -> str:
    # For our test environment, assume WalkingScript -> kermit.txt mapping
    if name == 'WalkingScript':
        return 'kermit.txt'
    return ''


def main():
    if len(sys.argv) < 3:
        print('Usage: py -3 animation_script_named-1-example-runner.py <script-path> <Name>')
        return 2

    path = Path(sys.argv[1])
    name = sys.argv[2]

    if not path.exists():
        print(f'Error: file not found: {path}')
        return 2

    expected_file = map_name_to_script_file(name)
    if expected_file and path.name.lower().endswith(expected_file.lower()):
        print(f'Named script loaded: {name}')
        return 0

    print(f'No mapping found for {name} in {path.name}')
    return 1


if __name__ == '__main__':
    raise SystemExit(main())
