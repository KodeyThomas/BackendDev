assignedcomponents# Next.JS Framework
So far I have learnt `JavaScript` and the basics of `React.JS`

The keen eyed among you will notice that with the exception of `Node.js` a `JavaScript` framework. All the skills I have learnt on this journey thus far are frontend skills.

### I Thought this was a 'Backend' route not a 'Frontend' route.
Yes, my end goal is still to become a Backend Developer. However advancing my skillset in this area will also give me an advantage when it comes to my backend skills. If i can understand and even code some parts of the frontend it will allow me to understand how to better implement my backend skills into the project.

### What is `Next.js`
`Next.js` is a powerful framework build around `React.js` which combines both features of backend development with frontend development allowing you to create a fully functional JAMstack app.

### Why is `Next.js` so useful
`Next.js` is designed by [Vercel](https://vercel.com/home) and easily allows us to implement our backend systems right in with the frontend.

Next.js also has `SSR` (Sever Side Rendering) which is incredibly important to us if we are making fast and dynamic JAMstack apps.

Next.js also has this really cool ability where to update your new code you can simply just save the file and it will automatically update in your web browser which is incredibly useful for live testing your code.

### Course Syllabus
I won't be following a course as the information out their for `Next.js` is very limited and their documentation isn't massively in-depth either. However it does cover the basic features of `Next.js` and what separates it from the competition.

The following Course Syllabus is stuff I have chosen to learn about `Next.js` as I think it gives me a good foundational knowledge to build upon.

> ✅ = Topic Covered

- ##### Introduction to `Next.js` ✅
- ##### Server-side Rendering ✅
- ##### Pages ✅
  - Routing ✅
  - JSX syntax ✅
- ##### `.env` and good security practices ✅
- ##### Building a RESTful API with `Next.js` ✅
  - Dynamic Routing ✅
  - Response Helpers ✅
    - Using Response Helpers to create a RESTful API ✅

##### Server-side Rendering
Server-side rendering allows us to load JAMstack applications so much faster as everything is rendered on the 'fast' server and sent to your pc all ready for you to go. So latency times are reduced and our application loads faster.

The additional benefit of this you don't get that *flicker* effect when loading a older website - for example where it loads the website top down.

A con with SSR rendering is the first byte time is slower as your server has to first render the webpage first.

Most modern JAMstack web application use SSR as the perks massively outweigh the cons.

##### Pages

Pages in `Next.js` are extensions of `React` components and automatically redirect you from the static page associated with the name.

For example,

`Pages/index.js` - /index

`Pages/login.js` - /login

and etc...

Pages in `Next.js` follow `JSX` syntax with a few additional features. Infomation about `JSX` syntax can be found in my previous [`README.md`](https://github.com/KodeyThomas/BackendDev/tree/master/02-ReactJS)

##### `.env`

`Next.js` gives us the ability to store sensitive variables such as API Keys in an environment folder. which if we are uploading to GitHub means people can steal our API Keys.

##### Building a RESTful API with `Next.js`

A Current project I am working on requires me to create a RESTful API with `Next.js`. As the project won't be open source I can't share a part of my completed code however I will show you a basic single function API

```js
export default (req, res) => {
	res.statusCode = 200
	res.json({ name: 'example' })
}
```

The REST API takes in the params which are stored in `req` you can specify exactly what element of the query you want by using dot syntax and assigning it to a variable.

```js
let bruh = res.bruhMoment
```

so bruh will store the assigned value of that parameter.

in a real life suituation that could look like.

```js
localhost:3000/api/test.js?bruhMoment=yes
```

This would store the variable bruh, with the value of 'yes'

### Summed Up

`Next.js` can help us loads in creating JAMstack applications which are easy to configure and use. It has also been a good experience learning how to use `Next.js` and something this `README.md` can't show you is the fun I have had learning how to create complex API's and interact with DB's with this cool framework.
