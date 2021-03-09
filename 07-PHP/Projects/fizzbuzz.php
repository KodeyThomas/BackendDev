<?php

$i = 1;

while ($i <= 100) {
  if (($i % 15) === 0) {
    echo "FizzBuzz\n";
    $i++;
  } elseif (($i % 5) === 0) {
    echo "Buzz\n";
    $i++;
  } elseif (($i % 3) === 0) {
    echo "Fizz\n";
    $i++;
  } else {
    echo "$i\n";
    $i++;
  }
}