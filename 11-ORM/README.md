# ORM (Object Relational Mapping)

An ORM is a library that 'translates' data stored in relational databases into objects that can be used to interact with higher-level programming languages.

ORMs provide a level of abstraction that allows us developers to write in for example JavaScript and communicate with our database and have it function in a Object-Oriented Paradigm

For example we could have a database that looks like this;

```
ID Name Post_Code Phone_Number
1  Ben  SW1 1SA   +44771287348
2  Bob  SW1 1WQ   +44771287349
```

but then our ORM can abstract that data into objects for us...

```
{
    name: "Ben",
    post_code: "SW1 1SA",
    phone_number: "+44771287348"
},
{
    name: "Bob",
    post_code: "SW1 1WQ",
    phone_number: "+44771287349"
}
```

As you can see this can be really handy and can theoretically allow us to switch from any Relational Database without having to change our queries

ORMs are really handy for basic CRUD operations but can take longer for more complex operations and do suffer from the N+1 Issue in some cases for one->many relationships, however overall they can massively reduce development time as the data is translated into objects for your specific language which allows you to easily use that data you've just received back.
