var statusValue = document.getElementsByClassName("table-status-value");
statusAlteraCor();

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
  