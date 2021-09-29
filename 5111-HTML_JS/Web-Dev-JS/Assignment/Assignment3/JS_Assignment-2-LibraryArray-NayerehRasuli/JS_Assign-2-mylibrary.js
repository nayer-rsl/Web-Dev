//alert("I am connected");
//declaring and initializing the variables

var firstBook= "Emma";
var secondBook= "Decameron";
var thirdBook= "Candide";
var fourthBook= "Dubliners";
var fifthBook= "Lolita";
var sixthBook= "Macbeth";
var seventhBook= "Hamlet";
var eighthBook= "Oresteia";
var ninthBook= "Clarissa";
var tenthBook= "Beloved";

//creating an Array
var topTen=[firstBook, secondBook, thirdBook, fourthBook, fifthBook, sixthBook, seventhBook, eighthBook, ninthBook, tenthBook];

//next console is for my own verification
//console.log(topBooks);

//input from 1 to 10 is valid
var isValid=false;
while ( !isValid ){
  //asking for the user's top pick
	var topPick = prompt("Which top 10 book would you like?" , "Pick a number: 1-10");
  
  //converting the user input to int
  var topIndex= parseInt(topPick);
  console.log(topIndex);

  //validating the user input
  if ( topIndex>1 && topIndex<10 )
    isValid=true;
  
}

//pop-up tell the user the position and the name of the book
alert("Number "+ topPick + " on the list is " + topTen[topIndex-1]);

//message to console, books and numbers
for ( var i = 0; i < topTen.length ; ++i ){
  console.log( "Book " + (i+1) + ": " + topTen[i] );
}