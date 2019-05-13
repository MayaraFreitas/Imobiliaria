var iconeFiltro = document.getElementById("filtro-icone");
var iconeSidebar = document.getElementById("sidebar-icone");

var statusValue = document.getElementsByClassName("table-status-value");
statusAlteraCor();

iconeFiltro.addEventListener("click", function() {
  mostraFiltro();
});

iconeSidebar.addEventListener("click", function() {
  mostraSidebar();
});

function mostraFiltro() {
  if (document.getElementById("filtro").classList.contains("hide")) {
    document.getElementById("filtro").classList.remove("hide");
  } else {
    document.getElementById("filtro").classList.add("hide");
  }
}

function mostraSidebar() {
  if (document.getElementById("sidebar").style.display == "none") {
    document.getElementById("sidebar").style.display = "block";
    document.getElementById("body-container").style.paddingLeft = "200px";
  } else {
    document.getElementById("sidebar").style.display = "none";
    document.getElementById("body-container").style.paddingLeft = "0px";
  }
}

// function mostraSidebar() {
//   if (document.getElementById("sidebar").classList.contains("hide")) {
//     document.getElementById("sidebar").classList.remove("hide");
//     document.getElementById("body-container").style.paddingLeft = "200px";
//   } else {
//     document.getElementById("sidebar").classList.add("hide");
//     document.getElementById("body-container").style.paddingLeft = "0px";
//   }
// }

function statusAlteraCor() {
  var dadosTabela = document.getElementsByTagName("tr");
  var status;

  for (var i = 0; i < statusValue.length; i++) {
    status = statusValue[i].innerHTML;
    if (status == "Atrasado") {
      dadosTabela[i + 1].style.color = "#FF0000";
    }
  }
}