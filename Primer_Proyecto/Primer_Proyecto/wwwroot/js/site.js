// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.

$(document).ready(function () { //DOM cargado, siempre va 
    //GetMajors();
    //GetNationalities();
    //LoadData();
    LoadDataEF();
});

function blanks(name, email, password, id_major, id_nationality) {
    if (name.length == 0 || email.length == 0 || password.length == 0 || id_major.length == 0 || id_nationality.length == 0) {
        alert("No field can be empty");
        return false;
    }
    return true;
}

function validate_email(email) {
    var regex = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email) ? true : false;
}

function validate_password(password) { //Utiliza código ASCII
    if (password.length >= 8) { //min 8 digitos
        var uppercase = false;
        var lowercase = false;
        var numero = false;
        var character = false;

        for (var i = 0; i < password.length; i++) {
            if (password.charCodeAt(i) >= 65 && password.charCodeAt(i) <= 90) { //Se validan mayusculas
                uppercase = true;
            }
            else if (password.charCodeAt(i) >= 97 && password.charCodeAt(i) <= 122) { //Se validan minusculas
                lowercase = true;
            }
            else if (password.charCodeAt(i) >= 48 && password.charCodeAt(i) <= 57) { //Se validan contraseñas
                number = true;
            }
            else {
                character = true; //Se valida los caracteres del teclado
            }
        }
        if (uppercase == true && lowercase == true && character == true && number == true) {
            return true;
        }
    } 
    return false;
}

function validationsAbout() {

    if (blanks(document.getElementById("name").value, document.getElementById("email").value, document.getElementById("password").value, document.getElementById("major"), document.getElementById("nationality"))) { //Si no hay ningun campo en blanco
        if (validate_email(document.getElementById("email").value)) { //Se valida si el correo es correcto
            if (validate_password(document.getElementById("password").value)) { //Se valida contraseña 
                Add(); //Se llama al método que agrega los valores
            }
            else {
                alert("The password needs to have uppercase, lowercase, a character and numbers");
            }
        }
        else {
            alert("The email is not correct");
        }
    }
}

function Add() { //llame al controlador home

    var student = { //var tipo de variable genetica (no tiene tipo especifico) OBJETO ESTUDIANTE
        name: $('#name').val(), //Obtenemos el valor que la persona digita en el formulario
        email: $('#email').val(),
        id_major: parseInt($('#major').val()),
        password: $('#password').val(),
        id_nationality: parseInt($('#nationality').val())
    };
    var message = document.getElementById('message');
    $.ajax({ //Simbolo de dolar todo lo de jquery
        url: "/Home/Insert",
        data: JSON.stringify(student),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            //aca recibo el resultafo del backend (datos,objetos,mensajes)
            Clean();
            document.getElementById("message").innerHTML = "User Was Inserted";
            document.getElementById("message").style.color = "green";

        },
        error: function (errorMessage) {
            /*alert("Error");
            alert(errorMessage.responseText);
            */
            document.getElementById("message").innerHTML = "User Was Not Inserted";
            document.getElementById("message").style.color = "red";

        }
    });
}

function Delete(id) { //llame al controlador home

    var id;

    $.ajax({ //Simbolo de dolar todo lo de jquery
        url: "/Home/Delete",
        data: JSON.stringify(id),
        type: "DELETE",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            //aca recibo el resultafo del backend (datos,objetos,mensajes)
            alert("ELIMINADO");
            LoadData();
        },
        error: function (errorMessage) {
            alert("Error");
            alert(errorMessage.responseText);
        }
    });
}

function LoadData() {
    $.ajax({
        url: "/Home/Get", //MVC NORMAL
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.id + '</td>';
                html += '<td>' + item.name + '</td>';
                html += '<td>' + item.email + '</td>';
                html += '<td>' + item.major.name + '</td>';
                html += '<td>' + item.nationality.name + '</td>';
                html += '<td>' + item.password + '</td>';
                html += '<td><a href="#getById" onclick="return GetStudentById(' + item.id + ')">Edit</a> | <a href="#Students" onclick="Delete(' + item.id + ')">Delete</a></td>';
            });
            $('.tbody').html(html);

        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    })

}

