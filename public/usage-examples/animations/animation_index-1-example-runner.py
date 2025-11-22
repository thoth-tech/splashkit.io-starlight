#!/usr/bin/env python3
"""Runner to verify animation_index example using the kermit animation script.

It parses the animation script to find identifier lines `i:Name,value` and returns
the index (order) of the named animation (WalkFront) in the script.

Usage:
  py -3 animation_index-1-example-runner.py public/usage-examples/animations/Resources/animations/kermit.txt WalkFront
"""
import sys
from pathlib import Path


def find_animation_index(script_path: Path, name: str) -> int:
    if not script_path.exists():
        raise FileNotFoundError(script_path)

    idx = 0
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s = line.strip()
            if s.lower().startswith('i:'):
                # Format: i:Name,value
                parts = s[2:].split(',')
                if len(parts) >= 1:
                    anim_name = parts[0].strip()
                    if anim_name.lower() == name.lower():
                        return idx
                    idx += 1

    return -1


def main():
    if len(sys.argv) < 3:
        print("Usage: py -3 animation_index-1-example-runner.py <path/to/kermit.txt> <AnimationName>")
        return 2

    path = Path(sys.argv[1])
    name = sys.argv[2]
    try:
        index = find_animation_index(path, name)
    except FileNotFoundError:
        print(f"Error: file not found: {path}")
        return 2

    if index >= 0:
        print(f"Index of {name}: {index}")
        return 0
    else:
        print(f"{name} animation not found in script")
        return 1


if __name__ == '__main__':
    raise SystemExit(main())
