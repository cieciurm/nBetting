'use strict';

function DatepickerController () {
    var self = this;
    self.$onInit = function () {
        self.isOpen = false;
        self.dateOptions = {
            formatYear: 'yy',
            maxDate: new Date(2100, 1, 1),
            minDate: new Date(),
            startingDay: 1
        }
    }

    self.open = function() {
        self.isOpen = true;
    }
}

var Datepicker = {
    name: 'datepicker',
    controller: DatepickerController,
    templateUrl: 'views/controls/datepicker-template.html',
    bindings: {
        date: '=',
        isRequired: '@',
        fieldName: '@'
    }

}

module.exports = Datepicker;
