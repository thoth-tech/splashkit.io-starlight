#!/usr/bin/env python3
"""Runner to verify animation_ended example using explosion.txt.

Determines whether a target animation (by name) has any frame entries whose "next" value is empty
which is how terminal frames are represented in these scripts.
"""
import sys
from pathlib import Path


def animation_ended_in_script(script_path: Path, name: str) -> bool:
    if not script_path.exists():
        raise FileNotFoundError(script_path)

    start_index = None
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                # id line: i:name,index
                parts = s[2:].split(',')
                if len(parts) >= 2 and parts[0].strip().lower() == name.lower():
                    try:
                        start_index = int(parts[1].strip())
                    except ValueError:
                        pass
                    break

    if start_index is None:
        return False

    # scan frames f: lines that include the start_index in their id/range
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if not s.lower().startswith('f:'):
                continue
            # Remove the f: prefix then split
            rest = s[2:]
            parts = [p.strip() for p in rest.split(',')]
            if not parts:
                continue
            id_field = parts[0]
            # handle ranges like [0-39] or single ids
            def id_contains(idx, id_field):
                idx = int(idx)
                if id_field.startswith('[') and id_field.endswith(']'):
                    inner = id_field[1:-1]
                    # ranges like 0-39 or comma lists
                    if '-' in inner:
                        a,b = inner.split('-',1)
                        return idx >= int(a) and idx <= int(b)
                    else:
                        values = [int(x) for x in inner.split(',') if x]
                        return idx in values
                else:
                    try:
                        return int(id_field) == idx
                    except ValueError:
                        return False

            if id_contains(start_index, id_field):
                # next value is usually last part: position 3 (0-based after splitting)
                # f: id, cell, dur, next -> next may be empty
                if len(parts) >= 4:
                    next_val = parts[3]
                    if next_val == '':
                        return True
                else:
                    # no next field means it's terminal
                    return True

    return False


def main():
    if len(sys.argv) < 2:
        print("Usage: py -3 animation_ended-1-example-runner.py <path/to/explosion.txt>")
        return 2

    path = Path(sys.argv[1])
    try:
        exploded = animation_ended_in_script(path, 'explosion')
        looped = animation_ended_in_script(path, 'explosion_loop')
    except FileNotFoundError:
        print(f"Error: file not found: {path}")
        return 2

    print(f"explosion ended? {exploded}")
    print(f"explosion_loop ended? {looped}")
    return 0


if __name__ == '__main__':
    raise SystemExit(main())
