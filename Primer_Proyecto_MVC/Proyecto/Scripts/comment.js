satisfactoriamente$(document).ready(function () {
});

/*function addComment() {
    
    var comment = {
        AuthorId: $('#').val(),
        AuthorName: $('#Author').val(),
        Text: $('#text').val(),
        DateTime: $('#Date').val()
    };

    $.ajax({
        url: "/Comment/InsertComment",
        data: JSON.stringify(comment),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}*/

function getCommentById(id) {
    
    $.ajax({
        url: "/Comment/GetComment/" + id,
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

        },

        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}

function deleteComment(id) {
    var alert = confirm("Welcome, are you sure you want to delete the comment?");

    if (alert) {
        $.ajax({
            url: "/Comment/DeleteComment/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}