# Validating Forms in PHP

Most data, once submitted, is stored by a website or web application. It’s stored in a database on the server side. There are important reasons for us to make sure the information that will be stored in the database is accurate.

We want operations that depend on the data to work: Allowing a user to enter an incorrectly formatted email address, either on purpose or by accident, means that we won’t be able to contact that user later. Allowing a user to sign up for an account with a username that is already in use could cause numerous errors down the line. Making sure we collect all the data we need and checking that the data are formatted correctly can save a web application and its users a lot of trouble.

We want to keep our site secure: Unprotected data leaves entry points for malicious actors to hurt our application or our users. Allowing a user to submit a non-secure password means that their account will not be protected. Unprotected forms can also allow bits of code to be injected into our servers. This can potentially leave our users’ sensitive information exposed. The malicious actor could even gain control of our site or corrupt our existing data!

### Regular Expressions

Data submitted through forms is stored as strings. However computers have to be precisely trained to recognize patterns... and in comes Regex

> Pre warning, I hate Regex so this part can and WILL kill me...

### Client-side Validation: HTML

The first technique we can use to validate form data is to prevent problematic inputs from being submitted in the first place. This is called client-side validation. The client is the process interacting with the server on behalf of a user—in the case of websites, the web browser is the client. The logic for validating the form is included with the code that displays the form on the user’s device. No interaction with the back-end is required to perform client-side validations.

Since form validation is so common, modern HTML provides some of these validation features built-in. For example, we can use HTML to make parts of a form required and others optional. We can also use HTML to set minimum and maximum values for an input or minimum or maximum lengths for a text input. We can even necessitate that the input match a particular pattern, specified by a regular expression.

### Client-side Validation: JavaScript

Client-side validation has two main advantages. First, it’s a better experience for the user to be alerted to problematic data immediately rather than having to wait for that information to come back from the server and have to fill out the form again. Second, catching mistakes earlier in the process saves the application time and resources as well. But not all issues can be handled with the built-in HTML validations.

In order to truly customize validation or to perform more complex validations, we can incorporate JavaScript form validations. We can do this by either writing the JavaScript ourselves or by incorporating a JavaScript library. If we have unique requirements for usernames on our site, for example, we’ll have to provide these systems of validation ourselves.

If we’re creating a relatively simple website, it makes sense to code the form validation ourselves or use a simple vanilla JavaScript library—just-validate, for example. But most basic validation libraries will involve directly accessing or manipulating the DOM. This can get tricky when working with a framework that relies on a virtual DOM—like React or Vue. In those situations, it might be best to incorporate a library that works well with your specific framework. For example, the formik library is a lightweight library that simplifies validating forms in a React app.

### Backend Validation

No matter how complete the front-end validation of a website or application seems, validations must also be completed on the back-end or server-side. Front-end validations are easy to bypass—a malicious user can simply turn off JavaScript on their browser, for example. There’s also the potential for middleman attacks in which data is changed after the request is submitted by a user but before it arrives at the server. As a rule, the back-end should never trust the data it receives.

As the developer, once data is in the back-end, we have complete control over it, luckily. Back-end validation has several advantages:

It enables us to use validation code often on machines with more computing power.
It allows us to write validation code that a user can’t see—if malicious users can’t see exactly how we validate the data, it’s much more difficult for them to find ways around it.
We can validate the information against other data the front-end doesn’t have access to—for example, we can check our database to see if a given username is already in use.
There are two main ways to validate inputs on the server-side. The first takes place while the user is still inputting data into the form on the front-end. We can make asynchronous requests to the server with pieces of their data and send feedback directly to the user before they’ve submitted. This is slower than front-end validation and can be a design challenge from a user-experience perspective.

The second is once the form has been submitted. Back-end form validation is our application’s last defense against problematic data, and it’s essential to verify the validity and safety of data before adding it to a database. This is also an opportunity to “sanitize” the data: in order for our database to be useful, it’s important that all data within it is formatted consistently. This means that while we may want to be flexible about the formatting we require from a user, we likely want to transform inputs into a strict format before entering them in the database.