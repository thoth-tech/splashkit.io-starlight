#!/usr/bin/env python3
"""Runner to verify animation_current_cell example using the kermit animation script.

It parses the animation script for identifier lines `i:Name,value` and prints the starting cell for the named animation (WalkFront).

Usage:
  py -3 animation_current_cell-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt
"""
import sys
from pathlib import Path


def find_animation_cell(script_path: Path, name: str) -> int:
    if not script_path.exists():
        raise FileNotFoundError(script_path)
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                # i:Name,0
                parts = s[2:].split(',')
                if len(parts) >= 2:
                    anim_name = parts[0].strip()
                    try:
                        idx = int(parts[1].strip())
                    except ValueError:
                        continue
                    if anim_name.lower() == name.lower():
                        return idx
    return -1


def main():
    if len(sys.argv) < 2:
        print("Usage: py -3 animation_current_cell-1-example-runner.py <path/to/kermit.txt>")
        return 2

    path = Path(sys.argv[1])
    try:
        idx = find_animation_cell(path, 'WalkFront')
    except FileNotFoundError:
        print(f"Error: file not found: {path}")
        return 2

    if idx >= 0:
        print(f"WalkFront starts at cell index: {idx}")
        return 0
    else:
        print("WalkFront animation not found in script")
        return 1


if __name__ == '__main__':
    raise SystemExit(main())
