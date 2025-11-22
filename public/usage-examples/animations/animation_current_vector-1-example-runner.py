#!/usr/bin/env python3
"""Runner to verify animation_current_vector example using explosion.txt resource.

This parses `v:` lines in the animation script which are in the form:
  v:[frame-range],<x>,<y>
and prints the first vector found.
"""
import sys
from pathlib import Path


def find_first_vector(script_path: Path):
    if not script_path.exists():
        raise FileNotFoundError(script_path)
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('v:'):
                # v:[43-82],-1.5,20
                parts = s[2:].split(',')
                if len(parts) >= 3:
                    try:
                        x = float(parts[1])
                        y = float(parts[2])
                        return x, y
                    except ValueError:
                        continue
    return None


def main():
    if len(sys.argv) < 2:
        print("Usage: py -3 animation_current_vector-1-example-runner.py <path/to/script.txt>")
        return 2

    path = Path(sys.argv[1])
    try:
        v = find_first_vector(path)
    except FileNotFoundError:
        print(f"Error: file not found: {path}")
        return 2

    if v:
        print(f"Found vector for first v: entry -> x={v[0]} y={v[1]}")
        return 0
    else:
        print("No vector entries found in script")
        return 1


if __name__ == '__main__':
    raise SystemExit(main())
