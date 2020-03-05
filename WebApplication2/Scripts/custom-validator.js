
$(document).ready(function () {
    $("#registerFormId").validate({
        rules: {
            EmpName: {
                required: true
            },
            EmpDepartment: {
                required: true,
                minlength: 2
            },
            EmpPhone: {
                required: true,
                maxlength: 10
            },
            EmpAddress: {
                required: true
            },
            EmpEmailId: {
                required: true,
                email: true
            }
        },
        messages: {
            EmpName: {
                required: "Please enter Employee Name"
            },
            EmpDepartment: {
                required: "Please enter Employee Department"
            },
            EmpPhone: {
                required: "Please enter Phone Number",
                maxlength: "Maximum 10 Digit allowed"
            },
            EmpAddress: {
                required: "Please provide a password"
            },
            EmpEmailId: {
                required: "Please provide a Email id",
                email: "Please enter a valid email address"
            }
        }
    });