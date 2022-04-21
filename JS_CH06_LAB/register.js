/* eslint-disable strict */
const $ = (selector) => document.querySelector(selector);

const displayErrorMsgs = (msgs) => {
  const ul = document.createElement('ul');
  ul.classList.add('messages');

  for (const msg of msgs) {
    const li = document.createElement('li');
    const text = document.createTextNode(msg);
    li.appendChild(text);
    ul.appendChild(li);
  }
  // adds a new ul to the page if it's never been added to the page
  const node = $('ul');
  if (node === null) {
    const form = $('form');
    form.parentNode.insertBefore(ul, form);
  } else {
    node.parentNode.replaceChild(ul, node);
  }
};

const processEntries = () => {
  const email = $('#email_address');
  const phone = $('#phone');
  const country = $('#country');
  const terms = $('#terms');
  const comments = $('#comments');
  const msgs = [];

  if (email.value === '') {
    msgs[msgs.length] = 'Please enter an email address.';
  }
  if (phone.value === '') {
    msgs[msgs.length] = 'Please enter a mobile phone number.';
  }
  if (country.value === '') {
    msgs[msgs.length] = 'Please select a country.';
  }
  if (!terms.checked) {
    msgs[msgs.length] = 'You must agree to the terms of service.';
  }
  if (comments.value === '') {
    msgs[msgs.length] = 'Please add your comments.';
  }
  if (msgs.length === 0) {
    $('form').submit();
  } else {
    displayErrorMsgs(msgs);
  }
};

const resetForm = () => {
  $('form').reset();
  $('ul').remove();
  $('#phone').focus();
};

document.addEventListener('DOMContentLoaded', () => {
  $('#Register').addEventListener('click', processEntries);
  $('#reset_form').addEventListener('click', resetForm);
  $('#email_address').focus();
});
