'use strict';

angular.module('myApp.book', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/book', {
            templateUrl: 'views/book/book.html',
            controller: 'BookCtrl'
        });
    }])

    .controller('BookCtrl', ['bookService','$scope', function (bookService,$scope) {
        bookService().success(function (data) {
            $scope.books = data;
        });
    }]);