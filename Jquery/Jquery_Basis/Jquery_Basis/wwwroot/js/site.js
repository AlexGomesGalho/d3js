// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('li').css('color', 'blue').slideUp(1000).slideDown(1000), attr('title', 'Mytitle');
});

$(document).ready(() => {
    $("#buttn1").click(() => {
        $("id1").prepend("<Strong>Aditya</strong>");
    });

    $("#buttn2").click(() => {
        $("ol").prepend("<li>Bangalore </li>")
    })
});

$(document).ready(() => {
    $("#btn3").click(function () {
        $("h1,h2,p").addClass("blue");
        $("#div9").addClass("important");
    });
});

$(document).ready(function () {
    $("#bttnnnnnnn").click(function () {
        $("#divvvv").load("C:\Users\Bizruntime-50\source\repos\Aditya-N\Jquery\Jquery_Basis\Jquery_Basis\wwwroot\js\task.txt");
    });
});