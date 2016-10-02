'use strict';

function fieldName() {
    return {
        restrict: 'A',
        require: '^form',
        link: function (scope, element, attrs, form) {
            var inputWithNdModel = null;

            if (element.is('input')) {
                inputWithNdModel = element.attr('name', attrs.fieldName);
            } else {
                var innerInput = element.find('input');
                if (innerInput.length > 0) {
                    var input = angular.element(innerInput[0]);
                    input.attr('name', attrs.fieldName);
                    inputWithNdModel = input;
                }
            }

            if (!inputWithNdModel) {
                console.warn("Input element didn find for : " + attrs.fieldName);
                return;
            }

            var ngModelCtrl = inputWithNdModel.controller('ngModel');
            ngModelCtrl.$name = attrs.fieldName;
            form.$addControl(ngModelCtrl);
        }
    };
}

module.exports = fieldName;