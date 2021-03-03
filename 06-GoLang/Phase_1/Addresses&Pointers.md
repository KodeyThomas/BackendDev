# Addresses & Pointers

Addresses are the physical location where data inside variables is stored. It's the space that the computer allocates and each one has a specific unique numerical value

Every time we use a variable, we're retrieving that value stored in that address

To find a variables address we use the `&` operator followed by the variable name

```golang
fmt.Println(&variableOne) // Prints 0x50293810
```
> Whenever you see the prefix `0x` it means that number is formatted in hexadecimal 

### Pointers

Pointers are variables that explicitly store addresses and you define them like;

```golang
var variableName *int
```
> The `*` specifies that this variable will be storing an address 

Then we can assign it's value like this;

```golang
var variableName *int

variableTwo := "bruh"

variableName = &variableTwo
```

If you wanted to you could then print out the address. However the address for `variableTwo` is saved in `variableName`


### Dereferencing 

We know that addresses are where values are stored and pointers allow us to keep track of addresses. But what if we want the address to store a different value? 

Well, we can actually use our pointer to access the address and change its value! This action is called *dereferencing*

We need to use the `*` operator again on a pointer then give it it's new value

```golang
bruh:= "bruh"
bruhPointer := &bruh

*bruhPointer = "bruhMoment"

fmt.Println(bruh) // Prints bruhMoment
```

### Changing Values in Different Scopes

As you could probably guess, we can use dereferencing on our pointers to edit a variable outside of it's scope

```golang
func addHundred (numPtr *int) {
  *numPtr += 100
}
 
func main() {
  x := 1
  addHundred(&x)
  fmt.Println(x) // Prints 101
}
```

Since one of our functions expects a pointer it all runs smoothly!