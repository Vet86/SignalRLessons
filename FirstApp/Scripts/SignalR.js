var chat = $.connection.chatHub;
$.connection.hub.start()
    .done(function () {
        console.log("It worked!");
        chat.server.hello("asdasd");
    })
    .fail(function () { alert("ERROR") });

$.chat.client.addNewMessageToPage = function (message) {
    alert(message);
};