'use strict';

var angular = require('angular');
var angularUI = require('angular-ui-bootstrap');
var datepicker = require('./components/datepicker');

var fieldName = require('./directives/filedNameDirective');

var Controls = angular.module('NBetting.UiControls', [angularUI]);

Controls.component(datepicker.name, datepicker)
    .directive(fieldName.name, fieldName);

module.exports = Controls.name;
