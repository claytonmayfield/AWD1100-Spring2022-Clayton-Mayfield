'use strict';
document.addEventListener('DOMContentLoaded', () =>{




//attach event listener to the buttons
document.getElementById('btnsumbit').addEventListener('click', (evt) =>{
evt.preventDefault();
    const email = document.getElementById('email').value;
    const confrimEmail = document.getElementById('confrim').value;
    const firstName = document.getElementById('firstName0').value;

if(email === ' '){
    document.getElementById('emailError').classList.remove('visually-hidden');
} else {
    document.querySelector('#emailError').classList.add('visually-hidden');
}

if(confirmError != email){
    document.querySelector('#confirmError').classList.remove('visually-hidden');
} else {
    document.querySelector('#confirmError').classList.add('visually-hidden');
}


if (firstName === '') {
    document.querySelector('#firstNameError').classList.remove('visually-hidden');
} else {
    document.querySelector(firstNameError).classList.add('visually-hidden');
}


if
});







});