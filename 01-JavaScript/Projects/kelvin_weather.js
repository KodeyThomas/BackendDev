var kelvin = 293; // Created a variable called Kelvin with the initalised value of 293

var celsius = kelvin - 273; // Created a variabled called celisius which is 273 degress less then kelvin

var fahrenheit = celsius * (9/5) + 32 // Converts fahrenheit to celsius

fahrenheit = Math.floor(fahrenheit); // Rounds down

console.log(`The temperature is ${fahrenheit} degrees Fahrenheit.`);