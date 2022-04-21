'use strict';

function switchLabel() {
  // if one is checked
  // else do something else
  // console.log('fahToCei');
  if (document.getElementById('fahToCei').checked) {
    document.getElementById('degree_label_1').innerHTML = 'Enter F degrees';
    document.getElementById('degree_label_2').innerHTML = ' degrees celsius';
  } else {
    document.getElementById('degree_label_1').innerHTML = 'Enter C degrees';
    document.getElementById('degree_label_2').innerHTML = ' degrees fahrenheit';
  }
}

document.addEventListener('DOMContentLoaded', () => {
  document.getElementById('convert').addEventListener('click', () => {
    const degreesEntered = document.getElementById('degrees_entered').value; // reads from a textbox and stores in a variable
    if (isNaN(degreesEntered)) {
      document.getElementById('invalid').innerHTML = 'You must enter a valid number for degrees';
    } else {
      if (document.getElementById('fahToCei').checked) {
        // how do we calc f to c?
        const celsius = ((degreesEntered - 32) * 5) / 9;
        // output celsius
        document.getElementById('degrees_computed').value = celsius.toFixed(1);
        // let degrees_computed = document.getElementById('degrees_computed').value;
      } else {
        const degreesEntered = document.getElementById('degrees_entered').value; // reads from a textbox and stores in a variable
        // calc c to f
        const fahrenheit = (degreesEntered * 9) / 5 + 32;
        // output
        document.getElementById('degrees_computed').value = fahrenheit.toFixed(1);
      }
    }
  });

  // 2 event handlers for click events on the radio buttons
  document.getElementById('fahToCei').addEventListener('click', switchLabel);
  document.getElementById('ceiToFah').addEventListener('click', switchLabel);
});
