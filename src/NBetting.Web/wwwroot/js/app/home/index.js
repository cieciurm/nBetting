'use strict';

var angular = require('angular');
var ngRoute = require('angular-route');
var common = require('../common');
var tournamentService = require('./services/tournamentService');
var myTournamentsComponent = require('./components/myTournamentsComponent');

var homeCtrl = require('./HomeController');

var HomeModule = angular.module('NBetting.Home', [ngRoute, common])
                        .service(tournamentService.name, tournamentService)
                        .component(myTournamentsComponent.name, myTournamentsComponent)
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
