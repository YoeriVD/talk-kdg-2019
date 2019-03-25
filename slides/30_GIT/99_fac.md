## Life saving tip # 2

#### <!-- .element: class="fragment" --> -> gebruik git cmd, geen ui

--

## Getting sources

<!-- .slide: style="font-size: 22px" -->

| command                   | uitleg                                                                            |
| ------------------------- | --------------------------------------------------------------------------------- |
| `git pull`                | get all commits from master and merge with the active local branch                |
| `git stash`               | "shelve" all pending changes (useful before `git pull`)                           |
| `git stash pop`           | "unshelve" previously stashed changes                                             |
| `git remote prune origin` | lokale remotes branches die niet meer op de server bestaan ook lokaal verwijderen |
| `git fetch`               | kan je een oa. branch vanuit workitem gecreeërd lokaal beschikbaar maken          |

--

## Branching

<!-- .slide: style="font-size: 22px" -->

| command                                   | uitleg                                                                     |
| ----------------------------------------- | -------------------------------------------------------------------------- |
| `git checkout -b someFeatureOrBugFixName` | create a new branch from the current branch and switch to the new branch   |
| `git checkout master`                     | switch to a branch with the name master                                    |
| `git branch`                              | list all branches present on this machine"                                 |
| `git branch -d someFeatureOrBugFixName`   | delete a branch with name "someFeatureOrBugFixName" (only if it's merged!) |
| `git branch --merged`                     | list local merged branches (normally it's safe to delete)                  |

--

## Committing changes

<!-- .slide: style="font-size: 22px" -->

| command                         | uitleg                                        |
| ------------------------------- | --------------------------------------------- |
| `git status`                    | show unstaged and staged changes              |
| `git add *.cs`                  | stage all unstaged files ending in ".cs"      |
| `git commit -am "some message"` | add all staged changes, commit with a message |

--

## Merging

<!-- .slide: style="font-size: 22px" -->

| command                  | uitleg                                       |
| ------------------------ | -------------------------------------------- |
| `git pull origin master` | huidige branch up to date brengen met master |
| `git mergetool`          | => fix conflicts                             |
| `git commit [...]`       | => check in the merge                        |
| `git push`               | => sync with the master repository           |
