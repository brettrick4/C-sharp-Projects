// JavaScript source code
function myMove() {
    var elem = document.getElementById("animation");
    var pos = 0;
    var id = setInterval(frame, 10);
    function frame() {
        if (pos == 150) {
            clearInterval(id);
        } else {
            pos++;
            elem.style.left = pos + "1px";
            elem.style.right = pos + "1px";
        } 
    }
}