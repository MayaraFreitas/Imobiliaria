document.getElementById("filtro-icone").addEventListener("click", function() {
    mostraFiltro();
});

function mostraFiltro() {

    var filtro = document.getElementById("filtro");

    if (filtro.classList.contains("hide")) {
        filtro.classList.remove("hide");
    } else {
        filtro.classList.add("hide");
    }
}