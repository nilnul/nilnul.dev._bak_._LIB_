# nilnul.dev._bak_._LIB_

A library to bak (backup) your local repos to a collection of remote servers, such that you files would never get lost;

It can
- automatically name your repo if you follow a specified structure; so can just put your repo in a certain location, and this software can handle the rest for you (you even don't need to init it!);
- create corresponding repo on the server;
- create a bak branch in your local repo to keep your work-in-process before pushing it to the servers;
- push also other branches;
- push some branches you named as `pub-*` to the pub servers as you configurated; this is useful if some repo is open source one;

This currently targets dotnet framework 4.8.1; 

To develop this:
- download this repo into a folder named, say, <var>nilnul.dev._bak_</var>;
- also download nilnul.dev._bak_._CTR_ and nilnul.dev._bak_._WIN_ into that folder; nilnul.dev._bak_._WIN_ is the winForm appliction, which need to “project reference” nilnul.dev._bak_._CTR_ and nilnul.dev._bak_._LIB_;
- other dependencies shall be automatically restored when you build;
- now you can run;

To run this, you need some configurations:
- configure a collection of disjoint folders as srcs; under each src, every repo is named after its relative path to the path;
- configure a collection of remote servers; we now support github, gitlab, azure, amazon; 
  For some regions in east asia, github connection is not stable, so it's defaulted to ssh for pushing; for other regions, the connection can be, in our plan, defaulted to https;
- click menu "Bak - Folders -Srcs", your configurated srcs shall appear there; click start to begin the bakking process;

This software is currently in preview; if you have any question, open an issue;
