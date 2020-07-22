# React.JS Framework

Although it isn't on the roadmap, it makes logical sense to learn the basics of the `React.JS` framework and it's syntax `JSX`

### What is React.JS

React is a JavaScript library for building user interfaces. It lets you compose complex UIs from small and isolated pieces of code called “components”. It is a really handy tool to use and has many applications across Development

### Course Syllabus
This is a basic course in `React.JS` estimated to take ~7 hours to complete. The topics covered are the following;

> ✅ = Covered Topic

- ##### Introduction to React.JS
  - What `JSX` syntax is
    - `ReactDOM.render` and how to use it ✅
  - Advanced `JSX` ✅
- ##### React Components
  - Creating A React Component ✅
  - Using Components ✅
- ##### Components Interacting
  - Components Render Other Components ✅
  - `this.prop`
    - Using props to render a page differently ✅
    - calling Methods with event handlers ✅
  - `this.state` ✅


##### What is JSX

`JSX` is a syntax extension in the `React.JS` framework, it uses a `HTML` like tagging system and is incredibly simple to learn.

```js
const p1 = <p id="large">foo</p>
const p2 = <p id="small">bar</p>
```

As You can see it looks a lot like HTML, but works just like JS!

This makes making beautiful designs a lot easier for us.

##### Rendering in JSX

To render a piece of code to a display you need to import the modules then use `ReactDOM.render` as you can see it is nice and simple.
```js
import React from 'react';
import ReactDOM from 'react-dom';

ReactDOM.render(
  <h1>Render me!</h1>,
  document.getElementById('app')
);
```
As you can see the previous example renders that piece of `JSX` code into the `app` element.

`React.JS` also allows us to render variables which we have defined with `JSX` code, can example being this;

```js
const myList = (
  <ul>
    <li>bruh</li>
    <br></br>
    <li>bruh</li>
  </ul>
);

ReactDOM.render(
  myList, // Renders the variable myList
  document.getElementById('app') // Renders myList on the 'app' element
);
```

##### Differences In `JSX` compared to `HTML`
`JSX` syntax and `HTML` syntax are relatively the same apart from a few minor differences, which I shall cover the main ones in a minute.

In `HTML5` *some* elements have 'self closing tags' such as `<img>` and `<input>` **however** in `JSX` you need to make sure you always close the tags. The following is an example of valid `HTML` and valid `JSX` syntax.

```JS
// HTML5
Fine in HTML with a slash:
  <br />
Also fine, without the slash:
  <br>

// JSX
Fine in JSX:
  <br />
NOT FINE AT ALL in JSX:
  <br>
```

##### How to write `JavaScript` code within your `JSX` code block.
`JSX` syntax again is very powerful and simple for this task, you just need to add your JS code in `{}` (Curly Brackets) an example follows;

```js
// Standard JSX
ReactDOM.render(
  <h1>2 + 3</h1>, // Will Render Out 2 + 3
  document.getElementById('app')
);

// JS + JSX Code
ReactDOM.render(
  <h1>{2 + 3}</h1>, // Will Render Out 5 (2+3=5)
  document.getElementById('app')
);

```
> Please Note, You can not inject `IF` statements into JSX code

However an alternative way to display `IF` statements in `JSX` is write them in JavaScript and inclose the `JSX` tags within the `IF` statements, not outside.

An example would be,

```js
if (truthyCondition) {
  img = <img src={imageVariable1} />
} else {
  img = <img src={imageVariable2} />
}
```

##### Event Listeners in `JSX`
`JSX` elements just like `HTML` elements can have event listeners. In `React.JS` there is a whole wide range of event listeners and we can create incredibly dynamic applications with them. A whole range can be found [HERE](https://reactjs.org/docs/events.html#supported-events)

A Real world example of how this can be utilised is followed;

```js
const loginButton = (
	<img
		src="imageOfTheButtonToMakeItLookFancy.png"  
    onClick={loginFunction}/>
);
```

### What I Learnt about `React.JS`
`React.JS` is a really powerful framework and incredibly useful in tons of situations.

By Building on `HTML` and `JS` syntax it allows Developers who already can code in those languages to create powerful and 'Reactive' web based applications.

![ReactJS](../assets/react.png)
