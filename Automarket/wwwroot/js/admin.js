document.addEventListener('DOMContentLoaded', function () {
    var deleteLinks = document.querySelectorAll('.delete_items');
    deleteLinks.forEach(function (link) {
        link.addEventListener('click', function () {
            var modalId = this.getAttribute('data-account-id');

            Swal.fire({
                title: "Are you sure?",
                text: "You won't be able to revert this!",
                icon: "warning",
                showCancelButton: true,
                confirmButtonColor: "#28a745",
                cancelButtonColor: "#d33",
                confirmButtonText: "Confirm",
                customClass: {
                    confirmButton: 'confirmSave',
                    cancelButton: 'confirmCancel'
                }
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = '/Admin/DeleteAccount/' + modalId;
                }
            });

            var confirmButton = document.querySelector('.confirmSave');
            var cancelButton = document.querySelector('.confirmCancel');

            if (confirmButton && cancelButton) {
                confirmButton.style.fontSize = '17px';
                cancelButton.style.fontSize = '17px';
            }
        });
    });
});


document.addEventListener('DOMContentLoaded', function () {
    var saveButton = document.getElementById('createAccountSubmit');

    if (saveButton) {
        saveButton.addEventListener('click', function (event) {
            event.preventDefault();

            Swal.fire({
                title: "Are you sure?",
                text: "You won't be able to revert this!",
                icon: "warning",
                showCancelButton: true,
                confirmButtonColor: "#28a745",
                cancelButtonColor: "#d33",
                confirmButtonText: "Confirm",
                customClass: {
                    confirmButton: 'confirmSave',
                    cancelButton: 'confirmCancel'
                }
            }).then((result) => {
                if (result.isConfirmed) {
                    document.getElementById('createAccountForm').submit();
                }
            });

            var confirmButton = document.querySelector('.confirmSave');
            var cancelButton = document.querySelector('.confirmCancel');

            if (confirmButton && cancelButton) {
                confirmButton.style.fontSize = '17px';
                cancelButton.style.fontSize = '17px';
            }
        });
    }
});



function searchUsers() {
    var input, filter, table, tr, td, i, emailTxt, idTxt;
    input = document.getElementById("emailSearch");
    filter = input.value.toUpperCase();
    table = document.getElementById("usersTable");
    tr = table.getElementsByTagName("tr");

    for (i = 0; i < tr.length; i++) {
        emailTd = tr[i].getElementsByTagName("td")[1];
        idTd = tr[i].getElementsByTagName("td")[0];

        if (emailTd && idTd) {
            emailTxt = emailTd.textContent || emailTd.innerText;
            idTxt = idTd.textContent || idTd.innerText;

            if (emailTxt.toUpperCase().indexOf(filter) > -1 || idTxt === filter) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}



document.addEventListener("DOMContentLoaded", function () {
    var adminHeader = document.getElementById("adminHeader");
    var administratorHeader = document.getElementById("administratorHeader");
    var mechanicHeader = document.getElementById("mechanicHeader");
    var userHeader = document.getElementById("userHeader");
    var allUsersHeader = document.getElementById("allUsersHeader");
    var usersTable = document.getElementById("usersTable");

    adminHeader.addEventListener("click", function () {
        filterUsersByRole("Admin");
    });

    administratorHeader.addEventListener("click", function () {
        filterUsersByRole("Administrator");
    });

    mechanicHeader.addEventListener("click", function () {
        filterUsersByRole("Mechanic");
    });

    userHeader.addEventListener("click", function () {
        filterUsersByRole("User");
    });

    allUsersHeader.addEventListener("click", function () {
        showAllUsers();
    });


    function filterUsersByRole(role) {
        var rows = usersTable.querySelectorAll(".users_info_tr");
        for (var i = 0; i < rows.length; i++) {
            var userRole = rows[i].querySelector(".user_info:nth-child(3)").textContent.trim();
            if (userRole === role) {
                rows[i].style.display = "";
            } else {
                rows[i].style.display = "none";
            }
        }
    }

    function showAllUsers() {
        var rows = usersTable.querySelectorAll(".users_info_tr");
        for (var i = 0; i < rows.length; i++) {
            rows[i].style.display = "";
        }
    }
});


document.addEventListener('DOMContentLoaded', function () {
    const usersTab = document.getElementById('usersTab');
    const servicesTab = document.getElementById('servicesTab');
    const usersContent = document.getElementById('users_content');
    const servicesContent = document.getElementById('services_content');

    usersContent.style.display = 'block';
    servicesContent.style.display = 'none';

    usersTab.addEventListener('click', function () {
        usersContent.style.display = 'block';
        servicesContent.style.display = 'none';

        usersTab.classList.add('active-tab');
        servicesTab.classList.remove('active-tab');
    });

    servicesTab.addEventListener('click', function () {
        usersContent.style.display = 'none';
        servicesContent.style.display = 'block';

        servicesTab.classList.add('active-tab');
        usersTab.classList.remove('active-tab');
    });
});
