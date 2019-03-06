var iconeFiltro = document.getElementById("navbar-filter-list");

iconeFiltro.addEventListener("click", function(){ mostraFiltro()});

function mostraFiltro(){
  if(document.getElementById("navbar-filtros").classList.contains('hide')){
    document.getElementById("navbar-filtros").classList.remove('hide');
    getDate();
  }else{
    document.getElementById("navbar-filtros").classList.add('hide');
  }
}

function getDate(){
  var d = new Date();
  let ano = d.getFullYear();
  let mes = d.getMonth() + 1;
  let dia = d.getDate();

  if (dia < 10) {
    dia = '0' + dia;
  }

  if (mes < 10) {
    mes = '0' + mes;
  }
  document.getElementById("data").value = ano + "-" + mes + "-" + dia;
}