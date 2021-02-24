# Basic Concepts

The Basic Programming Concepts stay roughly the same across most languages especially across similar languages so it isn't too hard to pick up a new one once you understand some basic concepts.

A few basics to note before we continue.

- Every C# statement ends in a semicolon `;`
- C# is case-sensitive. `example` and `Example` can be two different objects
- Curly brackets `{}` mark the beginning and end of a block of code

- [What is a Namespace](#what-is-a-namespace)
- [Import Classes/Namespaces into your code](#importing-classes)
- [The Other Concepts are Roughly the Same](#the-other-concepts-are-roughly-the-same)

### What is a Namespace

A Namespace is a container for classes and is used to organize your code, kinda think of it like a project name. For example a Namespace we will be interacting with a lot is called `System`

`System` is the default Namespace you need to import to do quite a lot of basic functions in C#

Within `System` it contains the `class`, `Console`. 

If we wanted to print a statement out such as `Hello World!` we are going to want to use the `WriteLine` method from the `Console` `class`.

```cs
Console.WriteLine("Hello World");
```

### Importing Classes

To import Classes/Namespaces we are going to use the keyword `using`, for example to import the `namespace` `system` we are going to do.

```cs
using system;
```

### The Other Concepts are Roughly the Same

Like the title says the other concepts such as, `loops`, `switch` statements, `arrays` and stuff such as `break` and `continue` caries over from other languages. Just a bit of different syntax.

Well that is until you get onto more advanced concepts that are more C# specific. 