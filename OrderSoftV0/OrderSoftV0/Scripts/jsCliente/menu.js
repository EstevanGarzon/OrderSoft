$(document).ready(function () {
    console.log(":v v1");
    cc = 0;
    arrayPlatos = [];

    $("#btnPlato").click(function () {
        html = "";
        subTotal = 0;
        arrayComida = [];
        //Ingeniero que no es pirata es por que tiene plata :v 
        console.log("Click"); 
        var lisC = $(".c");
        for (var i = 0; i < lisC.length; i++) {
            if ($(lisC[i]).is(":checked")) { 
                html += "<tr>"+
                            "<td>" + $("#LabelComida" + i).html()+"</td >"+
                            "<td> $ " + $("#Comida" + i).val()+"</td > "+
                         "</tr > "; 
                arrayComida.push({
                    "idLisc":i, 
                    "nombre": $("#LabelComida"+i).html(),
                    "precio": $("#Comida"+i).val()
                });
                subTotal = subTotal + parseInt($("#Comida" + i).val());
            }
        }


        html += "<tr>" +
            "<td>Sub total </td >" +
            "<td> $ " + subTotal+ "</td > " +
            "</tr > "; 

        arrayPlatos.push(arrayComida);
        var clon = $("#clonPlato").clone();
        clon.find(".cabecera").attr('id', "CabeceraPlato" + cc);
        clon.find(".cabecera").html("Plato n " + parseInt(cc+1));
        clon.find(".cabecera").attr('data-target', "#Plato" + cc);
        clon.find(".body").attr('id', "Plato" + cc);
        clon.find(".btnModifica").attr('id',cc);
        clon.find("#ContenidoPlato").html(html);

        console.log(clon);
        clon.children().appendTo($("#listaPlatos"));
        console.log(arrayPlatos);
        cc++; 
        $(".c").prop("checked", false); 
        $("#ordenar").prop("disabled",false)
    });

});