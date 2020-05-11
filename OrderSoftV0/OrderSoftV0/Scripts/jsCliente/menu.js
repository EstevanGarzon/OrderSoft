$(document).ready(function () {
    console.log(":v v1");
    cc = 0;
    arrayPlatos = [];
    $(document).on('click', '.e', function (e) { 
        $("#trC"+$(this).attr('id')).remove();
    });
    $(document).on('click', '.c', function (e) {
        console.log("Click"); 
        cc++;
        $("#ContenidoPlato").append("<tr id='trC"+cc+"'>" +
            "<td>" + $("#t" + $(this).attr("id")).html() + "</td >" +
            "<td> $ " + $(this).val() + "</td > " +
            "<td><button class='btn btn-danger e' id='"+cc+"'>Eliminar</button></td>"+
            "</tr > ");
        $("#ordenar").prop("disabled", false);
    });

});