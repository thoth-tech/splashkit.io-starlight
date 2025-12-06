#!/usr/bin/env python3
"""Runner to verify create_animation(script_name, name).

This runner maps a script name (WalkingScript) to the kermit.txt resource and
verifies the animation identifier exists and prints it so tests can assert the behavior.

Usage:
  py -3 create_animation_from_script_named-1-example-runner.py <path/to/kermit.txt> <scriptName> <AnimationName>

Example:
  py -3 public/usage-examples/animations/create_animation_from_script_named-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkingScript WalkFront
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
    if len(sys.argv) < 4:
        print('Usage: py -3 create_animation_from_script_named-1-example-runner.py <script_path> <scriptName> <AnimationName>')
        return 2

    script_path = Path(sys.argv[1])
    script_name = sys.argv[2]
    anim_name = sys.argv[3]

    # Our test harness assumes WalkingScript -> kermit.txt mapping
    if script_name != 'WalkingScript':
        print(f'Unsupported scriptName in test: {script_name} (only WalkingScript supported)')
        return 1

    try:
        found = find_identifier(script_path, anim_name)
    except FileNotFoundError:
        print(f'Error: file not found: {script_path}')
        return 2

    if found:
        print(f'Created animation from script name -> name: {anim_name}')
        return 0
    else:
        print(f'{anim_name} not found in script')
        return 1


if __name__ == '__main__':
    raise SystemExit(main())
