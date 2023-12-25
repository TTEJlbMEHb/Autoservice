function searchItems() {
    var input, filter, div, item, i, txtValue;
    input = document.getElementById("itemsSearch");
    filter = input.value.toUpperCase();
    div = document.getElementsByClassName("car_consumables")[0];
    item = div.getElementsByClassName("card_item");
    var noItemsFound = document.getElementById("noItemsFound");

    // За замовчуванням припускаємо, що нічого не знайдено
    var nothingFound = true;

    for (i = 0; i < item.length; i++) {
        txtValue = item[i].querySelector(".item_name").textContent || item[i].querySelector(".item_name").innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            item[i].style.display = "";
            nothingFound = false; // Знайдено щось, змінюємо флаг
        } else {
            item[i].style.display = "none";
        }
    }

    // Відображаємо повідомлення про нічого не знайдено або приховуємо його
    noItemsFound.style.display = nothingFound ? "block" : "none";
}
