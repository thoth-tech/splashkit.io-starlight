#!/usr/bin/env python3
"""Runner to verify assign_animation(anim, name) example.

This runner checks the script resource for the named animation and prints the name
after switching to it (it just validates the identifier exists for the test resource).

Usage:
  py -3 assign_animation-1-example-runner.py <path/to/kermit.txt> <AnimationName>
Example:
  py -3 public/usage-examples/animations/assign_animation-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt Dance
"""
import sys
from pathlib import Path


def find_identifier(script_path: Path, name: str) -> bool:
    if not script_path.exists():
        raise FileNotFoundError(script_path)
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                parts = s[2:].split(',')
                if len(parts) >= 1 and parts[0].strip().lower() == name.lower():
                    return True
    return False


def main():
    if len(sys.argv) < 3:
        print('Usage: py -3 assign_animation-1-example-runner.py <script> <AnimationName>')
        return 2

    script = Path(sys.argv[1])
    name = sys.argv[2]

    try:
        found = find_identifier(script, name)
    except FileNotFoundError:
        print(f'Error: file not found: {script}')
        return 2

    if found:
        print(f'Assigned animation -> name: {name}')
        return 0
    else:
        print(f'{name} not found in script')
        return 1


if __name__ == '__main__':
    raise SystemExit(main())
