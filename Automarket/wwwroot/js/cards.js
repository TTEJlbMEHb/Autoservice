//window.addEventListener("load", function () {
//    var cardItems = document.querySelectorAll(".card_item");
//    var maxHeight = 0;

//    cardItems.forEach(function (item) {
//        var itemHeight = item.clientHeight;
//        if (itemHeight > maxHeight) {
//            maxHeight = itemHeight;
//        }
//    });

//    cardItems.forEach(function (item) {
//        item.style.height = maxHeight + "px";
//    });
//});


document.addEventListener('DOMContentLoaded', function () {
    var deleteLinks = document.querySelectorAll('.delete_items');
    deleteLinks.forEach(function (link) {
        link.addEventListener('click', function () {
            var modalId = this.getAttribute('data-car-id');
            var modal = document.getElementById('modal_delete_' + modalId);
            modal.style.display = 'block';
        });
    });

    var closeButtons = document.querySelectorAll('.close, .confirmCancel');
    closeButtons.forEach(function (button) {
        button.addEventListener('click', function () {
            var modalId = this.getAttribute('data-car-id');
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



document.addEventListener('DOMContentLoaded', function () {
    const aboutTab = document.getElementById('about_tab');
    const detailsTab = document.getElementById('details_tab');
    const aboutContent = document.getElementById('about_content');
    const detailsContent = document.getElementById('details_content');

    aboutContent.style.display = 'block';
    detailsContent.style.display = 'none';

    aboutTab.addEventListener('click', function () {
        aboutContent.style.display = 'block';
        detailsContent.style.display = 'none';

        aboutTab.classList.add('active-tab');
        detailsTab.classList.remove('active-tab');
    });

    detailsTab.addEventListener('click', function () {
        aboutContent.style.display = 'none';
        detailsContent.style.display = 'block';

        detailsTab.classList.add('active-tab');
        aboutTab.classList.remove('active-tab');
    });
});


document.addEventListener('DOMContentLoaded', function () {
    var deleteLinks = document.querySelectorAll('.delete_item');
    deleteLinks.forEach(function (link) {
        link.addEventListener('click', function () {
            var modalId = this.getAttribute('data-account-id');
            var modal = document.getElementById('modal_delete_' + modalId);
            modal.style.display = 'block';
        });
    });

    var closeButtons = document.querySelectorAll('.modal-content .close, .modal-content .confirmCancel');
    closeButtons.forEach(function (button) {
        button.addEventListener('click', function () {
            var modalId = this.closest('.modal').getAttribute('id').replace('modal_delete_', '');
            var modal = document.getElementById('modal_delete_' + modalId);
            modal.style.display = 'none';
        });
    });

    window.addEventListener('click', function (event) {
        var modals = document.querySelectorAll('.modal-content');
        modals.forEach(function (modal) {
            if (event.target === modal) {
                modal.style.display = 'none';
            }
        });
    });
});