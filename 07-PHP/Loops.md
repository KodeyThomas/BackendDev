# Loops in PHP

Loops in PHP follow the same similar / standard structure as most other languages, by this I mean it has `while` loops and `for` loops, however PHP also has `do while` and `foreach` loops

### `while` loops

PHP like most other languages has a concept of a `while` loop, which continues to iterate as long as it's true

```php
$count = 1;
while ($count < 11)
{
  echo "The count is: " . $count . "\n";
  $count += 1;
}
```
> This above codes iterates ten times

### `do while` loops

A `do while` loop is very similar to a while loop. The main difference is that the code block will execute once without the conditional being checked. After the first iteration, it behaves the same as a while loop.

The syntax is slightly different, and the conditional goes at the end of the code block. Our counting to 10 example looks like:

```php
$count = 1;
do {
  echo "The count is: " . $count . "\n";
  $count += 1;
} while ($count < 11);
```
> Unlike other loops, do while needs a semicolon `;` at the end

### `for` loops

A `for` loop is commonly used to execute a code block a specific number of times

The `for` loop syntax includes 3 expressions:

- The first is evaluated only one time before the first iteration.
- The second is evaluated before each iteration. If it is TRUE, the code block is executed. Otherwise, the loop terminates.
- The third is evaluated after each iteration. Note that expressions 1 and 2 have semicolons after them.

```php
for ($count = 1; $count < 11; $count++)
{
  echo "The count is: " . $count . "\n";
}
```

### `foreach` loops

The `foreach` loop is used for iterating over an array. The code block is executed for every element in the array and the value of that element is available for use in the code block.

```php 
$counting_array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
foreach ($counting_array as $count) {
  echo "The count is: " . $count . "\n";
}
```

