//######## LAB 2-1 FILE DELETE CONFIRMATION ########
//alert("hey 2.1");//COMMENT OUT ONCE CONNECTED TO YOUR HTML PAGE
//==== VARIABLES ========
var userChoice;
var messageOut = "Thank you, your file has ";
var yesMessage = "been successfully deleted.";
var noMessage = "not been altered.";
//var message ;
//==== LOGIC ========

//1. CREATE POPUP TO ASK FOR PERMISSION TO PROCEED WITH DELETION OF FILE
userChoice = confirm("Are you sure you want to delete?");
//console.log(userChoice);
// can activate the console.log by deleting double slashes

//2. IF USER CLICKS OKAY SET MESSAGE TO YES
if (userChoice) {
  var message = messageOut + yesMessage;
} 

//3. IF USER CLICKS ANYTHING BUT OKAY, SET MESSAGE TO NO
else {
  var message = messageOut + noMessage;
}

//4. SEND FINAL POPUP MESSAGE TO USER
alert(message);

