//LAB 3 - ARRAYS & LOOPS - PART 3
//alert("Part 3");//COMMENT THIS OUT ONCE CONNECTED
//PART 3 - SHOPPING CART SHIPPING
//==== VARIABLES ========
var shoppingCart = [];
var threShold = 35;
var cartSum=0;
var newItem;
//==== LOGIC ========
//CHECK FOR ITEMS UNTIL THRESHOLD IS MET.
while ( cartSum < threShold){
	
	//GET ITEM COST FROM USER
	var newItem = prompt("Please enter the cost of the new item");
	
	//CONVERT USER INPUT TO A NUMBER
	var itemParsed = parseInt(newItem);

	//ADD ITEM COST TO RUNNING TOTAL VARIABLE
	cartSum += itemParsed;
		
	//PUSH ITEM COST TO CART ARRAY
	shoppingCart.push(itemParsed);
}	
	

//SEND POPUP MESSAGE TO USER
if (cartSum>threShold){
	alert("Your shipping for this order will be free!");

}
//SEND OUTPUT TO CONSOLE
var strPrices= "Item prices: ";
for ( var i = 0; i < shoppingCart.length ; ++i ){
	strPrices+=shoppingCart[i]+ "|";
}
//Next statement is for removing the last |
strPrices = strPrices.slice(0,strPrices.length-1);
console.log(strPrices);