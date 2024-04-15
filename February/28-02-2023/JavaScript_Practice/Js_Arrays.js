let fruits=["Apple","Banana","Orange","Mango"];
console.log("Initially...");
console.log(fruits);
console.log();

// push(): Add an element to the end of the array
fruits.push("Strawberry");
console.log("After push(Strawberry)");
console.log(fruits);
console.log();

// pop(): Remove the last element from the array
var lastFruit = fruits.pop();
console.log("Removed fruit:", lastFruit);
console.log("After pop()");
console.log(fruits);
console.log();

//unshift(): Add an element to the beginning of the array
fruits.unshift("Kiwi");
console.log("After unshift()->At beginning");
console.log(fruits);
console.log();

// shift(): Remove the first element from the array
var firstFruit = fruits.shift();
console.log("Removed first fruit:", firstFruit);
console.log("After shift()->removed at beginning");
console.log(fruits);
console.log();

// splice(): Remove elements from an array and/or add new elements
fruits.splice(2, 1); // Remove 1 element starting from index 2
console.log("After splice()->removing");
console.log(fruits);
console.log();

fruits.splice(1, 0, "Pineapple", "Peach"); // Insert "Pineapple" and "Peach" at index 1
console.log("After splice()->adding");
console.log(fruits);
console.log();

//slice(): Extract a section of the array
var fruitssec = fruits.slice(1, 3); // Extract elements from index 1 to index 2 (not including 3)
console.log("Extracting a part of fruits");
console.log(fruitssec);
console.log();

//concat(): Concatenate arrays
var moreFruits = ["Cherry", "Watermelon"];
var allFruits = fruits.concat(moreFruits);
console.log("After adding new array->concat()");
console.log("New Array: "+allFruits);
console.log("Old Array: "+fruits);
console.log();

//indexOf(): Find the index of an element in the array
var index = fruits.indexOf("Peach");
console.log("Getting indexOf() for Orange")
console.log(index);
console.log();

//includes(): Check if an element exists in the array
var includesBanana = fruits.includes("Banana");
console.log("Array includes banana?: "+includesBanana);
console.log();

console.log("Iterating over each element in array:");
// forEach(): Iterate over each element in the array
fruits.forEach(function(fruit) {
    console.log("Fruit:", fruit);
  });
console.log();

console.log("map()->")
//map(): Create a new array by applying a function to each element
var fruitLengths = fruits.map(function(fruit) {
    return fruit.length;
  });
console.log(fruitLengths);
console.log();

//filter(): Create a new array with elements that pass a test
var shortFruits = fruits.filter(function(fruit) {
  return fruit.length < 6;
});
console.log("Filtering fruits based on condition");
console.log(shortFruits);
console.log();

//find(): Find the first element that passes a test
var longFruit = fruits.find(function(fruit) {
  return fruit.length > 6;
});
console.log("Finding fruit based on condition and returns the first fruit that matches condition");
console.log(shortFruits);
console.log();

//reduce(): Reduce the array to a single value
var totalLength = fruits.reduce(function(total, fruit) {
    return total + fruit.length;
  }, 0);
console.log("After Reducing the array to total length of strings..."+totalLength);
console.log();