### Classes and Objects in PHP

This file contains all my knowledge about Classes and Objects in PHP

To define a class we use the `class` keyword then use curly brackets `{}` 

```php
class Name {

}
```

We can also add `properties` to our class

```php
class Name {
    public $variable, $otherVariable;
}
```
> Public allows visibility so we can interact with it

### Instancing 

Objects are specific instances of a class and to create them we do something called `instantiation`

In PHP we do this with the `new` keyword followed by the name and `()`

```php
$object = new className();
```

To interact with an objects properties we use the object operator `->` followed by the name of the property
```php
$object->property = 'value';
```
> Note that we don't use `$` when addressing properties

### Methods

We can also define class method, which are functions that can interact with our objects' properties

We can also use a special variable called `$this` and this refers to the current object so we can interact with properties specific to the object

```php
class Pet {
  public $first, $last;
  function getFullName() {
    return $this->first . " " . $this->last;
  }
}
```

Then we can use our Method we just created like this..

```php
$very_good_groundhog = new Pet();
$very_good_groundhog->first = "Punxsutawney";
$very_good_groundhog->last = "Phil";
echo $very_good_groundhog->getFullName(); # Prints "Punxsutawney Phil"
```

### Constructor Method

A Constructor Method is one of the several magic methods in PHP that do things when certain conditions are met

For example the Constructor method is ran whenever the class is initialized 

```php
class Pet {
  public $deserves_love;
  function __construct() {
    $this->deserves_love = TRUE;
  }
}
$my_dog = new Pet();
if ($my_dog->deserves_love){
  echo "I love you!";
}
// Prints: I love you!
```

### Inheritance
 
Inheritance is a concept that i'm familiar with from other languages such as C# and all it means is it *inherits* properties and methods from it's Parent class

We use the keyword `extends` to do this

```php
class ChildClass extends ParentClass {
    // code here
}
```

### Overloading Methods

If we want to change how methods behave in subclasses from it's parent we can `overload` the method

```php
class Pet {
    function type() {
        return "pet";
    }
}

// ...

class Dog extends Pet {
    function type() {
        return "dog"; // Whenever we call type() from within Dog it will use this Method
    }
    function otherMethod() {
        echo parent::type() // Will call Pet's type() method
    }
}
```
