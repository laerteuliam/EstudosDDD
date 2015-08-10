
    var app = angular.module('EstudosDDDApp', function (){});

    app.controller('PessoaController', function ($scope,$http) {


        $scope.select = function (index) {
            $scope.itemSelecionado = $scope.Items[index];
        };

        $scope.isSelected = function() {
            return ($scope.itemSelecionado != 'undefined');
        };

        $scope.Iniciar = function () {

            $scope.index = 0;

            $http.post('/Pessoa/Listar').
            then(function (response) {
                $scope.Items = response.data;
            }, function (response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
        };

    });