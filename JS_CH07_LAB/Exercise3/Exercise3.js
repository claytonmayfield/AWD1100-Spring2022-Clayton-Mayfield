'use strict';
document.addEventListener('DOMContentLoaded', () => {
  const img3 = new Image();
  img3.src = 'fishing3.jpeg';

  const img4 = new Image();
  img4.src = 'fishing4.jpg';

  //let timer;
  let counter = 1;

  const swapImgOneIn = () => {
    console.log('Mouse Over');
    document.getElementById('image1').src = 'fishing3.jpeg';
  };

  const swapImgOneOut = () => {
    console.log('Mouse Out');
    document.getElementById('image1').src = 'fishing1.jpeg';
  };
  const swapImgTwoIn = () => {
    document.getElementById('image2').src = 'fishing4.jpeg';
  };
  const swapImgTwoOut = () => {
    document.getElementById('image2').src = 'fishing2.jpeg';
  };
  // attach event listener
  document.getElementById('image1').addEventListener('mouseover', swapImgOneIn);
  setTimeout(swapImgOneIn, 1000);
  setTimeout(swapImgOneOut, 2000);

  // attach another event listener
  // img 2 mouse over
  document.getElementById('image2').addEventListener('mouseover', swapImgTwoIn);
  setTimeout(swapImgTwoIn, 1000);
  setTimeout(swapImgTwoOut, 2000);
  // attach a third
  // img1 mouseout 
  document.getElementById('image1').addEventListener('mouseout', swapImgOneOut);
  // attach a fourth
  // img2 mouseout
  document.getElementById('image2').addEventListener('mouseout', swapImgTwoOut);
});
