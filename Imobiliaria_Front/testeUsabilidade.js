var classname = document.getElementsByClassName("card");

var card = function() {
    if(window.location.href.indexOf("listaVistorias.html") > -1){
        window.location.href = "listaComodos.html";
    }
    if(window.location.href.indexOf("listaComodos.html") > -1){
        window.location.href = "listaNotas.html";
    }
    
};


for (var i = 0; i < classname.length; i++) {
    classname[i].addEventListener('click', card, false);
}

