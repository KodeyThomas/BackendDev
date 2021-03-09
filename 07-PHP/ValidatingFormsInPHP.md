# Validating Forms in PHP

Websites and applications in production nearly always use front-end validations (HTML and JavaScript validations done on the client-side), but these validations are designed to provide a better user experience—NOT for security. A user could circumvent front-end validation by intentionally or accidentally turning off JavaScript in their browser. We also need to protect against man-in-the-middle attacks, where a malicious actor changes data after it has been submitted by the client.

The back-end should **never** trust the data it receives from the client. Either intentionally or not, bad data from the client has the potential to expose sensitive information, corrupt our data, or significantly slow down our server. In this lesson, we’ll be working with forms with no front-end validations in place; this will simulate the untrustworthy nature of client-side validation.

We’ll be using PHP to handle the logic to receive POST requests, validate the data, store the data in the back-end, and display meaningful feedback to the user.

### Form Handling

In order for the user’s input to be included in the `$_POST` array, we provide a name attribute within the HTML. After submitting the form, this name will be the key in the `$_POST` array and the user’s input will be the value assigned to that key.

```php 
<form method="post" action="">
Your Favorite Programming Language: <input type="text" name="language">
<input type="submit" value="Submit Language">
</form>
```

Above we have an HTML form with a `method` of `"post"`. We could provide an alternate URL for users to navigate to after submitting their form (eg. action="some_page.php"). Since we want users to have the opportunity to submit the form again if they have errors, we’ll leave the action as an empty string—this means that once it’s submitted, users will be served the same PHP file that originally served them the form. Our form contains an input assigned the name `"language"`. If a user entered “PHP” (as we would assume…) into the language input of the above form and then submitted the form, their URL would not change. However, within the PHP code, the `$_POST` array would contain a key => value pair of `"language" => "PHP"`

### Basic Data Sanitizing

In order to protect against innocent but dangerous user mistakes, malicious users, or man-in-the-middle attacks, we need to sanitize the data—transform it into a safe and standardized format. In this exercise, we’ll focus on making data safe to display on the user’s browser.

PHP provides several built-in functions to help with sanitization:

We can use the built-in PHP `trim()` function to remove any whitespace characters from the beginning or end of a string we receive as form input. Though not a security concern, this can help standardize the data prior to validation.

```php
$email = "     aisle.nevertell@yahoo.com   ";
echo trim($email); // Prints: aisle.nevertell@yahoo.com
```

### Basic Sanitization with filter_var()

We haven’t yet introduced the most powerful PHP function for sanitizing data: `filter_var()`. This function operates on a variable and passes it through a `“filter”` that produces the desired outcome.

As its first argument, `filter_var()` takes a variable. As its second, it takes an ID representing the type of filtering that should be performed. There are several filters for sanitizing common input types, including `FILTER_SANITIZE_EMAIL`. The function will return either the sanitized version of the input or `FALSE` if it was unable to perform the sanitization.

```php
$bad_email = '<a href="www.evil-spam.biz">@gmail.com';
echo filter_var($bad_email, FILTER_SANITIZE_EMAIL);
// Prints: ahref=www.evil-spam.biz@gmail.com  
```

The FILTER_SANITIZE_EMAIL filter trimmed whitespace throughout our input and removed dangerous characters thus preventing any HTML injection. Essentially, it filtered out any characters not allowed in emails. Once sanitized, we can safely display user inputs.

### Basic Validation with filter_var()

We can use the same filter_var() function to validate as well as sanitize! There are a number of provided validation filters, but they work a bit differently from the sanitization filters. If the variable is deemed valid, filter_var() will return it; otherwise, it will return FALSE:

```php
$bad_email = 'fake - at - prank dot com';
if (filter_var($bad_email, FILTER_VALIDATE_EMAIL)){
  echo "Valid email!";
} else {
  echo "Invalid email!";
} 
// Prints: Invalid email!
```

It’s worth noting that the provided `FILTER_VALIDATE_EMAIL` filter is stricter than the guidelines regulating acceptable email addresses. If a site needed to accept non-latin characters, for example, the built-in `FILTER_VALIDATE_EMAIL` filter wouldn’t be sufficient.

Using the provided validation filters is really convenient. You can check out the list of available validation filters in the PHP manual. For example, `FILTER_VALIDATE_URL` is useful for checking if a string corresponds to a possible URL.

### Using Options with filter_var()

The filter_var() function accepts an optional third argument that allows us to fine-tune the operation of a given filter. This argument, often called $options, takes the form of a nested associative array.

For example, the $options argument can help us validate that an integer is within a specified range when using the integer validation filter `FILTER_VALIDATE_INT`. To do this, we set `$options` to a nested array containing the `"min_range"`and `"max_range"` keys in a specific format, shown in the following example:

```php
function validateAdult ($age){
  $options = ["options" => ["min_range" => 18, "max_range" => 124]];  
  if (filter_var($age, FILTER_VALIDATE_INT, $options)) {
    echo("You are ${age} years old.");
  } else {
    echo("That is not a valid age.");
  }
}
 
validateAdult(18); // Prints: You are 18 years old.
validateAdult(124); // Prints: You are 124 years old.
validateAdult(8); // Prints: That is not a valid age.
validateAdult(200); // Prints: That is not a valid age.
```

In the code above, we wrote a function `validateAdult()` which takes in an $age integer argument. We then used the `filter_var()` function to validate the integer was between 18 and 124 (inclusive) by using the `FILTER_VALIDATE_INT` filter and an $options argument with the value [`"options" => ["min_range" => 18, "max_range" => 124]]`

