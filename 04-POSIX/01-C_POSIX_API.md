# C POSIX Library

The `C POSIX Library` provides macros, type definitions and functions for tasks such as string handling, mathematical computations, input/output processing, memory management, and other things.

Essentially this Library provides most of the necessary functions for `C` as a language to function. Unlike most other languages everything done in `C` is mainly done at some of the lowest levels, this allows for greater efficiency and your code to run a lot faster.

Most programming languages are built in `C` this means this 'Standard Library' is incredibly important as if most languages are built on `C` and every `C` program needs these libraries to run then its a pretty big deal.

### What are `stdin` and `stdout`?

`stdin` (Standard Input) and `stdout` (Standard Output) are the two most fundamental functions in programming. They define the standard inputs and outputs for 99% of programs.

These are collectively known as `stdio` (Standard IO) and the 'IO' standing for 'Input/Output'.

##### `stdin` in action

```bash
cat file | yourprog
# or
yourprog <file
```

##### `stdout` in action

```bash
yourprog > someFile # Save 'stdout' to a file
yourprog >> someFile # Append 'stdout' to a file
```

### What are `stderr` and `pipe`

`stderr` (Standard Error) and `pipe` are two incredibly important C API's we can interact with.

`stderr` defines the standard way we handle errors in `C` and subsequently most other languages.

`pipe` is a really useful tool to that allows us to `pipe` our `stdout` into the `stdin` of another program.

##### `stderr` in practice

```bash
yourprog 2> someErrorFile.txt # Specify Stream 2 for 'stderr'
```

##### `pipe` in practice

```bash
yourprog | otherProgram # Pipe your stdout to the stdin of another program
```

### In summary

`C` has some amazing standard library features that learning the basic concepts of the C standard library will allow me as a developer to better utilise my skills.
