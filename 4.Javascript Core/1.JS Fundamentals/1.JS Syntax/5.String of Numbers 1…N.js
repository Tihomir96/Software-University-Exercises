

function stringToNumbers(n){
    let string = ""
    let number = parseInt(n)
    for(let i =1;i<=number;i++){
    string+=+i
}
return string
}


console.log(stringToNumbers(5))