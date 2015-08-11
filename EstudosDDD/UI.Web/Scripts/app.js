var app = angular.module('EstudosDDDApp', []);
app.controller('PessoaController', PessoaController);

function PessoaController($http) {
    this.Items = {};
    this.Editable = false;
    this.ItemSelecionado = {};

    $http.post('/Pessoa/Listar').
    then(function (response) {
        this.Items = response.data;
    }, function (response) {
        // called asynchronously if an error occurs
        // or server returns response with an error status.
    });
};
PessoaController.$inject = ['$http'];

PessoaController.prototype.salvar = function () {
    alert('Salvo com sucesso.');
};
PessoaController.prototype.isEdit = function () {
    return this.Editable;
};
PessoaController.prototype.edit = function (index) {
    this.select(index);
    this.Editable = true;
};
PessoaController.prototype.select = function (index) {
    this.ItemSelecionado = this.Items[index];
    this.Editable = false;
};
PessoaController.prototype.isSelected = function() {
    return (this.ItemSelecionado != undefined);
};
PessoaController.prototype.panelTitle = function() {
    if (this.isEdit())
        return "Editar";
    else
        return "Visualizar";
};