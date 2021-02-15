function pricevalidation(){
    var minp = document.getElementById("min-price").value;
    var maxp = document.getElementById("max-price").value;
    var reg = /^\d+$/;
    if (reg!=minp || reg!=maxp){
        document.getElementById("price-warning").innerHTML = "Please enter numeric value";
    }
    if (reg==minp && reg==maxp){
        document.getElementById("price-warning").innerHTML = "";
    }
    min = Number(minp);
    max  = Number(maxp);
    if (max<min){
        document.getElementById("price-warning").innerHTML = "Check Range!";
    }
    if (max>min){
        document.getElementById("price-warning").innerHTML = "";
    } 

    }



function page(){
        var header = document.getElementById("pagination");
        var btns = header.getElementsByClassName("pbtn");
        for (var i = 0; i < btns.length; i++) {
          btns[i].addEventListener("click", function() {
          var current = document.getElementsByClassName("active");
          current[0].className = current[0].className.replace(" active", "");
          this.className += " active";
          });
        }
}

