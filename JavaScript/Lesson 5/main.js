// var h = document.getElementById("myHeader");
// h.innerHTML = "Hello World";

$("#myHeader").text("Hello World");

function test() {
    // var name = $("#txtName").val();
    // alert("Your name: " + name)
    // $("#myHeader").hide();
}

function test1() {
    $("#myHeader").show();
}

$("#btnHide").click(test);
$("#btnShow").click(test1);


$("#btnStart").click(function() {

    $("#animate-block").animate({ 
        left: '250px',
     });

    $("#animate-block").fadeIn(1000);
    $("#animate-block").fadeOut(2000);



    //  $("#animate-block").css({'background-color': 'red', 'border': 'none'});

    //  $("#animate-block").addClass("radius-15");

    //  $("#animate-block").remove();


    // $("#animate-block").append("<h2>Some text</h2>")




    // $("#animate-block").animate({ 
    //     opacity: '0.5',
    //     height: '150px',
    //     width: '150px'
    //  });

    // $("#animate-block").animate({ 
    //     height: 'toggle',
    //  });
});