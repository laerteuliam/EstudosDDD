
    var app = angular.module('EstudosDDDApp', function (){});

    app.controller('PessoaController', function () {
        this.setModels = function (valor) {
            console.log(valor);
            this.Models = JSON.parse(valor);
        };

    });