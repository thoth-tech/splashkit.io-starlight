#!/usr/bin/env python3
"""Runner to verify assign_animation_with_script_and_sound usage example.

Usage:
  py -3 assign_animation_with_script_and_sound-1-example-runner.py <path/to/kermit.txt> <AnimationName> <with_sound>
Example:
  py -3 public/usage-examples/animations/assign_animation_with_script_and_sound-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkFront True
"""
import sys
from pathlib import Path


def parse_script(script_path: Path):
    identifiers = []  # list of tuples (name, start_cell)
    sounds = {}  # map frame -> (id, name, filename)

    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                parts = s[2:].split(',')
                if len(parts) >= 2:
                    name = parts[0].strip()
                    try:
                        cell = int(parts[1].strip())
                    except ValueError:
                        continue
                    identifiers.append((name, cell))
            elif s.lower().startswith('s:'):
                parts = s[2:].split(',')
                if len(parts) >= 3:
                    try:
                        frame = int(parts[0].strip())
                    except ValueError:
                        continue
                    sounds[frame] = (parts[1].strip(), parts[2].strip())

    return identifiers, sounds


def find_identifier_index(identifiers, name):
    for i, (n, cell) in enumerate(identifiers):
        if n.lower() == name.lower():
            return i, cell
    return -1, -1


def str_to_bool(s: str) -> bool:
    return s.lower() in ('1', 'true', 't', 'yes', 'y')


def main():
    if len(sys.argv) < 4:
        print('Usage: py -3 assign_animation_with_script_and_sound-1-example-runner.py <script> <Name> <with_sound>')
        return 2

    script_path = Path(sys.argv[1])
    name = sys.argv[2]
    with_sound = str_to_bool(sys.argv[3])

    if not script_path.exists():
        print(f'Error: file not found: {script_path}')
        return 2

    identifiers, sounds = parse_script(script_path)
    idx, start_cell = find_identifier_index(identifiers, name)

    if idx < 0:
        print(f'{name} not found in script')
        return 1

    sound_info = sounds.get(start_cell)

    if with_sound:
        if sound_info:
            print(f'Assigned {name} -> script identifier index: {idx}, with_sound=True -> sound found: {sound_info[1]}')
        else:
            print(f'Assigned {name} -> script identifier index: {idx}, with_sound=True -> no sound at start frame')
    else:
        print(f'Assigned {name} -> script identifier index: {idx}, with_sound=False')

    return 0


if __name__ == '__main__':
    raise SystemExit(main())
