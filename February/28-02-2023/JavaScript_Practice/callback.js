// Define a function that takes a callback function as an argument
function greet(name, callback) {
    console.log("Hello, " + name + "!");
    // Call the callback function
    callback();
}

// Define a callback function
function sayGoodbye() {
    console.log("Goodbye!");
}

// Call the greet function and pass the sayGoodbye function as a callback
greet("Alice", sayGoodbye);
