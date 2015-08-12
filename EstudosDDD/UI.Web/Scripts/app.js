var app = angular.module('EstudosDDDApp', []);

app.controller('PessoaController', function ($scope,$http) {
    $scope.Items = [];
    $scope.Editable = false;
    $scope.ItemSelecionado = {};

    $scope.dataBind = function() {
        $http.post('/Pessoa/Listar').
        then(function (response) {
            $scope.Items = response.data;
        }, function (response) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });
    };
    $scope.adicionar = function() {
        $scope.ItemSelecionado = undefined;
        $scope.Editable = true;
    };
    $scope.salvar = function () {
        $http.post('/Pessoa/Salvar',$scope.ItemSelecionado).
        then(function (response) {
            alert('Salvo com sucesso.');
        }, function (response) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });
        
    };
    $scope.isEdit = function () {
        return $scope.Editable;
    };
    $scope.edit = function (index) {
        $scope.select(index);
        $scope.Editable = true;
    };
    $scope.select = function (index) {
        $scope.ItemSelecionado = $scope.Items[index];
        $scope.Editable = false;
    };
    $scope.isSelected = function () {
        return ($scope.ItemSelecionado != undefined);
    };
    $scope.panelTitle = function () {
        if ($scope.isEdit() && $scope.ItemSelecionado!=undefined) return "Editar";
        if ($scope.isEdit() && $scope.ItemSelecionado == undefined) return "Adicionar";
        if (!$scope.isEdit() && $scope.ItemSelecionado != undefined) return "Visualizar";
    };
});

