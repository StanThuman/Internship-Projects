angular.module('street-songs', ['angular-meteor','ui.router', 'ngMaterial',
  'angularUtils.directives.dirPagination','uiGmapgoogle-maps'])
.config(['$urlRouterProvider', '$stateProvider', '$locationProvider',
  function ($urlRouterProvider, $stateProvider, $locationProvider) {
    $locationProvider.html5Mode(true);

    $stateProvider
      .state('main', {
        url: '/',
        templateUrl: 'templates/main.ng.html',
        controller: 'MainCtrl'
      })
      .state('search-songs', {
        url: '/search-songs',
        templateUrl: 'templates/search-songs.ng.html',
        controller: 'SearchSongsCtrl'
      })
    ;


    $urlRouterProvider.otherwise('/');
  }
])
.config(['$mdThemingProvider', function ($mdThemingProvider) {
  $mdThemingProvider.theme('default')
    .primaryPalette('deep-orange')
    .accentPalette('green')
  ;
}])
;
