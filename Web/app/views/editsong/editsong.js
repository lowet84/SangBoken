'use strict';

angular.module('myApp.editsong', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/editsong/:id', {
            templateUrl: 'views/editsong/editsong.html',
            controller: 'EditSongCtrl',
            service:'EditSongService'
        });
    }])

    .controller('EditSongCtrl', ['editSongService','$scope','$routeParams', function (editSongService,$scope,$routeParams) {
        if($routeParams.id!=-1) {
            editSongService($routeParams.id).success(function (data) {
                $scope.song = data;
            });
        }
        else{
            $scope.song = {
                Name:"",
                Line:""
            }
        }
        $scope.save=function(){
            var x = 0;
        }
    }]);