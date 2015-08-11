
    var app = angular.module('EstudosDDDApp', function (){});

    app.controller('PessoaController', function ($http) {
        this.Items = {};
        this.Editable = false;
        this.itemSelecionado = '';

        this.salvar = function() {
            alert('Salvo com sucesso.');
        };

        this.isEdit = function() {
            return this.Editable;
        };

        this.edit = function(index) {
            this.select(index);
            this.Editable = true;
        };

        this.select = function (index) {
            this.itemSelecionado = this.Items[index];
            this.Editable = false;
        };

        this.isSelected = function() {
            return (this.itemSelecionado != undefined);
        };

        this.panelTitle = function() {
            if (this.isEdit())
                return "Editar";
            else
                return "Visualizar";
        };
        
        this.iniciar = function () {
            $http.post('/Pessoa/Listar').
            then(function (response) {
                this.Items = response.data;
            }, function (response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
        };

    });