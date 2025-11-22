#!/usr/bin/env python3
"""Runner to verify assign_animation_with_script usage example.

This runner checks the target animation name exists in the animation script
and reports the index the anim would be assigned to.

Usage:
  py -3 assign_animation_with_script-1-example-runner.py <path/to/kermit.txt> <AnimationName>
Example:
  py -3 public/usage-examples/animations/assign_animation_with_script-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkFront
"""
import sys
from pathlib import Path


def find_identifier_index(script_path: Path, name: str) -> int:
    if not script_path.exists():
        raise FileNotFoundError(script_path)
    index = 0
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                parts = s[2:].split(',')
                if len(parts) >= 1:
                    anim_name = parts[0].strip()
                    if anim_name.lower() == name.lower():
                        return index
                    index += 1

    return -1


def main():
    if len(sys.argv) < 3:
        print('Usage: py -3 assign_animation_with_script-1-example-runner.py <path/to/kermit.txt> <AnimationName>')
        return 2

    script = Path(sys.argv[1])
    name = sys.argv[2]
    try:
        idx = find_identifier_index(script, name)
    except FileNotFoundError:
        print(f'Error: file not found: {script}')
        return 2

    if idx >= 0:
        print(f'Assigned {name} -> script identifier index: {idx}')
        return 0
    else:
        print(f'{name} not found in script {script.name}')
        return 1


if __name__ == '__main__':
    raise SystemExit(main())
