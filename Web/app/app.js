'use strict';

// Declare app level module which depends on views, and components
var app = angular.module('myApp', [
    'ngRoute',
    'myApp.song',
    'myApp.book',
    'myApp.version',
    'myApp.editsong',
    'myApp.editbook'
]).config(['$routeProvider', function ($routeProvider) {
    $routeProvider.otherwise({redirectTo: '/song'});
}]);
