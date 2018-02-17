function jansNotation(arr){

    let numbers =[]
    let obj = {
        '+': (num2,num1)=>numbers.push(parseInt(num1)+parseInt(num2)),
        '-':(num2,num1)=> numbers.push(num1-num2),
        '/': (num2,num1)=> numbers.push(num1/num2),
        '*': (num2,num1)=>numbers.push(num1*num2)
    }
    for (let i = 0; i < arr.length; i++) {
        if( typeof arr[i]==='number'){
            numbers.push(arr[i])
        }else{
            if(numbers.length>1){
                let num1 = numbers.pop()
                let num2 = numbers.pop()
                obj[arr[i]](num1,num2)
            }else{
                console.log(`Error: not enough operands!`);        
                return        
            }            
        }        
    }
    if(numbers.length!==1){
        console.log("Error: too many operands!");
    }else{
        console.log(numbers.pop());        
    }
}