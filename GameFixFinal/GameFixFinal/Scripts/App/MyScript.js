//var ul;
//var liItems;
//var imageWidth;
//var imageNumber;





$(document).ready(function () {
    var runLoop = true;
    var $bar = $('#prg-bar');

    var progress = setInterval(function progLoop() {
        if (runLoop == true) {
            if ($bar.width() > 810) {
                runLoop = false;                
            } else
                $bar.width($bar.width() + 60);
        }
        if (runLoop == false) {
            if ($bar.width() <= 0) {
                //clearInterval(progress);        
                runLoop = true;
            } else
                $bar.width($bar.width() - 900);
        }
    }, 5);
});

console.log("jlsjkdflsjk");
var timer;
var slides = 5;
function nextSlide() {
    clearTimeout(timer);
    var current = parseInt($(counter).html());
    var nextSlide = 0;

    if (current < slides)
        nextSlide = current + 1;
    else
        nextSlide = 1;

    $('#slide_back img').attr();

}

//progress bar
$(function () {
    console.log("inside function");
    $("#slide_front img").mouseover(function () {
        
        animateElement($(this));
    });
})



function animateElement(element){
    element.animate({height: '+=25', width: '+=25'})
    .animate({height: '-=25', width: '-=25'});
}