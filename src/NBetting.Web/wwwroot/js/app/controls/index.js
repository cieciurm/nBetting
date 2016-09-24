'use strict';

var angular = require('angular');
var angularUI = require('angular-ui-bootstrap');
var datepicker = require('./components/datepicker');

var Controls = angular.module('NBetting.UiControls', [angularUI]);

Controls.component(datepicker.name, datepicker);

module.exports = Controls.name;
