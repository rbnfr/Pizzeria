var app = angular.module('LoginForm', ['ngMaterial', 'ngAnimate', 'ngAria', 'ngMessages'])
    .controller('CtrlLogin', function ($scope) {
        $scope.vm = {
            formData: {
                email: 'correo@ejemplo.com',
                password: 'foobar'
            }
        };
    });