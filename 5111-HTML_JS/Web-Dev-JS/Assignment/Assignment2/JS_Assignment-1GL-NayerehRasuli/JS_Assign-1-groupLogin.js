// alert("I am connected.");

// popup box asking the team number
var teamNum = prompt("Which team do you belong to?", "Enter your team number here");
//console.log("The entered team number was" + " " + teamNum + ".");

// The teamNum decides which condition applies
var validTeamNum = "2";
// assigned 2 to the ValidTeamNum for easy access, instead of bringing the number to the if statement

if (teamNum !== validTeamNum){
  alert("Your access is denied!");
}
else {

  var firstName = prompt("Please log in using your name." , "Enter your first name only");
  // console.log("The entered name was" + " " + firstName + ".");
  // using switch-case control flow to find out the last name for a given first name
  switch(firstName.toLowerCase()){
    case "aaron":
      alert("Welcome Aaron Chan.");
      break;
    case "andrea":
      alert("Welcome Andrea De Vera.");
      break;
    case "divish":
      alert("Welcome Divish Ram.");
      break;
    case "stefan":
      alert("Welcome Stefan Whittaker-Lee.");
      break;
    default:
      alert("Access denied!");
      break;
  }
  
}