'use strict';

function AddEditTorunamentController($location) {
    var self = this;

    function onTournamentSaved() {
        $location.path('/home');
    }

    self.onTournamentSaved = onTournamentSaved;
}

AddEditTorunamentController.$inject = ['$location'];

module.exports = AddEditTorunamentController;
