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

- ##### Introduction
  - Data Types ✅
  - Built In Methods ✅
  - Variables ✅
- ##### Conditionals
  - if, else, if else and switch statements ✅
  - Ternary Syntax ✅
- ##### Functions
  - JS Function Syntax ✅
  - Passing Data to Functions through paramaters ✅
  - `return` keyword ✅
  - Arrow functions `=> {}` ✅
  - Concise body syntax (Reducing how much you actually have to write) ✅
- ##### Scope
  - Global Scope ✅
    - Global Variables ✅
  - Block Scope ✅
- ##### Arrays
  - What Arrays are and how to use them ✅
  - Nested Arrays ✅
  - Adding/Removing elements from an Array `.pop` `.push` ✅
- ##### Loops
  - `for` loops ✅
  - `while` loops ✅
  - Higher Order Functions ✅
- ##### Iterators
  - `.reduce` ✅
  - `.forEach`✅
  - `.filter` ✅
  - `.map` ✅
  - `.some` ✅
- ##### Objects
  - An Introduction to OOP ✅
  - JS ES6 Object Syntax ✅
  - Advanced Objects ✅
    - Getters
      - When to use getters ✅
    - Setters
      - When to use setters ✅
      - `typeof` and how to use it to validate input and avoid errors ✅
    - Read Only Properties ✅
- ##### Classes
  - What Classes are and how to use them ✅
    - Inheritance
      - Using the `extends` keyword specifiy what it's superclass is ✅
        - Using the `super` keyword to inherit properties of a superclass ✅
  - ##### Creating Classes
    - Using `new` to create a new instance of the class ✅
    - Creating methods ✅
    - Creating a static method ✅
- ##### Browser Compatibility + Transplantability
  - JS ES6 and ES5 Compatibility
    - [caniuse.com](https://caniuse.com) ✅
  - `npm` ✅
    - `babel-cli` and `babel-preset-env` ✅
  - Building our code ✅
- ##### Modules
  - How to export Modules ✅
  - How to import Modules
    - Import modules using `.require` ✅
    - Import modules in ES6 using `import` ✅
- ##### Promises
  - asynchronous JS with Promises syntax ✅
    - Consuming Promises ✅
      - Using `.then` ✅
      - Using `.catch` ✅
- ##### Async-Await
  - How to use asynchronous programming in JS
    - `async` Functions ✅
  - Deeper dive on Promises ✅
    - `Promise.all()` coupled with `await`
- ##### Requests
  - API calls
    - HTTP GET ✅
    - HTTP POST ✅
  - JSON
    - JS Object Notation ✅
    - `.json` resolving returned promises ✅
  - XMLHttpRequest ✅
  - Query strings in URL's ✅
  - `fetch()` and it's Syntax ✅
  - Combining `fetch` and `async` functions, including error handling ✅

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

Object Syntax in ES6 is also really handy as there are a plethora of features to make shorthand notation incredibly fast and efficient to write.

```js
// Shorthand Notation in ES6, for a factory function
function robotFactory(model, mobile){
  return {
    model,
    mobile,
    beep() {
      console.log('Beep Boop');
    }
  }
}
newObject = robotFactory('T-800', true);
console.log(newOject.model) // Inherits all the Properties of the factory object  

// Full Notation in ES6
function robotFactory(model, mobile){
  return {
    model: model,
    mobile: mobile,
    beep() {
      console.log('Beep Boop');
    }
  }
}
newObject = robotFactory('T-800', true);
console.log(newOject.model) // Inherits all the Properties of the factory object  
```
As you can tell, it isn't **that much** different, however the extra little features such as that in ES6 make it especially convenient over bigger functions and objects.

##### Asynchronous Functions
`Asynchronous Functions` are really handy to learn about and can be used in multiple situations and are incredibly handy to understand.

What are they?

This is the first time I have come across `Asynchronous Functions` and I wanted to make sure I understood them.

Essentially, `Asynchronous Functions` can allow us to **wait** until a promise is resolved. This can be very handy in scenarios where a `Promise` needs to be resolved to move on to the next task.

> Promises can either be in three states; Pending, Resolved or Rejected

Here is an example `Asynchronous Function` I wrote during the course;

```js
const {shopForBeans, soakTheBeans, cookTheBeans} = require('./library.js');

async function makeBeans() {
  var type = await shopForBeans();
  var isSoft = await soakTheBeans(type);
  var dinner = await cookTheBeans(isSoft);
  console.log(dinner);
}

makeBeans();

// As You Can See Here, The Are So Simple To Set Up and Follow Standard Promise Syntax.
```

Another example of `Asynchronous Functions` using the `Promise` syntax is the following example;

```js
let {cookBeans, steamBroccoli, cookRice, bakeChicken} = require('./library.js')

async function serveDinnerAgain() {
  let foodArray = await Promise.all([steamBroccoli(), cookRice(), bakeChicken(), cookBeans()]);
  console.log(`Dinner is served. We're having ${foodArray[0]}, ${foodArray[1]}, ${foodArray[2]}, and ${foodArray[3]}.`);
};

serveDinnerAgain();

