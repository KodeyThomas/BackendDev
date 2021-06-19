# N+1 Problem

The N+1 problem is unlike CAP Theorem a `problem` but as all problems go there are solutions...

You may ask however what on earth is the N+1 problem. Well the `N+1` problem occurs mainly when using ORMs or GraphQL and that is because of a problem when fetching data from one->many relationships we actually query the database `N+1` times where `N` being the amount of results we return.

Lets use this basic example.

A Car has MANY Wheels

We can write this as;

Car->Wheels

Lets say we need to return 100 Cars from our database. Rather then just querying the DB once for 100 Rows we need to call it for every `Car` to get its associated `Wheels`

So we end up with 100 Queries one for each `Car` plus our initial one to get 100 `Cars`

As you can see that is not efficient at all and can be avoided but just like everything else in Computer Science you probably won't notice it until you work with large amounts of data.

So it's possible to avoid this error by doing something called `Batch Fetching` which just means we will Join all the data in our query so we don't have to fetch the data every single time.