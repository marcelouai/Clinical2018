function ocultarDivsTitulo(Ocultar, Aparecer) {

    if (!document.getElementsByTagName == false) {
        var tag = document.getElementsByTagName("div");

        for (var i = 0; i < tag.length; i++) {
            var div = tag[i];
            var verifica = div.title;

            if (verifica == Ocultar) {
                div.style.display = "none";
            }
            if (verifica == Aparecer) {
                div.style.display = "block";
            }

        }
    }

}