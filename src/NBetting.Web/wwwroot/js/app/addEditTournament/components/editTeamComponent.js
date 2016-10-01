'use strict';

function EditTeamComponentController() {
    var self = this;

    self.$doCheck = function () {
        onTeamChanged();
    };

    self.$onChanges = function (changes) {
    };

    self.delete = function (id) {
        onDelete(id);
    }

    function onDelete(id) {
        if (self.onDelete) {
            self.onDelete({ $event: { id: id } });
        }
    }

    function onTeamChanged() {
        if (self.onChange) {
            self.onChange({ $event: { team: self.team } });
        }
    }
}

var EditTeamComponent = {
    name: 'editTeam',
    controller: EditTeamComponentController,
    templateUrl: 'views/add-edit-tournament/edit-team-template.html',
    bindings: {
        team: '<',
        onDelete: '&',
        onChange: '&',
        isEdit: '@'
    }
}

module.exports = EditTeamComponent;
