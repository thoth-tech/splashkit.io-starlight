#!/usr/bin/env python3
"""Runner for restart_animation_with_sound usage-example.

This harness checks the animation identifier exists and prints the expected
confirmation message including the with_sound flag.

Usage:
  py -3 restart_animation_with_sound-1-example-runner.py <path/to/kermit.txt> <AnimationName> <with_sound>

Example:
  py -3 public/usage-examples/animations/restart_animation_with_sound-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkFront true
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
    if len(sys.argv) < 4:
        print('Usage: py -3 restart_animation_with_sound-1-example-runner.py <path/to/kermit.txt> <AnimationName> <with_sound>')
        return 2

    script_path = Path(sys.argv[1])
    name = sys.argv[2]
    with_sound = sys.argv[3].lower() in ('1', 'true', 'yes')

    try:
        found = animation_exists(script_path, name)
    except FileNotFoundError:
        print(f'Error: file not found: {script_path}')
        return 2

    if found:
        print(f'Animation restarted (with_sound={str(with_sound).lower()}).')
        return 0
    else:
        print(f'{name} not found in script')
        return 1


if __name__ == '__main__':
    raise SystemExit(main())
