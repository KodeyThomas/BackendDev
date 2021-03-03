# Functions in Go

As we have previously seen we can clump a group of code together and call it when we need to run it. For example our `main` function. What about other functions??

Contents
- [Defining Functions](#defining-functions)
- [Calling Functions](#calling-functions)
- [Scope](#scope)
- [Returning Values from Functions](#returning-values-from-functions)
- [Using Function Parameters](#using-function-parameters)
- [Abstraction](#abstraction)
- [Multiple Return Values](#multiple-return-values)

### Defining Functions

To define a Function we're gonna use the exact same syntax as we have been doing with `main`

```golang
func functionName () {
    // Code to be executed
}
```

### Calling Functions

To call a Function it's also very simple to do, all you do is this;

```golang
functionName(params)
```

It's as simple as that


### Scope

Scope is something really important to remember, you can't access any data from another function unless you've explicitly allowed this

For example;

```golang
package main
 
import "fmt"
 
func performAddition() {
  x := 5
  y := 7
  fmt.Println("The sum of", x, "and", y, "is", x + y)
}
 
func main() {
  performAddition()
  fmt.Println("What if", x, "was different?")
}
```

This results in;

```bash
./main.go:12:26: undefined: x
```

This is because you're trying to access variables not available within your scope, it's as simple as that


### Returning Values from Functions

While variables are scoped to their functions we can pass information out of functions by returning it

We can do this funnily enough through the keyword `return` and the *type* to return

```golang
func functionName() type {
    var bruh int
    bruh = 1
    return bruh
}
``` 

Then we can store that value by assigning a variable to the function;

```golang
bruh = functionName()

// Or we can print the value

fmt.Println(functionName())
```

### Using Function Parameters

Functions can also pass information into them, this allows us to get around the problem of out of scope variables

```golang
func functionName(variableOne type, variableTwo type) type {
    // variableOne can be used within here, passed in data from outside the function
    // variableTwo can be also be used

    return variableOne // This is the value you want to output from the function
}
```

### Abstraction

Abstraction is the concept of needing to use the same pattern of code over and over again. So you write a function so vague that it does just that every single time. Just with different data

Such as this function here;

```golang
func specialComputation(x float64) float64 {
  return math.Log2(math.Sqrt(math.Tanh(x)))
}
```

It does the same mathematical function every time, just with different input data

### Multiple Return Values

Functions can also return multiple values, See the example below:

```golang
func GPA(midtermGrade float32, finalGrade float32) (string, float32) {
  averageGrade := (midtermGrade + finalGrade) / 2
  var gradeLetter string
  if averageGrade > 90 {
    gradeLetter = "A"
  } else if averageGrade > 80 {
    gradeLetter = "B"
  } else if averageGrade > 70 {
    gradeLetter = "C"
  } else if averageGrade > 60 {
    gradeLetter = "D"
  } else {
    gradeLetter = "F"
  }
 
  return gradeLetter, averageGrade 
}
```

As you can see it returns `gradeLetter` and `averageGrade` 

### Deferring Resolution

We can delay a function call till the end of the current scope by using `defer`

This simply tells Go to run a function but just hold off until i've finished this

This is extremely useful for logging and file writing

```golang
func bruh(){
    fmt.Println("bruh")
}

func bruh1(){
    defer bruh()
    fmt.Print("bruh1")
}

func main() {
    bruh1()
}