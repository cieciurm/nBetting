function MyTournamentsController(tournamentService) {
    var vm = this;
    vm.myTournaments = [];

    function getData() {
        vm.myTournaments = tournamentService.getMyTournaments();
    }

    this.$onInit = getData;
}

MyTournamentsController.$inject = ['TournamentService'];

var myTournamentsComponent = {
    name: 'myTournaments',
    controller: MyTournamentsController,
    templateUrl: '/views/home/my-tournaments-component.html'
};

module.exports = myTournamentsComponent;