$(document).ready(function () {
    var vapp = new Vue({
        el: '#vapp',
        data: {
            detailList:[]
        }
    })

    $("#btnSearch").click(function () {
        $.ajax({
            method: "POST",
            url: "/Home/GetDetail",
            data: { name: "John", location: "Boston" }
        })
        .done(function (detaillist) {
            vapp.detailList = detaillist
        });
    })
})