# Teaching C#

A self-paced C# curriculum built for one specific goal: get someone with **zero coding
experience** to the point where they can open a Unity tutorial and follow along without
being lost.

This started as live-lecture scratch notes for teaching a friend 1:1, and is now public
in case it's useful to anyone else on the same path.

## How this repo is organized

Each topic is a single `.cs` file — a lecture "scratchpad" written and run live during a
session, comments and all. They're deliberately messy in places (dead-end thoughts,
commented-out experiments) because that's what live coding actually looks like, not a
cleaned-up final answer.

| File | Topic |
|---|---|
| [hello_world.cs](hello_world.cs) | Setup, running a C# file, `Console.WriteLine` |
| [variables.cs](variables.cs) | Types (`int`, `float`, `string`, `char`, `bool`), explicit vs. implicit (`var`) typing |
| [conditionals.cs](conditionals.cs) | `if`/`else if`/`else`, boolean logic, `&&` / `||` / `!` |
| [arrays.cs](arrays.cs) | Fixed-size arrays, multi-dimensional arrays |
| [lists.cs](lists.cs) | `List<T>`, `Add`/`Remove`/`AddRange`, a first taste of generics |

More topics (loops, methods, classes/OOP, and the eventual jump into Unity-specific
concepts) are being added as the lessons progress.

## How to use the lesson scratchpads

These files are **not** polished reference examples — they're the actual notes typed out
live while explaining a concept out loud, kept as-is on purpose. Read them the way you'd
read annotated lecture notes, not a textbook:

- Read top to bottom, including the comments — the comments *are* the narration.
- Commented-out lines aren't leftover junk, they're "here's the alternative we discussed"
  or "here's what happens if you do it wrong" — try uncommenting them and running the
  file to see for yourself.
- They're intentionally incomplete. The point is to watch a concept get built up
  step-by-step, not to hand you a finished answer.
- Each file has (or will have) a matching `_exercises.cs` file. The scratchpad is where a
  concept gets introduced; the exercises are where it actually sinks in. Do the exercises.

## Running the lessons

Each file is a full standalone C# file with its own `Main` method. Run one with:

```
dotnet run <filename>.cs
```

This requires the **.NET 10 SDK or newer** (file-based single-script apps — no `.csproj`
needed — were added in .NET 10). Check what you have:

```
dotnet --version
```

If you're on an older SDK, either upgrade, or scaffold a normal console project with
`dotnet new console` and paste the file's contents into `Program.cs`.

## Who this is for

Someone who has never written code before, but wants to get into Unity game development
specifically. The examples lean on game-y scenarios (health, damage, boss fights,
inventories) on purpose — the goal is to make the fundamentals feel connected to the
thing you actually want to build, not abstract exercises for their own sake.

This is not a replacement for a full C# course — it's the minimum on-ramp to stop being
lost, so that specific Unity tutorials (movement, combat, UI, whatever) become
approachable next.
