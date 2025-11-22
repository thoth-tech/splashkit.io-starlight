#!/usr/bin/env python3
"""Runner to verify assign_animation by index with sound option.

Usage:
  py -3 assign_animation_index_with_sound-1-example-runner.py <path/to/kermit.txt> <index> <with_sound>

Prints the identifier at index and whether a sound is present (and prints file name when found).
"""
import sys
from pathlib import Path


def parse_script(script_path: Path):
    identifiers = []
    sounds = {}
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                parts = s[2:].split(',')
                if len(parts) >= 2:
                    identifiers.append((parts[0].strip(), int(parts[1].strip())))
            elif s.lower().startswith('s:'):
                parts = s[2:].split(',')
                if len(parts) >= 3:
                    try:
                        frame = int(parts[0].strip())
                    except ValueError:
                        continue
                    sounds[frame] = parts[2].strip()
    return identifiers, sounds


def str_to_bool(s: str) -> bool:
    return s.lower() in ('1', 'true', 't', 'yes', 'y')


def main():
    if len(sys.argv) < 4:
        print('Usage: py -3 assign_animation_index_with_sound-1-example-runner.py <script> <index> <with_sound>')
        return 2

    path = Path(sys.argv[1])
    try:
        idx = int(sys.argv[2])
    except Exception:
        print('Index must be an integer')
        return 2

    with_sound = str_to_bool(sys.argv[3])

    if not path.exists():
        print(f'Error: file not found: {path}')
        return 2

    ids, sounds = parse_script(path)
    if idx < 0 or idx >= len(ids):
        print(f'Index {idx} out of range (0..{len(ids)-1})')
        return 1

    name, start_cell = ids[idx]
    if with_sound:
        sound = sounds.get(start_cell)
        if sound:
            print(f'Assigned index {idx} -> {name}, with_sound=True -> sound file: {sound}')
        else:
            print(f'Assigned index {idx} -> {name}, with_sound=True -> no sound at start frame')
    else:
        print(f'Assigned index {idx} -> {name}, with_sound=False')

    return 0


if __name__ == '__main__':
    raise SystemExit(main())
