function main(input){
    let delimeter= input.pop();
    let result = input[0]

    for (let i = 1; i < input.length; i++) {
        
        result +=delimeter +input[i]
    }
    console.log(result); 
}   
