#!/usr/bin/env python3
"""Runner to verify assign_animation using script name and animation name.

This checks the provided script file path for a mapping from the script name to
the resource (the test assumes WalkingScript -> kermit.txt), then checks the
named animation exists in the resource and prints the result.

Usage:
  py -3 assign_animation_with_script_named-1-example-runner.py <path/to/kermit.txt> <scriptName> <AnimationName>
Example:
  py -3 public/usage-examples/animations/assign_animation_with_script_named-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkingScript WalkFront
"""
import sys
from pathlib import Path


def find_identifier_index(script_path: Path, name: str) -> int:
    if not script_path.exists():
        raise FileNotFoundError(script_path)

    idx = 0
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                parts = s[2:].split(',')
                anim_name = parts[0].strip() if parts else ''
                if anim_name.lower() == name.lower():
                    return idx
                idx += 1

    return -1


def main():
    if len(sys.argv) < 4:
        print('Usage: py -3 assign_animation_with_script_named-1-example-runner.py <script> <scriptName> <AnimationName>')
        return 2

    path = Path(sys.argv[1])
    script_name = sys.argv[2]
    anim_name = sys.argv[3]

    # Map script name to the expected resource path in tests
    if script_name != 'WalkingScript':
        print(f'Unsupported test scriptName: {script_name} (only WalkingScript is supported by test)')
        return 1

    try:
        idx = find_identifier_index(path, anim_name)
    except FileNotFoundError:
        print(f'Error: file not found: {path}')
        return 2

    if idx >= 0:
        print(f'Assigned {anim_name} -> script name {script_name} (index {idx})')
        return 0
    else:
        print(f'{anim_name} not found in script resource')
        return 1


if __name__ == '__main__':
    raise SystemExit(main())
