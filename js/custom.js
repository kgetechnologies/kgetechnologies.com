	$(document).ready(function(){
    $(".loadlater").each(function(index, element){
        $(element).attr("src", $(element).attr("data-src"));
    });
	});