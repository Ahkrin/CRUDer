$(document).ready(function () {
    var vm = new Vue({
        el: '#vm',
        data: {
            dtlHeader:{},
            recs:[]
        },
        methods: {
            evtSearch: function () {
                $.ajax({
                    method: "POST",
                    url: "/Home/GetDetail",
                    data: { name: "John", location: "Boston" }
                })
                .done(function (recs) {
                    vm.dtlHeader = recs[0]
                    vm.recs = recs[1]
                });
            }
        },
        filters: {
            dateToYYYYMMDD: function (value) {
                return moment(value).format('YYYYMMDD')
            }
        }
    })

})