function letterCounter(input, letter){
    let counter = 0;
    for(let atmletter of input){     
        if(atmletter==letter){
            counter++
        }        
    }
    console.log(counter)   
}
letterCounter('hello','l')