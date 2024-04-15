//if...ifelse
let x = 10;
if (x > 5) {
  console.log("x is greater than 5");
} else {
  console.log("x is not greater than 5");
}

// elseif
let time = 20;
if (time < 10) {
  console.log("Good morning!");
} else if (time < 20) {
  console.log("Good day!");
} else {
  console.log("Good evening!");
}

//switch
console.log("switch");
let fruit = "Apple";
switch (fruit) {
  case "Banana":
    console.log("Banana is yellow.");
    break;
  case "Apple":
    console.log("Apple is red.");
    break;
  default:
    console.log("I don't know the color of this fruit.");
}

console.log("for");
//for loop
for (let i = 0; i < 5; i++) {
    console.log("The number is " + i);
  }

//while loop
console.log("while");
let i = 0;
while (i < 5) {
    console.log("The number is " + i);
    i++;
  }

//do-while
console.log("do-while");
let i1 = 0;
do {
  console.log("The number is " + i1);
  i++;
} while (i < 5);

//for-in 
console.log("Parsing Dictionary...");
const person = {name: 'John', age: 30, city: 'New York'};
for (let key in person) {
  console.log(key + ": " + person[key]);
}

//for-of
console.log("Parsing Array");
const colors = ['red', 'green', 'blue'];
for (let color of colors) {
  console.log(color);
}
