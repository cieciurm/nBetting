'use strict';
var angular = require('angular');
var ngRoute = require('angular-route');
var router = require('./router.js');

(function() {
    var appName = "NBetting";
    var home = require('./home');
    var addEditTournament = require('./addEditTournament');

    var app = angular.module(appName, [
        ngRoute,
        home,
        addEditTournament
    ]);

    app.config(router);
})();
