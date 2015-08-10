
    var app = angular.module('EstudosDDDApp', function (){});

    app.controller('PessoaController', function ($scope,$http) {

        $scope.Iniciar = function () {
            $http.post('/Pessoa/Listar').
            then(function (response) {
                $scope.Items = response.data;
            }, function (response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
        };

    });