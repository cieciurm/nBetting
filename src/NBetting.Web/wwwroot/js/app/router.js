'use strict';
var homeController = require('./home/homeController.js');

function Router($routeProvider, $locationProvider) {
    $routeProvider
        .when("/home", {
            templateUrl: 'views/Home/index.html',
            controller: homeController.name,
            controllerAs: 'ctrl',
            caseInsensitiveMatch: true
        })
        .otherwise({
            redirectTo : '/home'
        });
}

Router.$inject = ['$routeProvider', '$locationProvider'];

module.exports = Router;