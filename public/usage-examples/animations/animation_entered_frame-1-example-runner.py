#!/usr/bin/env python3
"""Runner to verify animation_entered_frame example using explosion.txt.

This runner simulates a minimal 'last update' check: if the animation contains more than one distinct frame
or includes frame transitions (a 'next' to a different index), then an update will cause the animation to enter a new frame.
"""
import sys
from pathlib import Path


def animation_has_transitions(script_path: Path, name: str) -> bool:
    if not script_path.exists():
        raise FileNotFoundError(script_path)

    # Find start index for the animation name
    start_index = None
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s=line.strip()
            if s.lower().startswith('i:'):
                parts = s[2:].split(',')
                if len(parts)>=2 and parts[0].strip().lower()==name.lower():
                    try:
                        start_index=int(parts[1].strip())
                        break
                    except ValueError:
                        pass

    if start_index is None:
        return False

    # Collect all frame ids that belong to this animation
    frames = []
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s=line.strip()
            if not s.lower().startswith('f:'):
                continue
            rest = s[2:]
            parts=[p.strip() for p in rest.split(',')]
            if not parts:
                continue
            id_field = parts[0]
            if id_field.startswith('[') and id_field.endswith(']'):
                inner = id_field[1:-1]
                if '-' in inner:
                    a,b = inner.split('-',1)
                    frames.extend(range(int(a), int(b)+1))
                else:
                    vals = [int(x) for x in inner.split(',') if x]
                    frames.extend(vals)
            else:
                try:
                    frames.append(int(id_field))
                except ValueError:
                    continue

    if not frames:
        return False

    # If animation covers multiple frames it's possible to enter new frames on update
    if len(set(frames)) > 1:
        return True

    # Otherwise, check if any of those frames include a 'next' that is different (transition)
    with script_path.open('r', encoding='utf-8') as f:
        for line in f:
            s=line.strip()
            if not s.lower().startswith('f:'):
                continue
            rest = s[2:]
            parts=[p.strip() for p in rest.split(',')]
            id_field = parts[0]
            # if id_field contains the single frame and next exists and differs, we consider it a transition
            try:
                if id_field.startswith('['):
                    continue
                idx=int(id_field)
            except Exception:
                continue
            if idx in frames:
                if len(parts) >= 4:
                    next_val = parts[3]
                    if next_val != '' and int(next_val) != idx:
                        return True

    return False


def main():
    if len(sys.argv) < 2:
        print("Usage: py -3 animation_entered_frame-1-example-runner.py <path/to/explosion.txt>")
        return 2

    path = Path(sys.argv[1])
    try:
        entered = animation_has_transitions(path, 'explosion')
    except FileNotFoundError:
        print(f"Error: file not found: {path}")
        return 2

    print(f"explosion entered new frame on updates? {entered}")
    return 0


if __name__ == '__main__':
    raise SystemExit(main())
