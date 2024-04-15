var str="Nikhita";
console.log("Taken string :"+str);

// charAt() method returns the character at the given index.
console.log("Character at index2 : "+str.charAt(2));
console.log();

//concat() concatinating two strings
var str1="Palla";
var str2=str.concat(str1);
console.log("Concat:"+str2);
console.log();

//indexof() finding the indexof() for the string
var s1="All is well All is well";  
var n=s1.indexOf("is"); 
console.log(s1);
console.log("IndexOf(is):"+n);
console.log();

//lastIndexOf() finding the last index of the specified string
var n=s1.lastIndexOf("is"); 
console.log(s1);
console.log("lastIndexOf(is):"+n);
console.log();

//toLowerCase() to convert into lowercase
var lower=s1.toLowerCase();
console.log(s1);
console.log("converting to lower case..."+s1);
console.log();

//toUpperCase() to convert into uppercase
var upper=s1.toUpperCase();
console.log(s1);
console.log("converting to upper case..."+s1);
console.log();

var slicing=s1.slice(2,7);
console.log(s1);
console.log("slicing string from index 2 to index 7(exclusive)"+slicing);
console.log();

s="    all";
console.log(s);
var triming=s.trim();
console.log("After trimming above string : "+triming);
