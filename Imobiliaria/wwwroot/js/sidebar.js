document.getElementById("sidebar-icone").addEventListener("click", function() {
    mostraSidebar();
});



document.getElementsByTagName("body")[0].addEventListener("change", function(){
    var lHeight = window.screen.height;
    document.getElementById("sidebar").style.height = lHeight;
});

function mostraSidebar() {
    var sidebar = document.getElementById("sidebar");
    var navbarContainer = document.getElementById("navbar-container");
    var bodyContainer = document.getElementById("body-container");
    var lWidth = window.screen.width;
    
    console.log(document.getElementById("body-container").clientHeight);

    // var lHeight = "" + window.screen.height ;
    // document.getElementById("sidebar").style.height = "" + document.getElementsByTagName("body")[0].clientHeight;
    

    if (sidebar.style.display == "none") {
        sidebar.style.display = "block";
        navbarContainer.style.paddingLeft = "210px";
        bodyContainer.style.paddingLeft = "0px";
        if(lWidth >= 768){
            bodyContainer.style.paddingLeft = "200px";
            navbarContainer.style.paddingLeft = "10px";
        }
    } else {
        sidebar.style.display = "none";
        navbarContainer.style.paddingLeft = "10px";
        if(lWidth >= 768){
            bodyContainer.style.paddingLeft = "0px";
        }
    }
}