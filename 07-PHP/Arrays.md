# Arrays in PHP

Arrays are really helpful for use to organize and store data within groups. Data in arrays can be accessed by calling there `index`

An index in an array is the position the data is stored at (Starting at 0)

For example if we are building a TODO list, we can create an array containing all the tasks we have to do for that day

```UTF-8
[1,2,3,4,5] Array's
 0,1,2,3,4  Index (Position In Array)
 ```

### Built in functions with Arrays

We can use `implode()` to convert an array to a string and print it out

```php
echo implode($glue, $array);
```

> The glue is what you want next to separate the elements in the array with

### Accessing an Element

We can access an element within in an array by using square brackets

```php
$my_array[index];
```

### Adding and Changing Elements

We can make adjustments to existing arrays and we don't have to make new ones. We can again use square brackets `[]` and assign them new values depending on the index

```php
$array = [1,2,3];
$array[0] = 9;
```

### Associative Arrays

Associative Arrays are collections of key => value pairs. The key in an associate array must be either a string or an integer. The values held can be any type.

We use the `=>` operator to associate a key with it's value

```php
$my_array = ["key" => "value", "key2" => "value2"];
```

> Keys can be `strings` or `integers`

### Accessing and Adding Elements

We again can access the values using square brackets, however using the square brackets we can interact with the `key` to access the value

```php
$my_array = ["key" => "value", "key2" => "value2"]
echo $my_array["key2"];
```

