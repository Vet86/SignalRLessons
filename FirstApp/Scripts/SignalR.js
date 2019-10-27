$.connection.hub.start()
    .done(function () { console.log("It worked!") })
    .fail(function () { alert("ERROR") });