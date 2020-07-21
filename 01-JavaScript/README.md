Following the roadmap, the first language I need to learn is `JavaScript`

### What is JavaScript

JavaScript (JS) is a high-level programming language with applications from Front End development in Web Design all the way through to Node.JS for Backend Development

### Why am I learning JavaScript

JS is a incredibly versatile language and will help me no matter what branch of Development I choose to pursue due to that fact JS is an incredibly in-demand language for Developers and according to [StackOverflow](https://stackoverflow.com) is the most commonly used language by Professional Developers. Additionally with JS you can learn more advanced aspects of programming such as [OOP](https://en.wikipedia.org/wiki/Object-oriented_programming). JS also allows you to be able to use powerful frameworks such as [Electron](https://www.electronjs.org) and [React Native](https://reactnative.dev) with the later being what [Discord](https://discord.com) uses as it is incredibly versatile and works cross-platform.

### How am I going to learn JavaScript

I am going to be using several online tools with the main one going to be [CodeAcademy](https://www.codecademy.com/learn) due to the fact the free course material is incredibly good and I have previously used it.

### Course Syllabus

This JS Course will take roughly **30 Hours** to complete and will give you a fundamental understanding of the language

> ✅ = Covered Topic

- Introduction
  - Data Types ✅
  - Built In Methods ✅
  - Variables ✅
- Conditionals
  - if, else, if else and switch statements ✅
  - Ternary Syntax ✅
- Functions
  - JS Function Syntax ✅
  - Passing Data to Functions through paramaters ✅
  - `return` keyword ✅
  - Arrow functions `=> {}` ✅
  - Concise body syntax (Reducing how much you actually have to write) ✅
- Scope
  - Global Scope ✅
    - Global Variables ✅
  - Block Scope ✅
- Arrays
  - What Arrays are and how to use them ✅
  - Nested Arrays ✅
  - Adding/Removing elements from an Array `.pop` `.push` ✅
- Loops
  - `for` loops ✅
  - `while` loops ✅
  - Higher Order Functions ✅
- Iterators
  - `.reduce` ✅
  - `.forEach`✅
  - `.filter` ✅
  - `.map` ✅
  - `.some` ✅
- Objects
  - An Introduction to OOP ✅
  - JS ES6 Object Syntax ✅
  - Advanced Objects
- Classes
  - What Classes are and how to use them
  - Creating Classes
  - Importing Classes
- Browser Compatibility
  - JS ES6
  - JS ES5
- Modules
  - How to use JS Modules
- Promises
  - asynchronous JS with Promises syntax
- Async-Await
  - How to use asynchronous programming in JS
  - Deeper dive on Promises
- Requests
  - API calls
    - HTTP GET
    - HTTP POST
  - JSON
    - JS Object Notation
    - `.json` resolving returned promises
  - XMLHttpRequest
  - Query strings in URL's

### Examples Of Work

Here is some examples of work I have completed at different stages of the course, I tried to use `Concise Function Syntax` wherever possible.

##### Iterators
This is a finished solution from a lesson on [CodeAcademy](https://www.codecademy.com/learn) about Iterators specifically the `.map()` iterator.
```JS
const randomNumbers = [375, 200, 3.14, 7, 13, 852];

// Call .filter() on randomNumbers below
const smallNumbers = randomNumbers.filter(bruh => {
  if (bruh < 250) {
    return bruh;
  }
});

const favoriteWords = ['nostalgia', 'hyperbole', 'fervent', 'esoteric', 'serene'];


// Call .filter() on favoriteWords below

const longFavoriteWords = favoriteWords.filter(longboi => {
  if (longboi.length > 7) {
    return longboi;
  }
});
```

This is a piece of code I wrote during the course that will help me in my Calculator final project. Specifically it will be able to help be when I need to take the input (Stored in an Array) and reduce it into final answer.

```js
const newNumbers = [1, 3, 5, 7]; // Starting Array

const newSum = newNumbers.reduce((accumulator, currentValue) => {
  console.log(`The value of accumulator: ${accumulator}`);
  console.log(`The value of currentValue: ${currentValue}`);
  return accumulator + currentValue;
});

console.log(newSum); // Logs the output of the function newSum
```

##### Objects
This is a piece of code I wrote during the course about defining `Objects` and reading values from them (Including Nested Objects)

This was probably easier for me understanding this topic as at the time of completion I could already code in Objective-C which is as the name suggests an `Objected Oriented` language.

```js
let spaceship = {
  passengers: null,
  telescope: {
    yearBuilt: 2018,
    model: "91031-XLT",
    focalLength: 2032
  },
  crew: {
    captain: {
      name: 'Sandra',
      degree: 'Computer Engineering',
      encourageTeam() { console.log('We got this!') },
     'favorite foods': ['cookies', 'cakes', 'candy', 'spinach'] }
  },
  engine: {
    model: "Nimbus2000"
  },
  nanoelectronics: {
    computer: {
      terabytes: 100,
      monitors: "HD"
    },
    'back-up': {
      battery: "Lithium",
      terabytes: 50
    }
  }
};

var capFave = spaceship.crew.captain['favorite foods'][0]; // Reading Index 0 (First Item)

spaceship.passengers = [{name: 'Kodey'}]; // Assigning Properties in a nested Object
var firstPassenger = spaceship.passengers[0]; // Reading Values from a nested Object (Key Pair)
```

Here is another piece of code which reinforces my knowledge on `Objects`

```js
let spaceship = {
  'Fuel Type' : 'Turbo Fuel',
  homePlanet : 'Earth'
};


const greenEnergy = object => {
  object['Fuel Type'] = 'avocado oil';
};

const remotelyDisable = object => {
  object.disabled = true;
};

greenEnergy(spaceship);
remotelyDisable(spaceship);

console.log(spaceship);
```

Overall `Objects` were an easy premise to transfer over as I already had knowledge in `Objective-C` and that helped a lot while learning.

Additionally, The `Object` syntax is a bit different. However it still uses `. (dot)` syntax and `[] (bracket)` syntax albeit the bracket syntax is structured differently.

In `Objective-C` bracket syntax looks like this;

```objc
[PhoenixDRM getUUID];         
```
Compared to JS which it looks like;

```js
object[property];
```

As you can see it is only a minor difference, however the overall premise is still the same.

However the dot syntax is exactly the same.

```js
PhoenixDRM.getUUID; // Valid Objective-C Code

PhoenixDRM.getUUID; // Valid JS Code
```

### End Project

My End Project is to create a Calculator in JS completely from scratch and a completed version of the calculator can be found [HERE](https://github.com/KodeyThomas/BackendDev/tree/master/01-JavaScript)

This is a good project idea as it combines multiple concepts together to combine into a finished project !
