'use strict';

angular.module('myApp.song', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/song', {
            templateUrl: 'views/song/song.html',
            controller: 'SongCtrl',
            service:'SongService'
        });
    }])

    .controller('SongCtrl', ['songService','$scope', function (songService,$scope) {
        songService.success(function(data){
            $scope.songs=data;
        });
    }]);