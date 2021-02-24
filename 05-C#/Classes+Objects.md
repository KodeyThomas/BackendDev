# Classes and Objects in C#

A class is an object constructor and can kinda be talked about like a 'blueprint' for creating Objects.

- [Creating Classes](#creating-classes)
- [Creating Objects](#creating-objects)
- [Using Multiple Classes](#using-multiple-classes)

### Creating Classes

To create a class were gonna use the `class` keyword;

So lets create our first Class.

```cs
class ClassExample {
    int myNumber = 1;
}
```
> When a Variable is directly declared in a class, It's referred to as a field.

### Creating Objects

Now we have our first Class, lets create an Object in that Class.

To create our object we need to specify the `class` name, followed by the object name.

```cs
class ClassExample {
    int myNumber = 1;

    static void Main(string[] args)
    {
        ClassExample myObj = new ClassExample();
    }
}
```
So now we have created a object within our class, now lets interact with the field we created.

```cs
class ClassExample {
    int myNumber = 1;

    static void Main(string[] args)
    {
        ClassExample myObj = new ClassExample();

        Console.WriteLine(myObj.myNumber);
    }
}
```

We can access fields in our class through our object and they way we do this is through `dot syntax`. You simply enter the `object` name followed by a `.` and the field you want to access.

### Using Multiple Classes

This is really handy as you can have a class that holds all fields and methods, while the other class holds the `Main()` method (Code that automatically gets executed upon run)

```cs
class ClassExample {
    public int myNumber = 1;
}
```
> In this file `ClassExample.cs` notice how we added the keyword `public` this is called an **access modifier** and can modify the access other classes have to interact with it. By setting it to public it means other classes can interact with the Variable.

Then in our other class (Which Contains our `Main()` method)

```cs
class Example {
    static void Main(string[] args) {
        ClassExample objectExample = new ClassExample();
        Console.WriteLine(objectExample.myNumber);
    }
}
```

Now if we ran that program it would print out `1` which is exactly what it's meant to do.

Even though our variable is stored in a completely different class in a different file we can still interact with it.

Sorting Classes like this really helps to split up bigger projects and make them way more manageable to understand.