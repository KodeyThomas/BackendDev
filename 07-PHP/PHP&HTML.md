# PHP and HTML

Presenting and interacting with HTML is one of the primary uses of PHP. Our server takes each PHP file (in our examples, this is index.php), and translates them into HTML to present to the client in their web browser.

This process allows for developers to create customized experiences for individual users.

PHP also provides the capability to handle input from users through HTML forms in a straightforward manner. Before we cover working with forms, take a minute to review how PHP code can be embedded into HTML

This use is super common which is why PHP has a shorthand notation for working with HTML

```html
<a>random html text</a>
<?="<a>Now This is PHP</a>";?>
<a>again html</a>
```

### Request Superglobals

Since PHP is designed with Web Development in mind, it has functionality to ease processing of HTMl Requests.

These superglobals can be accessed within any scope in a script

They are as followed; 

- `$GLOBALS`
- `$_SERVER`
- `$_GET` 
- `$_POST` 
- `$_FILES`
- `$_COOKIE`
- `$_SESSION`
- `$_REQUEST`
- `$_ENV`

### Using `action`

`action` is a tool i've used in JavaScript before and essentially what it does is whenever you get a user input (Clicking on a button) then do something

In PHP we can handle a form being submitted using `action``

```php
<form method="get" action="anotherPHPScript.php">
```

Again by using the Superglobals we can access that data and handle it