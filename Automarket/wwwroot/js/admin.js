document.addEventListener('DOMContentLoaded', function () {
    var deleteLinks = document.querySelectorAll('.delete_items');
    deleteLinks.forEach(function (link) {
        link.addEventListener('click', function () {
            var modalId = this.getAttribute('data-account-id');
            var modal = document.getElementById('modal_delete_' + modalId);
            modal.style.display = 'block';
        });
    });

    var closeButtons = document.querySelectorAll('.close, .confirmCancel');
    closeButtons.forEach(function (button) {
        button.addEventListener('click', function () {
            var modalId = this.getAttribute('data-account-id');
            var modal = document.getElementById('modal_delete_' + modalId);
            modal.style.display = 'none';
        });
    });

    window.addEventListener('click', function (event) {
        var modals = document.querySelectorAll('.modal');
        modals.forEach(function (modal) {
            if (event.target === modal) {
                modal.style.display = 'none';
            }
        });
    });
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
