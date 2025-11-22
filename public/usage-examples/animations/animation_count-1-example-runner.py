#!/usr/bin/env python3
"""Simple runner to verify the Animation Count usage example resources.

This script counts the number of animation identifiers in an AnimationScript file.
It treats lines that start with "i:" (case-insensitive, trimming whitespace) as animation definitions.

Usage:
  py -3 animation_count-1-example-runner.py <path/to/kermit.txt>

Returns exit code 0 and prints the count on success.
"""
import sys
from pathlib import Path


def count_animations(script_path: Path) -> int:
    if not script_path.exists():
        raise FileNotFoundError(script_path)
    count = 0
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            if line.strip().lower().startswith('i:'):
                count += 1
    return count


def main():
    if len(sys.argv) < 2:
        print("Usage: py -3 animation_count-1-example-runner.py <path/to/script.txt>")
        return 2

    path = Path(sys.argv[1])
    try:
        total = count_animations(path)
    except FileNotFoundError:
        print(f"Error: file not found: {path}")
        return 2

    print(f"Found {total} animation identifier(s) in {path}")
    return 0


if __name__ == '__main__':
    raise SystemExit(main())
