'use strict';

angular.module('myApp.editbook', ['ngRoute'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/editbook/:id', {
            templateUrl: 'views/editbook/editbook.html',
            controller: 'EditBookCtrl'
        });
    }])

    .controller('EditBookCtrl', ['editBookService', 'saveBookService', 'deleteBookService', 'songService',
        '$scope', '$routeParams', '$location',
        function (editBookService, saveBookService, deleteBookService, songService, $scope, $routeParams, $location) {
            if ($routeParams.id != -1) {
                editBookService($routeParams.id).success(function (data) {
                    $scope.book = data;
                    $scope.updateSelectedSongs();
                });
            }
            else {
                $scope.book = {
                    Name: "",
                    Songs: []
                }
            }

            songService().success(function (data) {
                $scope.songs = data;
                $scope.updateSelectedSongs();
            });

            $scope.save = function () {
                saveBookService($routeParams.id, $scope.book).success(function (data) {
                    if ($routeParams.id == -1) {
                        $location.path('/editbook/' + data);
                    }
                });
            }
            $scope.delete = function () {
                deleteBookService($routeParams.id).success(function (data) {
                    $location.path('/book/');
                });
            }
            $scope.search = "";

            $scope.add = function (id) {
                $scope.book.Songs.push(id);
                $scope.updateSelectedSongs();
            }

            $scope.remove = function (id) {
                var index = $scope.book.Songs.indexOf(id);
                $scope.book.Songs.splice(index,1);
                $scope.updateSelectedSongs();
            }

            $scope.updateSelectedSongs = function () {
                $scope.availableSongs = [];
                $scope.selectedSongs = [];
                if ($scope.book != undefined && $scope.songs != undefined) {
                    for (var i = 0; i < $scope.book.Songs.length; i++) {
                        for (var j = 0; j < $scope.songs.length; j++) {
                            if ($scope.book.Songs[i] == $scope.songs[j].Id) {
                                $scope.selectedSongs.push({
                                    id: $scope.book.Songs[i],
                                    name: $scope.songs[j].Name
                                });
                                break;
                            }
                        }
                    }

                    for (i = 0; i < $scope.songs.length; i++) {
                        var ok = true;
                        for (j = 0; j < $scope.book.Songs.length; j++) {
                            if ($scope.book.Songs[j] == $scope.songs[i].Id) {
                                ok = false;
                                break;
                            }
                        }
                        if ($scope.search.length > 0 && $scope.songs[i].Name.toLowerCase().indexOf($scope.search.toLowerCase()) == -1) {
                            ok = false;
                        }

                        if (ok) {
                            $scope.availableSongs.push({
                                id: $scope.songs[i].Id,
                                name: $scope.songs[i].Name
                            });
                        }
                    }
                }
            };
        }]);