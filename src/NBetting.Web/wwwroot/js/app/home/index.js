'use strict';

var angular = require('angular');
var ngRoute = require('angular-route');

var homeCtrl = require('./HomeController');

var HomeModule = angular.module('NBetting.Home', [ngRoute])
    .controller(homeCtrl.name, homeCtrl);

HomeModule.config(function($routeProvider) {
    $routeProvider
        .when("/home", {
            templateUrl: 'views/Home/index.html',
            controller: homeCtrl.name,
            controllerAs: 'ctrl',
            caseInsensitiveMatch: true
        });
});

module.exports = HomeModule.name;
