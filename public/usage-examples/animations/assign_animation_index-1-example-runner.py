#!/usr/bin/env python3
"""Runner to verify assign_animation (by index) usage example.

Usage:
  py -3 assign_animation_index-1-example-runner.py <path/to/kermit.txt> <index>

This runner parses the animation script and prints the identifier at the
requested index to verify that assigning by index will pick the correct animation.
"""
import sys
from pathlib import Path


def build_identifiers(script_path: Path):
    ids = []
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                parts = s[2:].split(',')
                if len(parts) >= 1:
                    ids.append(parts[0].strip())
    return ids


def main():
    if len(sys.argv) < 3:
        print('Usage: py -3 assign_animation_index-1-example-runner.py <script> <index>')
        return 2

    path = Path(sys.argv[1])
    try:
        idx = int(sys.argv[2])
    except Exception:
        print('Index must be an integer')
        return 2

    if not path.exists():
        print(f'Error: file not found: {path}')
        return 2

    ids = build_identifiers(path)
    if idx < 0 or idx >= len(ids):
        print(f'Index {idx} out of range (0..{len(ids)-1})')
        return 1

    name = ids[idx]
    print(f'Assigned index {idx} -> animation identifier: {name}')
    return 0


if __name__ == '__main__':
    raise SystemExit(main())
