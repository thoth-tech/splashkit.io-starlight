#!/usr/bin/env python3
"""Runner for has_animation_named usage-example.

Checks the script resource for the animation identifier and reports presence.

Usage:
  py -3 has_animation_named-1-example-runner.py <path/to/kermit.txt> <AnimationName>

Example:
  py -3 public/usage-examples/animations/has_animation_named-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkFront
"""
import sys
from pathlib import Path


def animation_exists(script_path: Path, name: str) -> bool:
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
        print('Usage: py -3 has_animation_named-1-example-runner.py <path/to/kermit.txt> <AnimationName>')
        return 2

    script_path = Path(sys.argv[1])
    name = sys.argv[2]

    try:
        found = animation_exists(script_path, name)
    except FileNotFoundError:
        print(f'Error: file not found: {script_path}')
        return 2

    print(f'Has animation named: {str(found).lower()}')
    return 0 if found else 1


if __name__ == '__main__':
    raise SystemExit(main())
