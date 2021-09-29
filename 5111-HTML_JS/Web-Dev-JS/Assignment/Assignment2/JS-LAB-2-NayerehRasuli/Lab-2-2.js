//######## LAB 2-2 LOGIN ########
//1. LINK THIS JS FILE TO THE HTML FILE
//alert("hey 2.2");//COMMENT OUT ONCE CONNECTED TO YOUR HTML PAGE

//====VARIABLES===============
//2. CREATE NECESSARY VARIABLES

var validUsername = "monkey";
var validPassword = "banana";

//====LOGIC===================
//3. CREATE POPUP BOX FOR USERNAME
var inputUsername = prompt("Enter your username.");
//4. OUTPUT PROVIDED USERNAME TO JS CONSOLE
console.log("The provided username is " + inputUsername);
//5. CREATE POPUP BOX FOR PASSWORD
var inputPassword = prompt("Enter your password.");
//6. OUTPUT PROVIDED PASSWORD TO JS CONSOLE
console.log("The provided password is " + inputPassword);
//7. CHECK IF PROVIDED USERNAME AND PROVIDED PASSWORD MATCH THE STORED USERNAME/PASSWORD
if (inputUsername.toLowerCase() === validUsername && inputPassword.toLowerCase() === validPassword) {
//8. IF THEY MATCH, POPUP SUCCESS MESSAGE AND OUTPUT TO CONSOLE
  alert("Welcome back " + inputUsername);
  // in this case inputUsername and validUsername carry the same string value
  console.log("Login successful");
}
//9. IF THEY DON'T MATCH, POPUP INVALID MESSAGE & OUTPUT TO CONSOLE
else {
  alert("Invalid username/password");
  console.log("Login fail");
}