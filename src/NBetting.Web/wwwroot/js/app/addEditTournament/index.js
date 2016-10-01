'use strict';

var angular = require('angular');
var ngRoute = require('angular-route');
var nBettingControls = require('../controls');
var common = require('../common');

var addEditTorunamentCtrl = require('./AddEditTorunamentController');
var addEditTorunamentComponent = require('./components/addEditTournamentFormComponent');
var editTeamComponent = require('./components/editTeamComponent');

var AddEditTournamentModule = angular.module('NBetting.AddEditTournament', [ngRoute, nBettingControls, common]);

AddEditTournamentModule.controller(addEditTorunamentCtrl.name, addEditTorunamentCtrl)
    .component(addEditTorunamentComponent.name, addEditTorunamentComponent)
    .component(editTeamComponent.name, editTeamComponent);

AddEditTournamentModule.config(function ($routeProvider) {
    $routeProvider
        .when("/tournaments/add", {
            templateUrl: 'views/add-edit-tournament/index.html',
            controller: addEditTorunamentCtrl.name,
            controllerAs: 'ctrl',
            caseInsensitiveMatch: true
        })
        .when("/tournaments/edit/:id", {
            templateUrl: 'views/add-edit-tournament/index.html',
            controller: addEditTorunamentCtrl.name,
            controllerAs: 'ctrl',
            caseInsensitiveMatch: true
        });
});


module.exports = AddEditTournamentModule.name;
