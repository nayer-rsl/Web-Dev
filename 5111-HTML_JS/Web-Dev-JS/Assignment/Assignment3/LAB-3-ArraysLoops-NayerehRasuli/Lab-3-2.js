//LAB 3 - ARRAYS & LOOPS - PART 2
//alert("Part 2");//COMMENT THIS OUT ONCE CONNECTED

//PM TEAM MEMBER ARRAY
var ourTeam = [ "John" , "Dan" , "Con" , "Zack" , "Ron" ]

//OUTPUT TEAM ARRAY TO JS CONSOLE
console.log(ourTeam);

//REMOVE LAST MEMBER
ourTeam.pop();
console.log(ourTeam);

//ADD SEAN TO FRONT OF ARRAY
ourTeam.unshift("Sean");
console.log(ourTeam);

//REARRANGE THE ARRAY ALPHABETICALLY
console.log(ourTeam.sort());

//OUTPUT REQUIRED MESSAGE TO JS CONSOLE

console.log("WE have " + ourTeam.length + " people in our group");
//LOOP THROUGH ARRAY TO OUTPUT TEAM MEMBERS/NUMBERS TO JS CONSOLE
for ( var i = 0; i < ourTeam.length ; ++i ){
  console.log( ourTeam[i] + " is #" + (i+1) );
}