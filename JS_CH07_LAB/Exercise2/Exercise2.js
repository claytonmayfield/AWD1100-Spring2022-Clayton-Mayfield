'use strict';
const $ = (selector) => document.querySelector(selector);

let timer;
const btnPause = document.querySelector('#btnPause');
const btnStart = document.querySelector('#btnStart');


document.addEventListener('DOMContentLoaded', () => {
  const cap = $('#cap'); // the h2 elements for the caption
  const mainImage = $('#main_image'); // the img element for the show
  // get all the <a> tags in the ul element
  const links = $('#image_list').querySelectorAll('a');
  // process image links
  const imageCache = [];
  let image = null;

  for (let link of links) {
    // preload image and copy title poroperties
    image = new Image();
    image.src = link.href;
    image.alt = link.title;
    // add image to array
    imageCache[imageCache.length] = image;
  }


 
  document.getElementById('btnStart').addEventListener('click', () => {
    // start slide show
    let imageCounter = 0;

    timer = setInterval(() => {
    // calc the index for the current img
    imageCounter = (imageCounter + 1) % imageCache.length;
    // get img object from array
        image = imageCache[imageCounter];
        // set html img and h2 elements with values from images object
        mainImage.src = image.src;
        mainImage.alt = image.alt;
        cap.textContent = image.alt;
        btnPause.disabled = false;
        btnStart.disabled = true;
      }, 2000); // 2 second interval
    }); //end click event

   document.getElementById('btnPause').addEventListener('click', () => { 
     clearInterval(timer);
     btnPause.disabled = true;
     btnStart.disabled = false;

   });

}); //end DOMContentLoaded