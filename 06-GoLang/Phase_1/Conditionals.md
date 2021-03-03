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

