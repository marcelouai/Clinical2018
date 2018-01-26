//Várias Fotos
function handleFileSelect_OnePhoto(evt,controle) {
    var files = evt.target.files; // FileList object

    // Loop through the FileList and render image files as thumbnails.
    for (var i = 0, f; f = files[i]; i++) {

        // Only process image files.
        if (!f.type.match('image.*')) {
            continue;
        }

        var reader = new FileReader();

        // Closure to capture the file information.
        reader.onload = (function (theFile) {
            return function (e) {
                // Render thumbnail.

                //document.getElementById('fotorosto').src = '"', e.target.result,'" title="', escape(theFile.name), '"'
                //alert(e.target.result)
                //alert(escape(theFile.name))

                //coloca uma abaixo da outra
                if (1 == 1)
                {
                    var span = document.createElement('span');
                    span.innerHTML = ['<img id="'+controle+'" alt = "Package Management" class="img-responsive"  src="', e.target.result,
                        '" title="', escape(theFile.name), '"/>'].join('');
                    document.getElementById('list').insertBefore(span, null);
                }
                
            };
        })(f);

        // Read in the image file as a data URL.
        reader.readAsDataURL(f);
    }
}

function handleFileSelect_ManyPhoto(evt) {
    var files = evt.target.files; // FileList object

    // Loop through the FileList and render image files as thumbnails.
    for (var i = 0, f; f = files[i]; i++) {

        // Only process image files.
        if (!f.type.match('image.*')) {
            continue;
        }

        var reader = new FileReader();

        // Closure to capture the file information.
        reader.onload = (function (theFile) {
            return function (e) {
                // Render thumbnail.

                //document.getElementById('fotorosto').src = ''
                alert(e.target.result)
                alert(escape(theFile.name))

                //modificado
                var span = document.createElement('span');
                span.innerHTML = ['<img alt = "Package Management" class="img-responsive"  src="', e.target.result,
                    '" title="', escape(theFile.name), '"/>'].join('');
                document.getElementById('list').insertBefore(span, null);

                //original
                //var span = document.createElement('span');
                //span.innerHTML = ['<img class="thumb" src="', e.target.result,
                //    '" title="', escape(theFile.name), '"/>'].join('');
                //document.getElementById('list').insertBefore(span, null);
            };
        })(f);

        // Read in the image file as a data URL.
        reader.readAsDataURL(f);
    }
}

