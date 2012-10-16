function getNextSiblingByTagName(obj, tagName) {
    var sibling = obj;
    do sibling = sibling.nextSibling;
    while (sibling && sibling.tagName != tagName);
    return sibling;
}

var Loger = function () {
	this.init();
};

Loger.prototype.ValidatePassword = function(obj){
	var password = obj.value;
	var size = password.length;
	if ( size < 6){
		this.ShowErrorMessage(obj, "Password should be greater 6 symbols!");
	}
	else {
	    var sibling = getNextSiblingByTagName(obj, "DIV");
		sibling.hidden = true;
	}
};

Loger.prototype.ValidateConfirmPassword = function(obj){
    var password = document.getElementById("tbxPassword").value;	
	var confirmPassword = obj.value;
	var size = confirmPassword.length;	
	if ( size != password.length || 
		password.value == confirmPassword){
		this.ShowErrorMessage(obj, "Passwords is different!");
	}	
	else {
	    var sibling = getNextSiblingByTagName(obj, "DIV");
		sibling.hidden = true;
	}
};

Loger.prototype.Register = function (obj) {
    var login = document.getElementById("tbxLogin").value;
    var password = document.getElementById("tbxPassword").value;
    var confirm = document.getElementById("tbxConfirm").value;
    if (login != "Login" && password != "Login" && confirm == password) {
        var sibling = getNextSiblingByTagName(obj, "DIV");
        sibling.hidden = true;
        alert("Registration is successful!");
    }
    else {
        this.ShowErrorMessage(obj, "Test your login and password, please!");
    }   
	
};

Loger.prototype.ShowErrorMessage = function(obj, text){		
    var sibling = getNextSiblingByTagName(obj, "DIV");
	sibling.innerHTML = "<p>" + text + "</p>";	
	sibling.hidden = false;
};

Loger.prototype.init = function(){
	var self = this;
	var submit = document.getElementById("btnRegister");
    submit.onclick = function() {
        self.Register(submit);
        return false;
    };
};

var LoginFormEditor = function(){
	this.init();
};

LoginFormEditor.prototype.ChangeClassOn = function(obj, className){
	obj.removeAttribute("class");
	obj.setAttribute("class", className);
};

LoginFormEditor.prototype.ChangeText = function(obj, text){
	obj.value = text;
};

LoginFormEditor.prototype.MakeRound = function(){

};

LoginFormEditor.prototype.ExceedSize = function(){

};

LoginFormEditor.prototype.init = function(){
	var self = this;
	var loger = new Loger();
	var inputs = document.getElementsByTagName("input");
	var size = inputs.length;
	for(var i = 0; i < size; i++){
		inputs[i].hasfocus = false;
		self.ChangeClassOn(inputs[i], "standartBorder");
	    inputs[i].onmouseover = function() {
	        self.ChangeClassOn(this, "yellowBorder");
	        return false;
	    };
	    inputs[i].onmouseout = function() {
	        if (this.hasfocus == false) {
	            self.ChangeClassOn(this, "standartBorder");
	        }
	        return false;
	    };
	    inputs[i].onfocus = function() {
	        this.hasfocus = true;
	        self.ChangeClassOn(this, "yellowBorder");
	        if (this.id != "btnRegister") {
	            self.ChangeText(this, "");
	        }
	        return false;
	    };
	    inputs[i].onblur = function() {
	        if (this.value == "") {
	            if (this.id == "tbxLogin" ||
	                this.id == "tbxPassword" ||
	                this.id == "tbxConfirm") {
	                self.ChangeText(this, "Login");
	            }
	        } else {
	            if (this.id == "tbxPassword") {
	                loger.ValidatePassword(this);
	            } else if (this.id == "tbxConfirm") {
	                loger.ValidateConfirmPassword(this);
	            }
	        }
	        self.ChangeClassOn(this, "standartBorder");
	        this.hasfocus = false;
	        return false;
	    };
	}
};