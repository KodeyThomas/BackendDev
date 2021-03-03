# An Introduction to Go

Contents

- [Compiling](#compiling)
- [Running Our Code](#running-our-code)
- [Packages](#packages)
- [Importing Packages](#importing-packages)
- [Functions](#functions)
- [Hello World](#hello-world)
- [Summary](#summary)

Helpful Tips in Go

- [Importing Multiple Packages](#importing-multiple-packages)
- [Comments](#comments)




### Compiling

When you write Go code, we're writing it to be readable for developers. However it's not readable by computers. 

Go comes with a compiler which compiles our code to be able to be executed and turns it into a binary file similar to C.

To do this we go to terminal and type in

```bash
go build nameOfFile.go
```

After this compiles, we will be given a new file called `nameOfFile` which is an executable binary file containing our translated Go code.

### Running Our Code

Go also gives us the ability to automatically run our code after compiling with the command.

```bash
go run nameOfFile.go
```

### Packages

So now we are starting to take a deeper look into a Go programs structure.

Just like Python, Go's compiler reads code from Top to Bottom. 

However with it's similarities to C every program in Go needs a `main`function.

We also need to include the line `package main` as every Go program needs a `package declaration`to start off every file.

### Importing Packages

Cool so now we need to import some basic packages for use to be able to do anything within Go. So lets import the `fmt` package for us to use.
> Libraries are referred to as Packages within GoLang

We can do this with the keyword `import` and then the name of the package we want to import. 
> When importing Packages make sure to enclose them in double quotes `"`or else you'll get an error

Lets `import` the `fmt` Package to be able to use one of it's functions `Println` to be able to output text to the console


So far our code should look like this;

```golang
// main.go
package main

import "fmt"
```

### Functions

Functions are things we can call upon to run a specific piece of code when we want too.

Just like in Python, Functions can only be called after they have been declared. In layman's terms, the Function needs to be higher up in the code then where you call it.


So lets create our first basic function within Go

To declare the Function we are going to use the keyword `func` followed by the name of the Function and two brackets `()`, then two curly brackets `{}

```golang
func nameOfFunction() {
    // Write Code Here
}
```

###  Hello World

Lets put this all together now,

```golang
// main.go

package main

import "fmt"

func main() {
    fmt.Println("Hello World!")
}
```
> Go uses Dot Syntax to refer to Methods / Functions

Then using `go run main.go` we get the output;

```bash
$ go run main.go
Hello World!
> 
```

Boom! We've written our first program in Go

### Helpful Tips in Go

The following is a few helpful tips for Programming in Go

### Importing Multiple Packages

If we want to import multiple Packages in go we can use a tiny bit of a different syntax to achieve this.

```golang
import (
    "package1"
    "package2"
)
```

The great thing is this also allows us to create allias' so you don't have to type out the full Package name every time

```golang
import (
    package1Allias "package1"
    package2Allias "package2"
)
```

This means we can refer to `package1`as `package1Allias`

```golang
package1Allias.someFunction()
```

We could change `package1Allias`to anything such as a shorter way to remember the Package name such as `p1``

```golang
p1.someFunction()
```

### Comments

Comments in Go are similar to many other languages by using the keyword `//` this comments off the entire line after that keyword and it will not be read by the compiler

```golang
// Hello!
package main
// import "fmt" (This line won't be read)
```

### Summary

Thats a basic introduction to the foundation of Go and it's little quirks compared to other languages