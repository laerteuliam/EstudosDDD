
    var app = angular.module('EstudosDDDApp', function (){});

    app.controller('PessoaController', function ($scope,$http) {

        $scope.Salvar = function() {
            alert('Salvo com sucesso.');
        };

        $scope.isEdit = function() {
            return $scope.Editable;
        };

        $scope.edit = function(index) {
            $scope.select(index);
            $scope.Editable = true;
        };

        $scope.select = function (index) {
            $scope.itemSelecionado = $scope.Items[index];
            $scope.Editable = false;
        };

        $scope.isSelected = function() {
            return ($scope.itemSelecionado != undefined);
        };

        $scope.Iniciar = function () {
            $scope.Editable = false;
            $http.post('/Pessoa/Listar').
            then(function (response) {
                $scope.Items = response.data;
            }, function (response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
        };

    });