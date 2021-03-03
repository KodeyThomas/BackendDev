# Conditionals in Go

`Conditionals` are stupidly simple but can seem kinda complex.

They are a concept in Software Development which essentially boil down to.

**Do `X` when `Y` is met**


### `if` Statements

All of these are stupidly self-explanatory, `if` a condition is met do something

Heres an example;

```golang
alarmRinging := true
if alarmRinging {
  fmt.Println("Turn off the alarm!!") 
}
```

Stupidly simple.

### `else` Statements

`else` statements are used after `if` statements. They do exactly what they say they do

`if` this condition is *not* met then do something *else* 

```golang
heistReady := false
	
if heistReady {
	fmt.Println("Let's go!")
} else {
    fmt.Println("Act normal. ")
}
```

### `else if` Statements

Again it explains it's self. `if` a condition is not met then `if` this condition is met do something

```golang
bruhMoment := false
bruhMoment2 := true

if bruhMoment {
    // Do stuff, but it's not true so nothing happens
} else if bruhMoment2 {
    // Do stuff
}
```


### Comparison Operators

So far we've only been checking boolean values but with *Comparisons* we cam compare two variables or two bits of data then do something

They are;

- `==` Equals
- `!=` Not Equal
- `<`  Less than
- `<=` Less than or equal to
- `>`  More than
- `>=` More than or equal to

You can use these in `if` statements too

```golang
if(variableOne > variableTwo) {
    // Do something
}
```

### Logical Operators

If you've studied Computer Science you're more then likely heard about `Logical Operators` before sometimes referred to as *Logic Gates*. They are the cornerstone piece of how your computer physically makes decisions

They combine physical logical decisions and in Go they are;

- `&&` And
- `||` Or
- `!`  Not

Again they can be used in `if` statements;

```golang
if(storeLights == "on" && doorsOpen) {
    // Do stuff
}
``` 

### Switch Statements

`switch` Statements are designed around the case that you need to use loads of `else if` Statements

It makes the code look messy and uses loads of Computing power especially in games where you're constantly checking these statements, for example an NPC walking around

`switch` Statements use an alternate syntax thats easier to read and write

It does this through something called the *case system*

In essence;

```UTF-8
if this case == true {
    // do stuff
}
if this case == true {
    // do stuff
}
if none of them are true {
    // do stuff
}
```
> Please note that is **NOT** Go code

The last *case* there is something called the `default` case. It executes if none of the other cases are true

So.. How do we write this in Go?

```golang
clothingChoice := "sweater"
 
switch clothingChoice {
case "shirt":
  fmt.Println("We have shirts in S and M only.")
case "polos":
  fmt.Println("We have polos in M, L, and XL.")
case "sweater":
  fmt.Println("We have sweaters in S, M, L, and XL.")
case "jackets":
  fmt.Println("We have jackets in all sizes.")
default:
  fmt.Println("Sorry, we don't carry that")
}
``` 

You'll notice each *case* is started by the keyword `case` and the *default* case by `default`


### Scoped Short Declaration Statement

We can also include Shorthand variable declaration before a conditional

To tell the compiler where the declaration ends we use a semi-colon `;`

```golang
// if Statements
x := 8
y := 9
if product := x * y; product > 60 {
  fmt.Println(product, "  is greater than 60")
}

// switch Statements
switch season := "summer" ; season {
case "summer"
  fmt.Println("Go out and enjoy the sun!")
}
``` 