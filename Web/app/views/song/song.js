'use strict';

angular.module('myApp.song', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/song', {
            templateUrl: 'views/song/song.html',
            controller: 'SongCtrl',
        });
    }])

    .controller('SongCtrl', ['songService', '$scope','$rootScope', function (songService, $scope, $rootScope) {
        $rootScope.pageTitle = 'Sång' 
        songService().success(function (data) {
            $scope.songs = data;
            
        });
    }]);