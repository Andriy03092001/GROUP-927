//var lf = document.forms[0]; //Отримали першу форму в документів


//var lf = document.forms.loginForm;

//var userEmail = lf.elements.userEmail;
// var userPassword = lf.elements.userPassword;
// console.log(userEmail.value, userPassword.value);



// var email = document.forms['loginForm']['userEmail'].value;
// console.log(email);


// var age = lf.elements.age;
// console.log(age[0].value);

document.getElementById("myForm").addEventListener("submit", function (event) {
    event.preventDefault();
    submitLogin();
});

function submitLogin() {
    var email = document.forms['loginForm']['userEmail'];
    var password = document.forms['loginForm']['userPassword'];
    if (email.value == "") {
        alert("Please, enter your email!")
    }
    else if (password.value == "") {
        alert("Please, enter your password!")
    }
    else {
        if (email.value == "cuanid236316@gmail.com" && password.value == "1234") {
            alert("Hello Andrii")
        }
        else {
            alert("Error: You entered invalid data!")
        }
    }
}