# Variables within C#

In C# you declare and use variables a bit differently to any other language i've used before.

- [Declaring Variables](#declaring-variables-in-c#)
- [Variable Data Types](#variable-data-types)
- [Constants](#constants)
- [Variable Type Casting](#variable-type-casting)

### Declaring Variables in C#

To declare a Variable in C# you follow a simple pattern.

```cs
type name = value;
```

The pattern is the same as [JavaScript](https://github.com/KodeyThomas/BackendDev/tree/master/01-JavaScript) and other similar languages.

However the available Data Types are different in C#

### Variable Data Types

The available Data Types for C# are a tad different to other languages I've used before and they are;

```cs
// Basic Data Types

- int // Used for Storing Numbers 
- string // Used for Storing ASCII Text (A 'String' of Characters together)
- bool // Boolean True or False
- float // For Storing Floating Points (Numbers with Decimal Places)

// Advanced Data Types
- long // For a incredibly big Integer
- double // Floating points bigger then 6 Decimal Places
- char // Stores a single Character
```

### Constants

Constants is a special identifier you can apply when declaring a variable that essentially allows the Variable to be Write Protected, So you can not override the Variables value.

This can be really useful if you want to make sure a Variable can't be changed so you (Accidentally) or your program doesn't override the Variables value.

```cs
const type name = value;
```
> Make sure to assign a value when declaring a Constant or C# will throw an error

### Variable Type Casting

So, You might ask. How do you change the variable type from one to another i.e `int` to `string`.

This problem arises more then you think it would. For example if you want to display the numbers `1` and `2` together to print out `12` but if you do;

```cs
int numberOne = 1;
int numberTwo = 2;

Console.Write(1+2);
```

It will output `3` and thats not what we are looking for.

There are **Two** methods to change a variables type. They are `Implicit Type Casting` and `Explicit Type Casting`

#### Implicit Type Casting

Implicit Type Casting can be done automatically without any work from a smaller Data Type to a larger one.

```cs
int numberOne = 1;
double numberTwo = numberOne;
```

In the above example we created a new `double` Variable with the data from our `int`

##### Explicit Type Casting

Explicit Type Casting is a process you have to manually do, by placing the type in front of the value.

```cs
double numberOne = 1;
int numberTwo = (int) numberOne;
```

In that example we took a larger Data Type and converted it into a smaller one.

It's also possible to Explicit Type cast by using Built In Methods.

```cs
Convert.ToString(variableName);
```
By using that method you can convert from any Data Type.
> To convert to an `int` you want to do `Convert.ToInt32` and for a `long` `Convert.ToInt64`