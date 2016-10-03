'use strict';

function AddEditTorunamentController($location, $route) {
    var self = this;
    function onTournamentSaved() {
        $location.path('/home');
    }

    function init() {
        var isEdit = $route.current.$$route.isEdit && $route.current.params.id;
        if (isEdit) {
            var tournamentId = $route.current.params.id;
             return { isEdit: isEdit, id: tournamentId };
        }

        return null;
    }

    self.addEditComponentCfg = init();
    self.onTournamentSaved = onTournamentSaved;
}

AddEditTorunamentController.$inject = ['$location', '$route'];

module.exports = AddEditTorunamentController;
