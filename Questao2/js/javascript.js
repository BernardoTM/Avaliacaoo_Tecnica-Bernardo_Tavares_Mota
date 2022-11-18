let margin = 0;
const list = document.querySelector('.imagesRow-list');


const left = document.querySelector('.movieRow-right');
left.addEventListener('click', () => {
    margin -= 200;
    if ((window.innerWidth - 1700) > margin) {
        margin = window.innerWidth - 1650;
    }
    list.style.marginLeft = margin + "px";

});

const right = document.querySelector('.movieRow-left');
right.addEventListener('click', () => {
    margin += 200;
    if (margin > 0) {
        margin = 0;
    }
    list.style.marginLeft = margin + "px";


});    
