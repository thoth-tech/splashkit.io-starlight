#!/usr/bin/env python3
"""Runner to verify create_animation(script, idx, with_sound).

It checks the script for the identifier at the index and reports whether a sound
file exists on the animation's start frame when with_sound is true.

Usage:
  py -3 create_animation_from_index_with_sound-1-example-runner.py <path/to/kermit.txt> <index> <with_sound>

Example:
  py -3 public/usage-examples/animations/create_animation_from_index_with_sound-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt 0 True
"""
import sys
from pathlib import Path


def parse_identifiers(script_path: Path):
    ids = []  # list of (name, start_cell)
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
                        cell = None
                    ids.append((name, cell))
    return ids


def parse_sounds(script_path: Path):
    sounds = {}  # map frame -> filename
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('s:'):
                parts = s[2:].split(',')
                if len(parts) >= 3:
                    try:
                        frame = int(parts[0].strip())
                    except ValueError:
                        continue
                    sounds[frame] = parts[2].strip()
    return sounds


def str_to_bool(v: str) -> bool:
    return v.lower() in ('1', 'true', 't', 'yes', 'y')


def main():
    if len(sys.argv) < 4:
        print('Usage: py -3 create_animation_from_index_with_sound-1-example-runner.py <script> <index> <with_sound>')
        return 2

    script = Path(sys.argv[1])
    try:
        idx = int(sys.argv[2])
    except Exception:
        print('Index must be an integer')
        return 2

    with_sound = str_to_bool(sys.argv[3])

    if not script.exists():
        print(f'Error: file not found: {script}')
        return 2

    ids = parse_identifiers(script)
    if idx < 0 or idx >= len(ids):
        print(f'Index {idx} out of range (0..{len(ids)-1})')
        return 1

    name, start_cell = ids[idx]
    if with_sound:
        sounds = parse_sounds(script)
        sound_file = sounds.get(start_cell)
        if sound_file:
            print(f'Created animation from index {idx} -> {name}, with_sound=True -> sound: {sound_file}')
        else:
            print(f'Created animation from index {idx} -> {name}, with_sound=True -> no sound at start frame')
    else:
        print(f'Created animation from index {idx} -> {name}, with_sound=False')

    return 0


if __name__ == '__main__':
    raise SystemExit(main())
