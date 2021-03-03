# FMT Package

The `fmt` Package (Short for Format), is an incredibly useful Package and contains quite a few functions that we will find useful

In this lesson on [Codecademy](https://codecademy.com) it taught me all about the different features the `fmt` Package provides

Contents
- [Print Method](#print-method)
- [Printf Method](#printf-method)
- [Sprint + Sprintln Methods](#sprint-+-sprintln-methods)

### Print Method

`fmt.Println()` allows us to print to the console and view data we are working with. This is useful if we want to display data to the user or if we want to alert them that a certain thing has happened

It Prints whatever data you throw at it, as long as the data is within the brackets `()`

It formats stuff stupidly well which is a far cry from Pythons `Print()`statement. For example;

```golang
fmt.Println("Println", "formats", "really well")
fmt.Println("Right?")
```

Which Prints:

```UTF-8
Println formats really well
Right?
```


This is just one of the optimizations that I can see the developers of Go intentionally thought about putting in. As that is one of my main pet peeves with Python

As in the name `Println()` whenever you use the function, It prints on a **New** line

So what if you don't want that formatting for whatever reason?


You'd use `Print()` which does the same thing... Just without the formatting

```golang
fmt.Print("The answer is", ": ")
fmt.Print("12")
```

That would print out:

```ÙTF-8
The answer is: 12
```

Or how about this;

```golang
fmt.Print("Print","is","different")
fmt.Print("See?")
``` 

That would output:

```ÙTF-8
PrintisdifferentSee?
``` 

So with `Print()` you don't get the default formatting you do with `Println()` 

### Printf Method

The `Printf()` Method allows us to concatenate strings which is really useful and can make your code look neater

```golang
selection1 := "soup"
selection2 := "salad"
fmt.Printf("Do I want %v or %v?", selection1, selection2)
```

> The %v is our placeholder and is known as a *verb*, The specific letter informs what fills the placeholder. For more information about verbs click [HERE](https://yourbasic.org/golang/fmt-printf-reference-cheat-sheet/)

### Sprint + Sprintln Methods

At this stage you just need to understand that *returning* a value and *printing* a value are two different things and this Method *returns* values given to it

`Sprint()` works the exact same as `Print()` 

`Sprintln()` works the exact same as `Println()` in the essence it includes spacings

The only difference is the `Sprint()` Methods are designed to *return* the values into a variable

For an example on how you would implement this in some Go code;

```golang
variableOne := "bruhMomento"
bruhMoment := fmt.Sprintln("Oh god hes even including variables in this such as",variableOne,"look at him go")
``` 

As you guessed the `Sprint()` methods also come with `Sprintf()` which again works the exact same but just *returns* the value

```golang
template := "I wish I had a %v."
pet := "puppy"
wish := fmt.Sprintf(template,pet)
``` 

### Getting User Input with Scan()

Another useful Method in the `fmt` Package is `Scan()` which allows us to collect User Input

It collects the input off the user up until the first space

An Example would look like this;

```golang
fmt.Println("How are you doing?")

var response string

fmt.Scan(&response)

fmt.Printf("My response was %v", response)
```
> The reason for the `&`is because `Scan()` expects and address, this will be covered in more detail later

### Summary

In Summary, the built-in `fmt` Package is incredibly useful and gives us a few tools to work with