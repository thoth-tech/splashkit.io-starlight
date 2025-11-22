#!/usr/bin/env python3
"""Runner to verify animation_frame_time example using explosion.txt.

This extracts the frame duration (the 'dur' field) for the first frame belonging to
the `explosion` animation and prints it — this represents the intended per-frame duration.
"""
import sys
from pathlib import Path


def find_first_frame_duration(script_path: Path, anim_name: str):
    if not script_path.exists():
        raise FileNotFoundError(script_path)

    # First locate the starting index for the animation name
    start_index = None
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s=line.strip()
            if s.lower().startswith('i:'):
                parts = s[2:].split(',')
                if len(parts) >= 2 and parts[0].strip().lower()==anim_name.lower():
                    try:
                        start_index = int(parts[1].strip())
                        break
                    except Exception:
                        pass

    if start_index is None:
        return None

    # Find the frame for this index and return the dur (3rd field)
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s=line.strip()
            if not s.lower().startswith('f:'):
                continue
            rest = s[2:]
            parts = [p.strip() for p in rest.split(',')]
            if not parts:
                continue
            id_field = parts[0]
            # check if start_index is represented by id_field (single or range)
            def contains(idx, idf):
                if idf.startswith('[') and idf.endswith(']'):
                    inner = idf[1:-1]
                    if '-' in inner:
                        a,b = inner.split('-',1)
                        return idx >= int(a) and idx <= int(b)
                    else:
                        vals=[int(x) for x in inner.split(',') if x]
                        return idx in vals
                else:
                    try:
                        return int(idf)==idx
                    except Exception:
                        return False

            if contains(start_index, id_field):
                # parts: id, cell, dur, next
                if len(parts) >= 3:
                    try:
                        dur = float(parts[2])
                        return dur
                    except Exception:
                        return None
    return None


def main():
    if len(sys.argv) < 2:
        print('Usage: py -3 animation_frame_time-1-example-runner.py <path/to/explosion.txt>')
        return 2

    path = Path(sys.argv[1])
    try:
        dur = find_first_frame_duration(path, 'explosion')
    except FileNotFoundError:
        print(f'Error: file not found: {path}')
        return 2

    if dur is not None:
        print(f'First explosion frame duration (frame time): {dur}')
        return 0
    else:
        print('Could not find duration for the explosion animation frame')
        return 1


if __name__ == '__main__':
    raise SystemExit(main())
