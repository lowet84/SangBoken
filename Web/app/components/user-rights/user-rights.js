'use strict';

angular.module('myApp.user-rights', [
  'myApp.user-rights.setAdmin',
  'myApp.user-rights.isAdmin'
])

.value('version', '0.1');
