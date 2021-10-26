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


formHandle.onsubmit = processForm;

function processForm(shipInfo){
	
	//ACCESS THE ELEMENTS THROUGH THE "FORM HANDLE"
	var nameValue = formHandle.f_Name;

	var idValue = formHandle.f_Id;

	var postalValue = formHandle.f_pc;

	var slctBox = formHandle.f_speed;
	
	var courier = slctBox.options[slctBox.selectedIndex].text;
	
	//validating inputs againt empty string and null
	if(nameValue.value === "" || nameValue.value === null){ 
		nameMsg = document.getElementById("in_Name");
		nameMsg.style.background = "red"; 
		nameValue.focus(); 
		return false;
	}else{//Store data to object
		shipInfo.name = nameValue.value;
	}
	if(idValue.value === "" || idValue.value === null){ 
	
		idMsg = document.getElementById("in_Id");
		idMsg.style.background = "red"; 
		idValue.focus(); 
		return false;
	}else{//Store data to object
		shipInfo.cid = idValue.value;
	}
	if(postalValue.value === "" || postalValue.value === null){ 
		
		pcMsg = document.getElementById("in_pc");
		pcMsg.style.background = "red"; 
		postalValue.focus(); 
		return false;
	}else{//Store data to object
		shipInfo.pc = postalValue.value;
	}
	if(slctBox.value === "0" ){ 
		
		sbMsg = document.getElementById("in_Speed");
		sbMsg.style.background = "red"; 
		slctBox.focus(); 
		return false;
	}else{//Store data to object
		shipInfo.speed = courier;
		shipInfo.cost = slctBox.value;
	}
	console.log(shipInfo);

	//FILL THE THANKS FORM WITH DATA FROM DATA STORED IN SHIPINFO OBJECT
	document.getElementById("thanksCustomer").innerHTML = shipInfo.name;

	document.getElementById("thanksPC").innerHTML = shipInfo.pc;

	document.getElementById("thanksCost").innerHTML = shipInfo.cost;

	document.getElementById("thanksSpeed").innerHTML = shipInfo.speed;

	//HIDE THE FIRST FORM AND SHOW THE SECOND FORM
	document.getElementById("shippingForm").style.display="none";
	document.getElementById("thanks_msg").style.display= "inline";
	//STOPING THE FORM FROM SUBMITTING
	return false;
}
}
