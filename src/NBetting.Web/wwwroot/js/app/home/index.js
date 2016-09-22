'use strict';

var angular = require('angular');
var homeCtrl = require('./homeController');

var HomeModule = angular.module('NBetting.Home', [])
                .controller(homeCtrl.name, homeCtrl);

module.exports = HomeModule;
