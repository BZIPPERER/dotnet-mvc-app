youtube.com/watch?v=hZS96dwKvt0 (GameChanger Yesterday)
INTRO:
Imageine a server collecting dots
Every dot is a commit / checksum
You do them locally then push it.

[Keyword] : Related commits to each other: important tool: HEAD

You see HEAD written, 
but HEAD can move , it is an index, it can be danglesd you can "check out/in"

Never work with a check out HEAD in nirvana.

example:

INITIAL
29d3f
ab301
42236
0bc1c
TOP = HEAD

Branch : the other Thing
BUT:
If you do "git checkout 42236" what do you get:
a dangeled HEAD ; message says "..ou can look around"
Do this but nor write anything here, Please create 
a branch or checkout master/main again.


The HEAD moves along the branch name (like hotfix)

Every time you update I gonna update that branch name.


MERGE: the threeway merge is important and standard.

 
IMPORTANT: WHAT YOU SEE IS WHAT YOU GET EVEN IF YOU ONLY FETCH
A fetch from development branch e.g. oracle-development
does automatic renaming:
remotes/origin/oracle-development

Repeat fetch => download commits but does not update it just moves the local copy?

Only on pull Git will merge ...
2.nd possibility: fetch + merge (equals pull)












