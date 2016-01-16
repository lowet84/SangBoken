'use strict';

// Declare app level module which depends on views, and components
var app = angular.module('myApp', [
    'ngRoute',
    'myApp.song',
    'myApp.book',
    'myApp.version',
    'myApp.editsong',
    'myApp.editbook',
    'myApp.user-rights'
]).config(['$routeProvider', function ($routeProvider) {
    $routeProvider.otherwise({redirectTo: '/song'});
  
}]).run(['$rootScope',function($rootScope) {
    $rootScope.isAdmin = false;
}]);

