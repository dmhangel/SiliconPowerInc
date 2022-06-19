function SendRegister() {
    $.post("/api/Register",
        $("#RegisterForm").serialize(),
        function (value) {
            if (value == true) {
                alert("El usuario se ha registrado correctamente");
            } else {
                alert("Error al registrar el usuario");
            }
        },
        "json"
    );
}

function AlreadyRegistered() {
    $.get("/api/Register",
        $("#mail").serialize(),
        function (value) {
            if (value == false) {
                SendRegister();
            } else {
                $("#mail").css("color", "red");
                $("#mail_response").text("El e-mail ya está registrado");
                $("#mail_response").css("color", "red");
            }
        },
        "json"
    )
}

function validateMailAddress(mail, valid) {
    var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    $("#mail_response").text("");
    if (re.test(mail)) {
        $("#mail").css("color", "green");
    } else {
        valid = false;
        $("#mail").css("color", "red");
        $("#mail_response").text("E-mail is not correct");
        $("#mail_response").css("color", "red");
    }
    return valid;
}

function validatePasword(pswrd, pswrd_valid, valid) {
    $("#pswrd_response").text("");
    $("#pswrd_repeat_response").text("");
    var re = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$/;
    if (pswrd == pswrd_valid && re.test(pswrd)) {
        $("#psw").css("color", "green");
        $("#psw_repeat").css("color", "green");
    } else if (!re.test(pswrd)) {
        valid = false;
        $("#psw").css("color", "red");
        $("#pswrd_response").text("Password of 8 to 15 character nedded (include upercase, number and symbol)");
        $("#pswrd_response").css("color", "red");
    } else {
        valid = false;
        $("#psw").css("color", "red");
        $("#psw_repeat").css("color", "red");
        $("#pswrd_repeat_response").text("Paswords do not match");
        $("#pswrd_repeat_response").css("color", "red");
    }
    return valid;
}

function validateName(name, valid) {
    var re = /^[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+$/;
    $("#name_response").text("");
    if (re.test(name)) {
        $("#name").css("color", "green");
    } else {
        valid = false;
        $("#name").css("color", "red");
        $("#name_response").text("Name is not valid");
        $("#name_response").css("color", "red");
    }
    return valid;
}

function validateSurName(surname, valid) {
    var re = /^[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+$/;
    $("#surname_response").text("");
    if (re.test(surname)) {
        $("#surname").css("color", "green");
    } else {
        valid = false;
        $("#surname").css("color", "red");
        $("#surname_response").text("Surname is not valid");
        $("#surname_response").css("color", "red");
    }
    return valid;
}

function validatePhone(phone, valid) {
    var re = /(^[0-9]{9}$)|(^\+[0-9]{2}[0-9]{9}$)/;
    $("#phone_response").text("");
    if (re.test(phone)) {
        $("#phone").css("color", "green");
    } else {
        valid = false;
        $("#phone").css("color", "red");
        $("#phone_response").text("Phone is not valid");
        $("#phone_response").css("color", "red");
    }
    return valid;
}

function validateAddress(address, valid) {
    var re = /^[a-zA-Z0-9À-ÿ\u00f1\u00d1\u00e7\u00c7\u00ba\u00aa\s,.\\/]{0,255}$/;
    $("#address_response").text("");
    if (re.test(address)) {
        $("#address").css("color", "green");
    } else {
        valid = false;
        $("#address").css("color", "red");
        $("#address_response").text("Address is not valid");
        $("#address_response").css("color", "red");
    }
    return valid;
}

function validateTown(town, valid) {
    var re = /^[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+$/;
    $("#town_response").text("");
    if (re.test(town)) {
        $("#town").css("color", "green");
    } else {
        valid = false;
        $("#town").css("color", "red");
        $("#town_response").text("Town is not valid");
        $("#town_response").css("color", "red");
    }
    return valid;
}

function validateCP(cp, valid) {
    var re = /^[0-9]{5}$/;
    $("#cp_response").text("");
    if (re.test(cp)) {
        $("#cp").css("color", "green");
    } else {
        valid = false;
        $("#cp").css("color", "red");
        $("#cp_response").text("Postal Code is not valid");
        $("#cp_response").css("color", "red");
    }
    return valid;
}

function validateCountry(country, valid) {
    var re = /^[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1\u00e7\u00c7]+$/;
    $("#country_response").text("");
    if (re.test(country)) {
        $("#country").css("color", "green");
    } else {
        valid = false;
        $("#country").css("color", "red");
        $("#country_response").text("Country is not valid");
        $("#country_response").css("color", "red");
    }
    return valid;
}

function validate() {
    var valid = true;
    valid = validateMailAddress($("#mail").val(), valid);
    valid = validatePasword($("#psw").val(), $("#psw_repeat").val(), valid);
    valid = validateName($("#name").val(), valid);
    valid = validateSurName($("#surname").val(), valid);
    valid = validatePhone($("#phone").val(), valid);
    valid = validateAddress($("#address").val(), valid);
    valid = validateTown($("#town").val(), valid);
    valid = validateCP($("#cp").val(), valid);
    valid = validateCountry($("#country").val(), valid);
    return valid;
}

function Click() {
    if (validate() == true) {
        AlreadyRegistered();
    }
};
$("#saveRegister").bind("click", Click);