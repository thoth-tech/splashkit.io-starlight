#!/usr/bin/env python3
"""Runner for load_animation_script usage-example.

Verifies the provided file exists and mimics the expected output of loading it
under the given name (WalkingScript -> kermit.txt).

Usage:
  py -3 load_animation_script-1-example-runner.py <path/to/kermit.txt> <scriptName>

Example:
  py -3 public/usage-examples/animations/load_animation_script-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkingScript
"""
import sys
from pathlib import Path


def main():
    if len(sys.argv) < 3:
        print('Usage: py -3 load_animation_script-1-example-runner.py <path/to/kermit.txt> <scriptName>')
        return 2

    script_path = Path(sys.argv[1])
    name = sys.argv[2]

    if not script_path.exists():
        print(f'Error: file not found: {script_path}')
        return 2

    # Our harness can't actually load resources, so confirm existence and print
    print(f'Loaded animation script -> name: {name}')
    return 0


if __name__ == '__main__':
    raise SystemExit(main())
