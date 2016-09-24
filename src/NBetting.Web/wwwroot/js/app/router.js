'use strict';

function Router($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(true);
    $routeProvider
        .otherwise({
            redirectTo : '/home'
        });
}

Router.$inject = ['$routeProvider', '$locationProvider'];

module.exports = Router;