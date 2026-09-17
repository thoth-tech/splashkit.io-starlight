# Maintaining the PR Queue

A routine for team leads and mentors, run every trimester.

Each cohort leaves open PRs behind when it moves on, and the queue grows faster than it gets cleared. On 17 Sep 2026 there were 235 open PRs in this repo. 174 of them were opened before that trimester started, and 108 were from before T3 2025.

The routine has three parts: clear what the last cohort left in the first two weeks, run a short check every week, and hand over a short list at the end.

All commands use the [GitHub CLI](https://cli.github.com/) against `thoth-tech/splashkit.io-starlight`. Set `START` to the first day of the trimester before running them.

```shell
START=2026-07-01
```

## Weeks 1-2: Clear the Previous Cohort's PRs

Do this before the new team starts opening PRs.

1. List every open PR from before the trimester started:

   ```shell
   gh pr list --repo thoth-tech/splashkit.io-starlight --state open --limit 500 \
     --search "created:<$START" \
     --json number,title,author,updatedAt \
     --jq '.[] | "#\(.number)\t\(.updatedAt[:10])\t\(.author.login)\t\(.title)"'
   ```

2. Check whether the author is still on the team. If they are, their PR just joins the weekly check below.

3. For PRs whose author has left, decide one of:

   - **Merge it.** It follows the current usage example conventions and has no conflicts with `main`. Review it like any other PR.
   - **Adopt it.** It's worth keeping but needs work. Someone on the current team opens a new PR with the fixes, credits the original author in the description, and closes the old PR with a link to the new one.
   - **Close it.** It duplicates a merged example, targets something that no longer exists, or is too far behind `main` to be worth rebasing.

   ```shell
   gh pr close <number> --repo thoth-tech/splashkit.io-starlight --comment "Closing as part of the start-of-trimester cleanup: <reason>. Thanks for the contribution. Feel free to reopen this or open a new PR against main if you'd like to pick it back up."
   ```

4. Update the Planner board to match. Any card whose PR was merged or closed should be completed or removed.

## Every Week: Sort Open PRs Into Four Groups

Run this on the same day each week. Before the team meeting works well.

```shell
gh pr list --repo thoth-tech/splashkit.io-starlight --state open --limit 500 \
  --search "created:>=$START" --json number,title,author,reviews \
  --jq '.[]
    | ([.reviews[] | select(.state == "APPROVED" or .state == "CHANGES_REQUESTED")]
       | group_by(.author.login) | map(max_by(.submittedAt).state)) as $latest
    | (if ($latest | index("CHANGES_REQUESTED")) then "4-changes-requested"
       elif ([$latest[] | select(. == "APPROVED")] | length) >= 2 then "3-ready-to-merge"
       elif ($latest | index("APPROVED")) then "2-needs-second-approval"
       else "1-needs-first-review" end) as $group
    | "\($group)\t#\(.number)\t\(.author.login)\t\(.title)"' | sort
```

Only each reviewer's latest approval or change request counts. A reviewer who asked for changes and later approved has cleared their own request. Comment-only reviews don't move a PR between groups.

| Group | What it means | What to do |
| --- | --- | --- |
| 1. Needs first review | No approvals or change requests yet | Assign a reviewer. Aim for a first review within 7 days of the PR opening. |
| 2. Needs second approval | One approval, nothing outstanding | Find a second reviewer. |
| 3. Ready to merge | Two or more approvals, nothing outstanding | Move the Planner card to Mentor Review and get it merged within 3 days. Clear this group first, since it only needs someone to press merge. |
| 4. Changes requested | At least one change request still open | Open the PR and check who is waiting. If the author hasn't replied or pushed since the request, nudge the author. If they have, nudge the reviewer to take another look. Raise anything stuck here for more than 7 days at the team meeting. |

Things to watch for:

- **One open change request outweighs any number of approvals.** GitHub's review status on a PR doesn't always agree with this, so go by the grouping above rather than the badge.
- **Before approving a PR that had changes requested,** check that a commit landed after the request, or that the reviewer who asked has since approved:

  ```shell
  gh pr view <number> --repo thoth-tech/splashkit.io-starlight --json reviews,commits \
    --jq '{last_change_request: ([.reviews[] | select(.state == "CHANGES_REQUESTED") | .submittedAt] | max), last_commit: ([.commits[].committedDate] | max)}'
  ```

- **Netlify comments on every PR,** so a comment count above zero doesn't mean the author or a reviewer has replied.
- **Every card moving from Doing to First Peer Review needs its PR link.** Without it, matching the board to GitHub later means guessing.

## Last Two Weeks: Hand Over

1. Merge everything in group 3.
2. Comment on every PR that will stay open, saying what it still needs and whether the author is continuing next trimester.
3. Check the Planner Complete bucket against GitHub. A card only belongs in Complete if its PR is merged.
4. Leave next trimester's lead a list of what's still open, so their weeks 1-2 start from that list instead of the whole queue.
