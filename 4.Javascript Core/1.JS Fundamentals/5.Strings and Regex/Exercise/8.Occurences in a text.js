function countStringInText(text, str) {
    str += ' '
    text = text.toLowerCase()     
    let count = 0;
    let index = text.indexOf(str);
    while (index > -1) {
      count++;
      index = text.indexOf(str, index + 1);
      let debug
    }
   console.log(count);
   
  }
  countStringInText("There was one. Therefore I bought it. I wouldn’t buy it otherwise.","there")