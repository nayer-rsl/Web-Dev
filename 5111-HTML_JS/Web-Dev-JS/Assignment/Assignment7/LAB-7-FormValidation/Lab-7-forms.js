/* LAB 8 - SHIPPING FORM */
//Order Shipping object (for extra EXTRA challenge, otherwise, ignore it)
var shipInfo = {
	cid: 0,
	name: "",
	pc: "",
	speed: "",
	cost: 0
};
window.onload = function(){

var formHandle = document.forms.form_ship;
console.log(formHandle);

formHandle.onsubmit = processForm;

function processForm(){
	
	//ACCESS THE ELEMENTS THROUGH THE "FORM HANDLE"
	var nameValue = formHandle.f_Name;
	console.log(nameValue);
	var idValue = formHandle.f_Id;
	console.log(idValue);
	var postalValue = formHandle.f_pc;
	console.log(postalValue);

	//validating inputs againt empty string and null
	if(nameValue.value === "" || nameValue.value === null){ 
		nameMsg = document.getElementById("in_Name");
		nameMsg.style.background = "red"; 
		nameValue.focus(); 
		return false;
	}
	if(idValue.value === "" || idValue.value === null){ 
	
		idMsg = document.getElementById("in_Id");
		idMsg.style.background = "red"; 
		idValue.focus(); 
		return false;
	}
	if(postalValue.value === "" || postalValue.value === null){ 
		
		pcMsg = document.getElementById("in_pc");
		pcMsg.style.background = "red"; 
		postalValue.focus(); 
		return false;
	}

	//FILL THE THANKS FORM WITH DATA FROM USER
	document.getElementById("thanksPC").innerHTML = idValue.value;

	document.getElementById("thanksCustomer").innerHTML = nameValue.value;
	//HIDE THE FIRST FORM AND SHOW THE SECOND FORM
	document.getElementById("shippingForm").style.display="none";
	document.getElementById("thanks_msg").style.display= "inline";
	console.log(document.getElementById("thanksCustomer").value);
	//STOPING THE FORM FROM SUBMITTING
	return false;
}
}
