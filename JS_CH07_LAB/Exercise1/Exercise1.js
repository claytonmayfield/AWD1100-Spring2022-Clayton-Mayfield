'use strict';
document.addEventListener('DOMContentLoaded', () => {

  // attach event listener
  document.getElementById('image1').addEventListener('mouseover', () => {
    console.log('Mouse Over');
    document.getElementById('image1').src = 'fishing3.jpeg';

  });

  // attach another event listener
  // img 2 mouse over
  document.getElementById('image2').addEventListener('mouseover', () =>{
    document.getElementById('image2').src = 'fishing4.jpeg';
  });
  // attach a third
  // img1 mouseout
  document.getElementById('image1').addEventListener('mouseout', () =>{
    console.log('Mouse Out');
    document.getElementById('image1').src = 'fishing1.jpeg';
  });
  // attach a fourth
  // img2 mouseout
  document.getElementById('image2').addEventListener('mouseout', () =>{
    document.getElementById('image2').src = 'fishing2.jpeg';
  });
});
