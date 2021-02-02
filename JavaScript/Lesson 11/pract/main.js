// document.cookie = "theme=Dark";
// document.cookie = "phone=0954166765";

// var value = prompt("Enter your name: ");
// var key = "user name";

// document.cookie = encodeURIComponent(key) + "=" + encodeURIComponent(value);

// console.log(document.cookie); //theme=dark; phone=0954166765;

var canavas = document.getElementById("canvas");
var context = canavas.getContext("2d");

canavas.width = window.innerWidth;
canavas.height = window.innerHeight;

// Point draw:
context.strokeStyle = "red";
context.lineWidth = 10;

context.rotate(5 * Math.PI / 180);

context.beginPath();
context.moveTo(50, 50);
context.lineTo(25, 120);
context.lineTo(80, 120);
context.closePath();


context.stroke();


// Text:
// context.font = "16px fantasy";
// context.fillText("IT Step GROUP: 927", 50, 50);



//circle:
// context.fillStyle = "red";
// context.arc(canvas.width / 2, canvas.height / 2, 100, 0, Math.PI * 2, false);
// context.fill();



//animation rectangle:
// var x = 50;
// var y = 50;

// setInterval(function () {

//     context.fillStyle = "white";
//     context.fillRect(0, 0, canvas.width, canvas.height);

//     context.fillStyle = "red";
//     context.fillRect(x++, y++, 200, 200);
// }, 24);
