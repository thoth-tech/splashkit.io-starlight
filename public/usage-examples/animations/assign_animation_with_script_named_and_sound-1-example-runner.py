#!/usr/bin/env python3
"""Runner to verify assign_animation with script name + sound option.

Checks the provided script file for the requested animation name, and if with_sound
is set, checks whether a sound is present on the animation's starting frame.

Usage:
  py -3 assign_animation_with_script_named_and_sound-1-example-runner.py <path/to/kermit.txt> <scriptName> <AnimationName> <with_sound>

Example:
  py -3 public/usage-examples/animations/assign_animation_with_script_named_and_sound-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkingScript WalkFront True
"""
import sys
from pathlib import Path


def find_identifier_index_and_start(script_path: Path, name: str):
    idx = 0
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                parts = s[2:].split(',')
                if parts:
                    anim_name = parts[0].strip()
                    start_cell = None
                    if len(parts) >= 2:
                        try:
                            start_cell = int(parts[1].strip())
                        except ValueError:
                            start_cell = None
                    if anim_name.lower() == name.lower():
                        return idx, start_cell
                    idx += 1
    return -1, None


def parse_sounds(script_path: Path):
    sounds = {}
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


def str_to_bool(s: str) -> bool:
    return s.lower() in ('1', 'true', 't', 'yes', 'y')


def main():
    if len(sys.argv) < 5:
        print('Usage: py -3 assign_animation_with_script_named_and_sound-1-example-runner.py <script> <scriptName> <AnimationName> <with_sound>')
        return 2

    script_path = Path(sys.argv[1])
    script_name = sys.argv[2]
    anim_name = sys.argv[3]
    with_sound = str_to_bool(sys.argv[4])

    if script_name != 'WalkingScript':
        print(f'Unsupported test scriptName: {script_name} (only WalkingScript in test harness)')
        return 1

    if not script_path.exists():
        print(f'Error: file not found: {script_path}')
        return 2

    idx, start_cell = find_identifier_index_and_start(script_path, anim_name)
    if idx < 0:
        print(f'{anim_name} not found in script')
        return 1

    if with_sound:
        sounds = parse_sounds(script_path)
        sound_name = sounds.get(start_cell)
        if sound_name:
            print(f'Assigned {anim_name} -> script name {script_name} (index {idx}), with_sound=True -> sound file: {sound_name}')
        else:
            print(f'Assigned {anim_name} -> script name {script_name} (index {idx}), with_sound=True -> no sound at start frame')
    else:
        print(f'Assigned {anim_name} -> script name {script_name} (index {idx}), with_sound=False')

    return 0


if __name__ == '__main__':
    raise SystemExit(main())
