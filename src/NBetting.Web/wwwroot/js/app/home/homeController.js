'use strict';

function HomeController($location) {
    var self = this;

    self.onEditClicked = function ($event) {
        $location.path('/tournaments/edit/' + $event.id);
    }
}

module.exports = HomeController;
