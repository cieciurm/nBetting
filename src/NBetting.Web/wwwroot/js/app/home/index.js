'use strict';
var angular = require('angular');
var HomeCtrl = require('./homeController');

var Home = {
    name: 'NBetting.Home',
    homeController: HomeCtrl
};

Home.ngModule = angular.module(Home.name, [])
        .controller(Home.homeController.name, Home.homeController);


module.exports = Home;
