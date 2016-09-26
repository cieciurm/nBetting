function MyTournamentsController(tournamentService) {
    var vm = this;

    this.$onInit = function () {
        vm.myTournaments = tournamentService.getMyTournaments();
    };
}

MyTournamentsController.$inject = ['TournamentService'];

var myTournamentsComponent = {
    name: 'myTournaments',
    controller: MyTournamentsController,
    templateUrl: '/views/home/my-tournaments-component.html'
};

module.exports = myTournamentsComponent;