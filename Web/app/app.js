'use strict';

// Declare app level module which depends on views, and components
var app = angular.module('myApp', [
    'ngRoute',
    'ngMaterial',
    'myApp.song',
    'myApp.book',
    'myApp.version',
    'myApp.editsong',
    'myApp.editbook',
    'myApp.user-rights'
]).config(['$routeProvider','$mdThemingProvider', function ($routeProvider,$mdThemingProvider) {
    $routeProvider.otherwise({redirectTo: '/song'});
    $mdThemingProvider.theme('default')
     .primaryPalette('blue')
     .accentPalette('red');
  
}]).run(['$rootScope','$mdSidenav', '$location' ,function($rootScope,$mdSidenav,$location) {
    $rootScope.isAdmin = false;
    $rootScope.openLeft = function(){
        $mdSidenav('left').open()
    }
    $rootScope.goto = function(path,id){
        if(id){
            path+='/'+id;
        }
        $location.path(path);
    }
}]).controller('NavigationCtrl', ['$scope','$mdSidenav', function ($scope,$mdSidenav) {
        $scope.openLeft = function(){
            $mdSidenav('left').open()
        }
        $scope.tacos = 'eh';
}]);
