function register() {
    var email = document.getElementById("txtEmail").value;
    var name = document.getElementById("txtName").value;
    var password = document.getElementById("txtPassword").value;
    var confirmPassword = document.getElementById("txtConfirmPassword").value;

    document.getElementById("txtError").innerHTML = "";

    if (email == "" || name == "" || password == "" || confirmPassword == "") {
        document.getElementById("txtError").innerHTML = "Please, enter all data for register!"
    }
    else if (password != confirmPassword) {
        document.getElementById("txtError").innerHTML = "Please, enter the same passwords";
    }
    else if (!isEmail(email)) {
        document.getElementById("txtError").innerHTML = "Please, enter correct email";
    }
    else {
        alert(`You have successfully register\nYour data for login: \nLogin: ${email} \nPassword: ${password}`);
    }

}


function isEmail(email) {
    const re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}

var array = [
    { name: "Andrii", phone: "23121212" },
    { name: "Vika", phone: "1212312312" }
];//Vlad, Vika, Andrii

function addRow() {
    document.getElementById("tableRows").innerHTML += `
    <tr>
        <td>TEST</td>
        <td>TEST</td>
    </tr>
    `;

    console.log(array.length);
    array.push("Andrii");
    array.pop();
    array.splice(0, 1);

    var rows = document.getElementsByTagName("tr");
    console.log(rows);
}