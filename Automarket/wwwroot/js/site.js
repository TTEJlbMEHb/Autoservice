document.addEventListener('DOMContentLoaded', () => {
    const header = document.querySelector('.header');

    header.style.animation = 'fadeInHeader 0.5s ease-in-out forwards';

    setTimeout(() => {
        header.style.animation = 'none';
    }, 500);
});

const header = document.querySelector('.header');
let lastScrollPosition = window.pageYOffset;
let isHeaderVisible = true;

function handleScroll() {
    const currentScrollPosition = window.pageYOffset;

    if (currentScrollPosition < lastScrollPosition) {
        if (!isHeaderVisible) {
            header.classList.remove('hidden');
            isHeaderVisible = true;
        }
    } else {
        if (isHeaderVisible) {
            header.classList.add('hidden');
            isHeaderVisible = false;
        }
    }

    lastScrollPosition = currentScrollPosition;
}

window.addEventListener('scroll', handleScroll);


const showModalButton = document.getElementById("showModalButton");
const modal = document.getElementById("modal");
const closeButton = document.querySelector(".close_button");
const body = document.body;

showModalButton.addEventListener("click", () => {
    modal.style.display = "block";
    body.style.overflow = "hidden";
});

closeButton.addEventListener("click", () => {
    modal.style.display = "none";
    body.style.overflow = "auto";
});

window.addEventListener("click", (event) => {
    if (event.target === modal) {
        modal.style.display = "none";
        body.style.overflow = "auto";
    }
});


document.addEventListener("DOMContentLoaded", function () {
    const currentDate = new Date();
    currentDate.setHours(currentDate.getHours() + 3);
    const formattedDate = currentDate.toISOString().split('T')[0];
    document.getElementById('date').value = formattedDate;
});



let inputPhone = document.getElementById("inputPhone");
inputPhone.oninput = () => phoneMask(inputPhone)
function phoneMask(inputEl) {
    let patStringArr = "+38(___)___-__-__".split('');
    let arrPush = [3, 4, 5, 7, 8, 9, 11, 12, 14, 15]
    let val = inputEl.value;
    let arr = val.replace(/\D+/g, "").split('').splice(2);
    let n;
    let ni;
    arr.forEach((s, i) => {
        n = arrPush[i];
        patStringArr[n] = s
        ni = i
    });
    arr.length < 10 ? inputEl.style.color = 'gray' : inputEl.style.color = 'black';
    inputEl.value = patStringArr.join('');
    n ? inputEl.setSelectionRange(n + 2, n + 2) : inputEl.setSelectionRange(17, 17)
}