// Resolving All The Promises Concurrently
```
The advantages of the previous example is you can resolve the `Promises` concurrently. Meaning all at once, this allows quicker execution of your function.

##### Requests and API's

Requests and API's are something I have briefly learnt about when I was creating my tweak [Kithara](https://github.com/KodeyThomas/Kithara) which uses [LastFM's API](https://last.fm) which was a new but exciting experience. I also created a `library` for easy use to send a `HTTP POST` request to an API.

Before starting this course, I already understood the two main `Request Types` which are `POST` and `GET`

Compared To Objective-C the `POST` requests are relatively the same with a few differences, which I shall do my best to cover.

Below is an example `HTTP POST` request written in JS

```JS
// Information to reach API
const apiKey = 'VALID_API_SECRET';
const url = 'https://api-to-call.url/method';

// AJAX functions
const sendPOSTrequest = () => {
  const xhr = new XMLHttpRequest();
  xhr.responseType = 'json';

  xhr.onreadystatechange = () => {
    if (xhr.readyState === XMLHttpRequest.DONE) {
      renderResponse(xhr.response);
    }
  };
  xhr.open('POST', url);

  xhr.setRequestHeader('Content-type', 'application/json');
  xhr.setRequestHeader('apikey', apiKey);

  xhr.send(data);
};

// As You Can See It Isn't To Complex.
```
However Here is a `HTTP POST` request written in `Objective-C` this is copied from my [apiCall](https://github.com/KodeyThomas/apiCall) library found on my [GitHub](https://github.com/KodeyThomas)

```objc
- (NSMutableDictionary *)POST_JSON:(NSString*)urlString :(NSString*)parameterString { // POST Request in JSON
  NSError *error;
  NSURL *url = [NSURL URLWithString:urlString];
  NSMutableURLRequest *request = [[NSMutableURLRequest alloc] init];
  [request setHTTPMethod:@"POST"];
  [request setURL:url];
  [request addValue:@"application/json" forHTTPHeaderField:@"Content-Type"];
  NSData *postData = [parameterString dataUsingEncoding:NSUTF8StringEncoding];
  [request setHTTPBody:postData];
  NSData *rawResponse = [NSURLConnection sendSynchronousRequest:request returningResponse:nil error:&error];
  NSMutableDictionary *response = [NSJSONSerialization JSONObjectWithData: rawResponse options: NSJSONReadingMutableContainers error: &error];
  return response;
}
```
However using the library I wrote this can be simplified down to this;

```objc
NSString *POSTurl = @"http://api.url"
NSString *params = @"yourAPIparamaters"
NSMutableDictionary *API_Response = [[apiCall sharedInstance] POST_JSON:POSTurl :params];
```
As you can see my library significantly reduces the size of the code and makes it a lot easier to send `HTTP POST` requests.


Below is an example of code I have written during the course, the following code is a simple `XMLHttpRequest` function which sends a `GET` request

```js
// Information to reach API
const url = 'https://api-to-call.url/method?';
const queryParams = 'rel_jjb=';
const additionalParams = '&topics=';

// AJAX function
const getSuggestions = () => {
  const wordQuery = inputField.value;
  const topicQuery = topicField.value;
  const endpoint = `${url}${queryParams}${wordQuery}${additionalParams}${topicQuery}`;

  const xhr = new XMLHttpRequest();
  xhr.responseType = 'json';

  xhr.onreadystatechange = () => {
    if (xhr.readyState === XMLHttpRequest.DONE) {
      renderResponse(xhr.response);
    }
  }

  xhr.open('GET', endpoint);
  xhr.send();
}
```
Additionally, I could also use a `fetch()` request to do the same thing as a `GET` request just in less code. That looks like this;

```js
// Information to reach API
const url = 'https://api-to-call.url';
const queryParams = '?sl=';

// AJAX function
const getSuggestions = () => {
  const endpoint = `${url}${queryParams}`;
  fetch(endpoint, {cache: 'no-cache'})
  .then(response => {
    if (response.ok) {
      return response.json(response);
    }
    throw new Error('Request failed!');
  }, networkError => {
    console.log(networkError.message);
  });

```

This method can also be applied to `POST` requests demonstrated here;

```js
fetch('https://api-to-call.com/endpoint', {
  method: 'POST',
  body: JSON.stringify({id: '200'})
})
.then(response => {
  if (response.ok) {
    return response.json();
  } throw new Error('Request failed!');
}, networkError => {
  console.log(networkError.message);
})
.then(jsonResponse => {
  return jsonResponse;
});
```

You can also use `Asynchronous Functions` Requests and reap all the traditional benefits `Asynchronous Programming` gives you.

> This is done with traditional `async` syntax.

As demonstrated in the code below;

```js
const getData = async () => {
  try {
    const response = await fetch('https://api-to-call.com/endpoint', {
      method: 'POST',
      body: JSON.stringify({id: 200})
    });
    if (response.ok) {
      const jsonResponse = await response.json();
      return jsonResponse;
    } throw new Error('Request failed!');
  } catch(error) {
    console.log(error);
  }
};
```

### What I have learnt about JavaScript

After learning the fundamentals of JS, I can certainly see why it is the most popular language for Professional Developers as it is relatively straightforward and you can use it in virtually any application, anything from a Webpage to a fully configured backend system.

JS ES6 has very easy syntax to learn and coming from `Objective-C` it has been a breeze to learn (Well the foundations anyway!)

![completed](../assets/JS.png)

### End Project

My End Project is to create a Calculator in JS completely from scratch and a completed version of the calculator can be found [HERE](https://github.com/KodeyThomas/BackendDev/tree/master/01-JavaScript)

This is a good project idea as it combines multiple concepts together to combine into a finished project !
