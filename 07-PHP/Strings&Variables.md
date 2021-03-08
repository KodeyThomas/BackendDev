# Strings and Variables

This markdown file contains what I've learnt about Strings and Variables in PHP

### Escape Sequences

In PHP and most other languages you use Quotation Marks to indicate the start and end of a string

How would you include those quotation marks in a string then... Well you use Escape Sequence which in PHP is a backslash followed by another character

```php
echo "Hello \"World"\!";
``` 

To symbolize you want to print something on a new line in PHP you use `\n` which is the new line escape character


### String Concatenation

It can be really useful to combine two string together and we can use the concatenation operator `.` to do this

```php
echo "one" . "two"; // Prints onetwo
```

### Declaring Variables in PHP

To declare Variables in PHP we use the `$` character then to assign it we use `=` just like most languages

You can also declare a variable but then not assign it

### Variable Passing in Strings

You can pass variables into strings by calling the variable and wrapping it in curly braces `{}`

```php
echo "Hello, ${name};
```

### Shorthand Operations

In PHP we can use Shorthand notation to do a few things such as concatenate a string into the same variable by using `.=` and add an allias to a variable by using `=&` 