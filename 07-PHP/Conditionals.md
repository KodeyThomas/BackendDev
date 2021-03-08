# Conditionals in PHP

Conditionals in PHP take the same form as in most other languages, by that I mean you have the standard (If, else and switch) conditionals + Boolean Logic and Comparison Operators

So, in this section there isn't too much to write about...

### Ternary Operators

In PHP like Golang, you can use ternary operators to simply your code's readability

```php
function ternaryCheckout($int) {
  return $int > 12 ? "regular lane" : "express lane";
}
```

The first string will be returned if it is `true` and the second if it is `false`

### User Input

We can get User Input in PHP from the built in function `readline()` which takes a string as input and prompts the user to enter text which returns as a string

```php
echo "Hi, I'm Aisle Nevertell. What's your name?\n";
$name = readline(">> ");
echo "\nNice to meet you, $name";
````

