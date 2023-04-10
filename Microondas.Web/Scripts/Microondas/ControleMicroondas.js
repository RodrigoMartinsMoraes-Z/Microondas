let interval = 0;
let remainingSeconds = 0;
let power = 10;
let isPaused = false;

let selectedField = document.getElementById("time-input");

let preProgrammed = {};
let itens;
let itemSelected;

function updateProgressLabel() {
    if (!isPaused) {
        if (remainingSeconds > 0) {
            $("#progress-label").text("");
            let dotsPerSecond = 2 * power;
            let dots = ".".repeat(Math.ceil((120 - remainingSeconds) * dotsPerSecond / 60));
            let progressString = dots.padEnd(dots.length + remainingSeconds * dotsPerSecond / 60, " ");
            $("#progress-label").text(progressString);
            remainingSeconds--;
            console.log(remainingSeconds);
            setTimeout(updateProgressLabel, 1000);
        } else {
            stopInterval();
        }
    }
}

function stopInterval() {
    if (isPaused) {
        interval = 0;
        remainingSeconds = 0;
        isPaused = false;
    }
    else
        isPaused = true;
}

function startInterval(fastStart) {
    if (!isPaused) {
        if (interval !== null && fastStart) {
            stopInterval();
            remainingSeconds += 30;
        } else {
            if ($("#time-input").val().match(/^\d+(:\d+)?$/) === null) {
                alert("Tempo inválido. Informe um número inteiro ou no formato de minutos:segundos.");
                return;
            }
            let timeParts = $("#time-input").val().split(":");
            if (timeParts.length === 1) {
                remainingSeconds = parseInt(timeParts[0]);
            } else {
                remainingSeconds = parseInt(timeParts[0]) * 60 + parseInt(timeParts[1]);
            }
            if (remainingSeconds < 1 || remainingSeconds > 120) {
                alert("Tempo inválido. Informe um tempo entre 1 segundo e 2 minutos.");
                return;
            }
            power = parseInt($("#power-input").val());
            if (power < 1 || power > 10) {
                alert("Potência inválida");
                return;
            }
        }
    }
    else {
        isPaused = false;
    }
    updateProgressLabel();
}

function thisOnFocus(field) {
    selectedField = field;
}

function inputValue(number) {
    if (selectedField.id == "time-input" && selectedField.value.length <= 4) {
        selectedField.value = selectedField.value + number;
        formatTime();
    }
    else if (selectedField.id == "power-input") {
        selectedField.value = selectedField.value + number;
        if (selectedField.value < 0)
            selectedField.value = 0;
        else if (selectedField.value > 10)
            selectedField.value = 10;
    }
};

function formatTime() {
    let valor = selectedField.value;
    valor = valor.replace(/\D/g, ''); // Remove tudo que não é dígito
    valor = valor.replace(/^(\d{2})(\d)/g, '$1:$2'); // Coloca ':' após os 2 primeiros dígitos
    selectedField.value = valor;
}

function getResultAndList(result) {
    itens = JSON.parse(result);
    // seleciona o dropdown pelo id
    const dropdown = document.getElementById('item-dropdown');
    // para cada item, adiciona uma nova opção ao dropdown
    itens.forEach(function (item) {
        const option = document.createElement('option');
        option.text = item.Nome;
        option.value = item.Id;
        dropdown.add(option);
    });
    // adiciona um listener para quando uma opção for selecionada
    dropdown.addEventListener('change', function () {
        preProgrammed = dropdown.options[dropdown.selectedIndex].text;
        itemSelected = itens.find(function (item) {
            return item.Nome == preProgrammed;
            //return item.Id == dropdown.value;
        });
        console.log(itemSelected);
    });
}

//buscar pré definições na api
let xhr = new XMLHttpRequest();

xhr.open('GET', 'https://localhost:44366/programacao');

xhr.onload = function () {
    if (xhr.status === 200) {
        let result = xhr.responseText;
        getResultAndList(result);
    } else {
        console.log('Erro na requisição. Código de status: ' + xhr.status);
    }
};

xhr.send();
