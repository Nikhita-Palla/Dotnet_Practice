var buttonelement=document.getElementById("btn1");
var bodyTag=document.getElementsByTagName("body")[0];
var bg="white";
var btnelement=document.getElementById("mybtn");

buttonelement.onclick=function(){
    if(bg==="white"){
        bodyTag.style.backgroundColor="black";
        bg="black";
    }
    else{
        bodyTag.style.backgroundColor="white";
        bg="white";
    }
    
}

btnelement.addEventListener("click",function(){alert("Event handled with event listner!")});

