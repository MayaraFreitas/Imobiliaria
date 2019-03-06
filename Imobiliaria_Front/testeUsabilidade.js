var classname = document.getElementsByClassName("card");

var card = function() {
    if(window.location.href == "file:///C:/Users/Rodrigo_Almeida/Documents/Faculdade/Front_2.0/listaVistorias.html#!"){
        window.location.href = "listaComodos.html";
    }
    if(window.location.href == "file:///C:/Users/Rodrigo_Almeida/Documents/Faculdade/Front_2.0/listaComodos.html"){
        window.location.href = "listaNotas.html";
    }
    
};


for (var i = 0; i < classname.length; i++) {
    classname[i].addEventListener('click', card, false);
}

