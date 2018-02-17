function cookingBynums(arr){
    let num = arr[0]
    let operations = {
        chop:(number)=>number/2,
        dice : (number)=> Math.sqrt(number),
        spice : (number)=> ++number,
        bake :(number)=> number*3,
        fillet : (number)=>number *0.8
    }

    for (let i = 1; i < arr.length; i++) {
        
        num = operations[arr[i]](num)
        console.log(num)
       }
}
cookingBynums([32,'chop','chop','chop','chop'])