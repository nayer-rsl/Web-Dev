//######## LAB 2-3 EMAIL SIGNUP ########
//alert("hey 2.3");//COMMENT OUT ONCE CONNECTED TO YOUR HTML PAGE
//==== VARIABLES =========



//==== LOGIC =============
var consent = confirm("Do you like to join our mailing list?");
//console.log(consent);
// console just for my own practice, to see what happens when I click s.th

//if conset is true it goes through the first loop, if false it goes to else
if ( consent ) {
  var email = prompt("Please enter your email address." , "me@example.com");
  console.log(email);
  //validating against null, empty, and default
  if ( email === null || email === "" || email === "me@example.com" ) 
  {
    alert("Thank you, but your email was not valid.");
  }
  else {
    alert("Thank you, our next newsletter will be sent to " + email );
  }

}

else {
  alert("Thank you, we will not bother you again.");
}