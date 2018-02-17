function captureTheNums(text){

    let myRegex  = /\d+/g

    text+=''
    let result = text.match(myRegex)
  
    console.log(result.join(' '));
    
}
captureTheNums("The300 What is that?I think it’s the 3rd ","movie.Lets watch it at 22:45")