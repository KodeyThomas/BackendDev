# Variables and Data Types in Go

Contents

- [Literals](#literals)
- [Constants](#constants)
- [Basic Data Types](#basic-data-types)
- [Basic Numeric Data Types](#basic-numeric-data-types)
- [Variables](#variables)

### Literals

In Go, values can be a lot of things. These can be written into code as is then they are `literals` as they *literally* are what they say they are

We can perform maths with `literals` exactly the same as we can in Python.
> I'm starting to sense a trend here...

- `+` to add
- `-` to subtract
- `*` to multiply
- `/` to divide
- `%` to find the remainder (Also known as the modulus operator)

We can perform math simply by using two numbers (or variables with numbers as there values) and the mathematical sign to do what we want 

### Constants

There are also things called `Constants` which is a data type that can not be updated while the program is running.

To define one of these we use the keyword `const`

```golang
const bruhMoment = "bruh"
```
> These must be initialized with a value at the time of declaration

That right there created a variable that can not be updated while the program is running called `bruhMoment` with the assigned value of `bruh``

Simple right.

### Basic Data Types In Go

Whoooo kinda more advanced but not too advanced stuff now.

So heres a few number Data Types in Go

#### String

A String is a essential Data Type as it holds a *string* of characters such as this sentence. To define a String you use the `string` keyword

#### Integer

An Integer (int) is a whole number, simple as that. To define an Integer you use the keyword `int`
```golang
var bruh int
```

##### Floating Points

A Floating Point (float) is any decimal number. To define a float you use the keyword `float`
```golang
var bruh float
```

##### Complex Numbers

 This is something you probably won't use unless you're doing as the name says complex mathematical equations. A Complex Data Type holds the value of imaginary numbers and a good example of a use case for this is 2-d coordinates or calculations involving square roots. To Define a Complex data type you use the keyword `complex`

```golang
var bruh complex
```

### Basic Numeric Data Types

This one is kinda important so pay attention!!

Go has loads of Numeric Data Types, this is to allow for as little memory to be allocated for the variable. This can marginally speed up performance but won't necessarily make a noticeable difference unless it's a really big or intensive task.

However i'm just going to cover the basic ones you will need to use

> To read more about Numeric Data Types click [HERE](https://golang.org/ref/spec#Numeric_types)

As previously covered you'll use `int` and `float` but in addition to that you will use `bool` which is the keyword for the `boolean` Data Type

A `Boolean` is a `true` or `false` value

### Variables

We have a little background on what the different Data Types, We can now start to create some.

Variables can be declared either one of two ways. The first being longhand notation. 

#### Longhand Notation

```golang
var variableName type
```

As you see you use the `var` keyword followed by the name and then the Data Type
> This is mainly used when you need to explicitly state the variable type or don't have the data to assign the variable

#### Shorthand Notation

The other much quicker way is through Shorthand Notation which looks like this;

```golang
variableName := value
```
> Note that here you **must** assign the variable it's value at the time of declaration


#### Zero Values
All variables unless assigned a value have a default value of zero

### Summary

Thats a basic overview of Variables and Data Types within Go