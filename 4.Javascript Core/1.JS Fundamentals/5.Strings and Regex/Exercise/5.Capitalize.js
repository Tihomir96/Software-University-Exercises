function capitalizer(str){
    let capitalized =''
    str = str.toLowerCase().split(' ')
    let debug
   for (let i = 0; i < str.length; i++) {
    let firstChar = str[i].substring(0,1).toUpperCase()
    let word = str[i].substr(1)
    capitalized += firstChar+ word +' '
   }
 
  console.log(capitalized);
   
}
     