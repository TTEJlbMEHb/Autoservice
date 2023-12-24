//function populateCountries() {
//    fetch('https://restcountries.com/v2/all')
//        .then(response => response.json())
//        .then(data => {
//            const countrySelector = document.getElementById("country");
//            data.forEach(country => {
//                const optionElement = document.createElement("option");
//                optionElement.value = country.name;
//                optionElement.textContent = country.name;
//                countrySelector.appendChild(optionElement);
//            });
//        })
//        .catch(error => {
//            console.error('Country list error', error);
//        });
//}

//function getCitiesByCountry(country) {
//    const apiKey = '777cf9e7382fe65a5d7264d9a5b6054b';

//    fetch(`https://api.openweathermap.org/data/2.5/find?q=${country}&type=like&mode=json&appid=${apiKey}`)
//        .then(response => response.json())
//        .then(data => {
//            const citySelector = document.getElementById("settlement");
//            citySelector.innerHTML = "<option value=''>Select the city</option>";

//            data.list.forEach(city => {
//                const optionElement = document.createElement("option");
//                optionElement.value = city.name;
//                optionElement.textContent = city.name;
//                citySelector.appendChild(optionElement);
//            });
//        })
//        .catch(error => {
//            console.error('Error fetching city list:', error);
//        });
//}

//document.addEventListener("DOMContentLoaded", function () {
//    const countrySelector = document.getElementById("country");
//    const settlementSelector = document.getElementById("settlement");

//    countrySelector.addEventListener("change", function () {
//        const selectedCountry = countrySelector.value;
//        if (selectedCountry) {
//            getCitiesByCountry(selectedCountry);
//        }
//    });

//    populateCountries();
//});


document.addEventListener("DOMContentLoaded", function () {
    const openShareButton = document.getElementById("openShare");
    const modal = document.getElementById("myModal");
    const closeModalButton = document.getElementById("closeModalButton");
    const invitationLink = document.getElementById("invitationLink");
    const copyLinkButton = document.getElementById("copyLinkButton");
    const socialMediaIcons = document.querySelectorAll(".socialmedia_icon");
    const link = window.location.origin + "/Home/Index";
    const customAlert = document.getElementById("customAlert");
    const alertText = document.getElementById("alertText");

    openShareButton.addEventListener("click", () => {
        modal.style.display = "block";
        invitationLink.value = window.location.origin + "/Home/Index";
    });

    closeModalButton.addEventListener("click", () => {
        modal.style.display = "none";
    });

    copyLinkButton.addEventListener("click", () => {
        const link = window.location.origin + "/Home/Index";
        invitationLink.value = link;
        invitationLink.select();
        document.execCommand("copy");

        const copyAlert = document.getElementById("copyAlert");
        copyAlert.style.display = "block";

        const closeCopyAlert = document.getElementById("closeCopyAlert");
        closeCopyAlert.addEventListener("click", () => {
            copyAlert.style.animation = "fadeOut 0.4s ease-in-out both";
            setTimeout(() => {
                copyAlert.style.display = "none";
                copyAlert.style.animation = "";
            }, 400);
        });

        setTimeout(() => {
            copyAlert.style.animation = "fadeOut 0.4s ease-in-out both";
            setTimeout(() => {
                copyAlert.style.display = "none";
                copyAlert.style.animation = "";
            }, 400);
        }, 3000);
    });


    window.addEventListener("click", (event) => {
        if (event.target === modal) {
            modal.style.display = "none";
        }
    });

    socialMediaIcons.forEach((icon) => {
        icon.addEventListener("click", () => {
            const socialMedia = icon.getAttribute("get_socialmedia");
            let socialMediaUrl = "";

            switch (socialMedia) {
                case "telegram":
                    socialMediaUrl = `https://t.me/share/url?url=${link}`;
                    break;
                case "instagram":
                    socialMediaUrl = `https://www.instagram.com/?url=${link}`;
                    break;
                case "twitter":
                    socialMediaUrl = `https://twitter.com/intent/tweet?url=${link}`;
                    break;
                case "facebook":
                    socialMediaUrl = `https://www.facebook.com/sharer/sharer.php?u=${encodeURIComponent({ link })}`;
                    break;
                case "viber":
                    socialMediaUrl = `viber://forward?text=${encodeURIComponent(link)}`;
                    break;
                case "whatsapp":
                    socialMediaUrl = `https://wa.me/?text='${encodeURIComponent(link)}`;
                    break;
            }

            if (socialMediaUrl) {
                window.open(socialMediaUrl, "blank");
            }
        });
    });
});


document.addEventListener('DOMContentLoaded', function () {
    var deleteLinks = document.querySelectorAll('.delete_account');
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

