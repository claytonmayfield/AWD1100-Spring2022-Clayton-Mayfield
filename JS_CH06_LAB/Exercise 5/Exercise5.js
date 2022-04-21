'use strict';
const $ = (selector) => document.querySelector(selector);
const scores = [88, 98, 77, 88, 99];
const names = ['ben', 'joel', 'judy', 'anne', 'mike'];

function displayScores() {
  for (let i = 0; i < scores.length; i++) {
    document.getElementById('result').innerHTML += `${scores[i]} <span class='ms-5'>${names[i]}</span>  <br>`;
    // alert(scores[i] + names[i]);
  }
}

function addArray() {
  const userName = document.getElementById('txtName').value;
  const userScore = document.getElementById('txtScore').value;

  let isValid = true;

  if (Number.isNaN(userScore) || (userScore < 0) || (userScore > 100) || userScore === '') {
    document.querySelector('#scoreError').classList.remove('visually-hidden');
    isValid = false;
  }
  if (userName === '') {
    document.querySelector('#nameError').classList.remove('visually-hidden');
    isValid = false;
  }
  if (isValid) {
    // working
    document.querySelector('#scoreError').classList.add('visually-hidden');
    document.querySelector('#scoreError').classList.add('visually-hidden');
    names.push(userName);
    scores.push(userScore);
    console.log('added to array');
  }
  // REad from the textBox and store in a variable when data is good

 

}
function displayResult() {
  let highest = Number.MIN_VALUE;
  let position = -1;
  for (let i = 0; i < scores.length; i++) {
    if (scores[i] > highest) {
      highest = scores[i];
      position = i;
    }
  }
  document.getElementById('highestScore').innerHTML = `${names[position]}  had the highest score of ${scores[position]}`;
}
function displayAvg() {
  let lowest = Number.MAX_VALUE;
  let position = -1;
  for (let i = 0; i < scores.length; i++) {
    if (scores[i] < lowest) {
      lowest = scores[i];
      position = i;
    }
  }
  document.getElementById('averageScore').innerHTML = `${scores[position]}  is the average score`;
}
document.addEventListener('DOMContentLoaded', () => {
  document.getElementById('btnArray').addEventListener('click', addArray);
  document.getElementById('btnScore').addEventListener('click', displayScores);
  document.getElementById('btnResult').addEventListener('click', displayResult);
  document.getElementById('btnResult').addEventListener('click', displayAvg);

});
