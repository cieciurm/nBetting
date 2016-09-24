'use strict';

var angular = require('angular');
var ngRoute = require('angular-route');
var nBettingControls = require('../controls');

var addEditTorunamentCtrl = require('./AddEditTorunamentController');
var addEditTorunamentComponent = require('./components/addEditTournamentFormComponent');

var AddEditTournamentModule = angular.module('NBetting.AddEditTournament', [ngRoute, nBettingControls]);

AddEditTournamentModule.controller(addEditTorunamentCtrl.name, addEditTorunamentCtrl)
    .component(addEditTorunamentComponent.name, addEditTorunamentComponent);

AddEditTournamentModule.config(function ($routeProvider) {
    $routeProvider
        .when("/tournaments/add", {
            templateUrl: 'views/add-edit-tournament/index.html',
            controller: addEditTorunamentCtrl.name,
            controllerAs: 'ctrl',
            caseInsensitiveMatch: true
        });
});


module.exports = AddEditTournamentModule.name;
