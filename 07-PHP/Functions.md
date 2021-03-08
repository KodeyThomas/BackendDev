# Functions in PHP

To create Functions in PHP we can use the keyword `function` followed by the name `()` then followed by a code block with `{}`

```php
function functionName() {
    // Code here;
}
```

To invoke a function you call it just like any other language by using `functionName()`

To return a value from a function you use the `return` keyword and to return nothing you can return `NULL` 

### Default values in Functions

In PHP we can set default values on functions if nothing is passed into them for example

```php
function functionName($variable = "variableToBeDefault") {
    return $variable;
}
```

### Global Variables

To access a variable from outside it's scope we can use the `global` keyword

```php
function functionName($param) {
    global $param;
    return NULL;
}
```
