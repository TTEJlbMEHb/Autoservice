document.addEventListener('DOMContentLoaded', () => {
    document.getElementById('openModal').addEventListener('click', function (e) {
        e.preventDefault();
        document.getElementById('modal_save').style.display = 'block';
    });

    document.getElementById('confirmCancel').addEventListener('click', function () {
        document.getElementById('modal_save').style.display = 'none';
    });

    document.getElementsByClassName('close')[0].addEventListener('click', function () {
        document.getElementById('modal_save').style.display = 'none';
    });

    window.addEventListener('click', function (event) {
        var modal = document.getElementById('modal_save');
        if (event.target == modal) {
            modal.style.display = 'none';
        }
    });

    document.getElementById('confirmSave').addEventListener('click', function () {
        document.getElementById('myForm').submit();
    });
});
