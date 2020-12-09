// document.getElementById("btnStyle").onclick = function() {


var myButton = document.getElementById("btnStyle");
myButton.addEventListener('click', function() {
    var header = document.getElementById("header1");
    
    //1:    
    //header.style.color = "blue";
    //header.style.fontSize = "50px";


    //2:
    //header.setAttribute("style", "color:pink; font-size:70px")


    //3:
    // header.setAttribute("class", "myHeader2")


    //header.classList.remove("myHeader");
})