function LoadDataEF() {
    $.ajax({
        url: "/Student/GetEF", //MVC ENTITY FRAMEWORK
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.id + '</td>';
                html += '<td>' + item.name + '</td>';
                html += '<td>' + item.email + '</td>';
                html += '<td>' + item.major.name + '</td>';
                html += '<td>' + item.nationality.name + '</td>';
                html += '<td>' + item.password + '</td>';
                html += '<td><a href="#" onclick="return Get(' + item.id + ')">Edit</a> | <a href="#" onclick="Delete(' + item.id + ')">Delete</a></td>';
            });
            $('.tbody').html(html);

        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    })

}

function GetStudentsById(id) { //llame al controlador home

    var id;
    document.getElementById("getById").style.visibility = 'visible';

    $.ajax({ //Simbolo de dolar todo lo de jquery
        url: "/Home/GetStudentById",
        data: JSON.stringify(id),
        type: "PUT", //Put trae y pone 
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            //aca recibo el resultafo del backend (datos,objetos,mensajes)
            document.getElementById("id_update").value = result.id;
            document.getElementById("name_update").value = result.name;
            document.getElementById("email_update").value = result.email;
            document.getElementById("major_update").value = result.major.id;
            document.getElementById("nationality_update").value = result.nationality.id;
            document.getElementById("password_update").value = result.password;
        },
        error: function (errorMessage) {
            alert("Error");
            alert(errorMessage.responseText);
        }
    });
}


function Update() { //llame al controlador home

    var student = { //var tipo de variable genetica (no tiene tipo especifico) OBJETO ESTUDIANTE
        id: parseInt($('#id_update').val()),
        name: $('#name_update').val(), //Obtenemos el valor que la persona digita en el formulario
        email: $('#email_update').val(),
        id_major: parseInt($('#major_update').val()),
        password: $('#password_update').val(),
        id_nationality: parseInt($('#nationality_update').val())
    };

    $.ajax({ //Simbolo de dolar todo lo de jquery
        url: "/Home/Update",
        data: JSON.stringify(student),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            //aca recibo el resultafo del backend (datos,objetos,mensajes)
            alert("Updated User");
            Cancel();
            LoadData();
        },
        error: function (errorMessage) {
            alert("Error");
            alert(errorMessage.responseText);
        }
    });
}

function Clean() {
    document.getElementById("name_update").value = "";
    document.getElementById("email_update").value = "";
    document.getElementById("major_update").value = 0;
    document.getElementById("nationality_update").value = 0;
    document.getElementById("password_update").value = "";
}

function Cancel() { //llame al controlador home
    Clean();
    document.getElementById("getById").style.visibility = 'hidden';
}


function GetMajors() { //llame al controlador home

    $.ajax({ //Simbolo de dolar todo lo de jquery
        url: "/Home/GetMajors",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            //aca recibo el resultafo del backend (datos,objetos,mensajes)
            //llenar el dropdown (select)
            var html = '';
            $.each(result, function (key, item) {
                html += '<option value="' + item.id + '">' + item.name + '</option>';
            });
            $('#major').append(html); //en una etiqueta que se llame major ahi ponemos todo lo de arriba
            $('#major_update').append(html);
        },
        error: function (errorMessage) {
            alert("Error");
            alert(errorMessage.responseText);
        }
    });
    // alert("botón sirve");
}

function GetNationalities() { //llame al controlador home


    $.ajax({ //Simbolo de dolar todo lo de jquery
        url: "/Home/GetNationalities",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            //aca recibo el resultafo del backend (datos,objetos,mensajes)
            //llenar el dropdown (select)
            var html = '';
            $.each(result, function (key, item) {
                html += '<option value="' + item.id + '">' + item.name + '</option>';
            });
            $('#nationality').append(html); //en una etiqueta que se llame major ahi ponemos todo lo de arriba
            $('#nationality_update').append(html);
        },
        error: function (errorMessage) {
            alert("Error");
            alert(errorMessage.responseText);
        }
    });
    // alert("botón sirve");
}