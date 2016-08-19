function Calcular() {

    var inputPeso = document.getElementById("Peso")
    var peso = inputPeso.value;

    var inputAltura = document.getElementById("Altura");
    var altura = inputAltura.value;


    console.log("Peso " + peso + " Altura " + altura);

    if (validaPeso(peso)) {

        var imc = peso / (altura * altura);
        imc = imc.toFixed(2);

        var divResultado = document.getElementById("Resultado");
        divResultado.innerHTML = "<div class='alert alert-success'>Seu Imc: " + imc + "</div>";

    }
}

function validaPeso(peso) {
    if (peso == 0 || peso == "" || peso == null) {
        document.getElementById("resultado").innerHTML = "Peso não Pode ser zero!!";
        return false;
    } else {
        return true;
    }
}