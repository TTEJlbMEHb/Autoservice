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


document.addEventListener('DOMContentLoaded', () => {
    document.querySelectorAll('[data-car-id]').forEach(function (element) {
        element.addEventListener('click', function (e) {
            e.preventDefault();
            const carId = this.getAttribute('data-car-id');
            const modalId = `modal_delete_${carId}`;
            document.getElementById(modalId).style.display = 'block';
        });
    });

    document.querySelectorAll('[class="confirmCancel"]').forEach(function (element) {
        element.addEventListener('click', function () {
            const carId = this.getAttribute('data-car-id');
            const modalId = `modal_delete_${carId}`;
            document.getElementById(modalId).style.display = 'none';
        });
    });

    document.querySelectorAll('[class="close"]').forEach(function (element) {
        element.addEventListener('click', function () {
            const carId = this.getAttribute('data-car-id');
            const modalId = `modal_delete_${carId}`;
            document.getElementById(modalId).style.display = 'none';
        });
    });

    document.querySelectorAll('[id^="confirmDelete_"]').forEach(function (element) {
        element.addEventListener('click', function () {
            const carId = this.getAttribute('data-car-id');
            const modalId = `modal_delete_${carId}`;
            document.getElementById(modalId).style.display = 'none';
        });
    });

    window.addEventListener('click', function (event) {
        document.querySelectorAll('[id^="modal_delete_"]').forEach(function (modal) {
            if (event.target == modal) {
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


document.addEventListener('DOMContentLoaded', () => {
    document.getElementById('openModal').addEventListener('click', function (e) {
        e.preventDefault();
        document.getElementById('modal_delete_item').style.display = 'block';
    });

    document.getElementById('confirmCancel').addEventListener('click', function () {
        document.getElementById('modal_delete_item').style.display = 'none';
    });

    document.getElementsByClassName('close')[0].addEventListener('click', function () {
        document.getElementById('modal_delete_item').style.display = 'none';
    });

    window.addEventListener('click', function (event) {
        var modal = document.getElementById('modal_delete_item');
        if (event.target == modal) {
            modal.style.display = 'none';
        }
    });
});