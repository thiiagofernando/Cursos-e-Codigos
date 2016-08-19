$("#sumir").click(function () {

    $("p").fadeOut("slow");
});

$("#mostrar").click(function () {

    $("p").fadeIn("slow");
});

$("#alterar").click(function () {

    $("p").attr("class", "alert alert-danger");
    
});
