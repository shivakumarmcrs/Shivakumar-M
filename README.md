This repository contains four independent C# programs, each stored in a separate .cs file.
All programs are written in C# (.NET).

How to run : 

if running in visual studio
Each .cs file contains its own Main() method.
C# project cannot run multiple entry points at the same time,so you must do the following:
Comment out the Main() methods in the other problem files.
 // static void Main() { ... }
Open the file (Example: Problem1.cs)
Click the green “Run symbol” button
This runs only that file’s Main() method.

Do the same for:

Problem1.cs → Click Run
Problem2.cs → Click Run
Problem3.cs → Click Run
Problem4.cs → Click Run

Each file runs separately.
