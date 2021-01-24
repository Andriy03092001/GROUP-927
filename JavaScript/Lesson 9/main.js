// +38(095) 41-66-765
var myMask = [
    { "mask": "+38(###) ##-##-###" }
];

$("#txtPhone").inputmask(
    {
        mask: myMask,
        definitions: {
            '#': { validator: "[0-9]" },
            '9': { validator: "[a-z]" },
            '0': { validator: "[A-Z]" }
        }
    }
)

var phone = localStorage.getItem("myPhone");
if (phone != null) {
    $("#txtPhone").val(phone);
}

// localStorage.removeItem("myPhone");

$("#btnGet").click(function () {
    var value = $("#txtPhone").val();
    alert(value);

    localStorage.setItem("myPhone", value);


    // window.location.href = "test.html";
    // window.location.replace("test.html");
});

// $.get("https://jsonplaceholder.typicode.com/posts", function (data, status) {
//     console.log("Status: " + status);
//     console.log("Data: \n" + data);
// })