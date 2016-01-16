'use strict';

angular.module('myApp.user-rights.setAdmin', [])

.directive('setAdmin', ['$rootScope', function($rootScope) {
    var template = ['<div>',
    '<button ng-if="isAdmin" ng-click="toggle()">Sluta editera</button>',
    '<button ng-if="!isAdmin" ng-click="toggle()">Editera</button>',
    '</div>'].join('\n')
  return {
      template:template,
      link:function(scope,element,attrs){
          scope.toggle = function(){
              $rootScope.isAdmin = !$rootScope.isAdmin;
          }
      }
      
  }
}]);
