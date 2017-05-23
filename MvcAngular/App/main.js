var app = angular.module("produtosApp", []);

app.controller("produtosCtrl", function ($scope, $http) {
    $http({
        method: 'GET',
        url:'/home/GetProdutos/'
    }).then(
        function (result) {
            console.log(result.data);
            $scope.produtos = result.data;
        },
        function (data) {
            console.log(data);
        });
});

