$('#pesquisar').click(function () {
    var cep = $('#CEP').val();

    console.log(cep);

    $.ajax("https://viacep.com.br/ws/" + cep + "/json")
    .done(function (data) {
        $('#Cidade').val(data.localidade);
        $('#UF').val(data.uf);
        $('#logradouro').val(data.logradouro);
        $('#complemento').val(data.complemento);

    });
});

$('#CEP').keyup(function () {

    var cep = $('#CEP').val();

    cep = cep.replace("-", " ");
    console.log("ok" + cep.length);


    if (cep.length == 8) {
        $('progress').show();
        $.ajax("https://viacep.com.br/ws/" + cep + "/json")
        .done(function (data) {
        $('#cepmostrar').val(data.cep);
        $('#logradouro').val(data.logradouro);
        $('#localidade').val(data.localidade);
        $('#bairro').val(data.bairro);
        $('#uf').val(data.uf);

        if (data.erro) {
            alert('CEP não localizado');
        }

        $('progress').fadeOut();

        });

    }


});