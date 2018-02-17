function isOddorEven(num){
    if(Math.abs(num%2)===0){
        return 'even'
    }
    else if(Math.abs(num%2)===1){
        return 'odd'
    }
    else{
        return 'invalid'
    }
}
