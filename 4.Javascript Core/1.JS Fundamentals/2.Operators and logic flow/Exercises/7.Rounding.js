function rounding(arr){
    let num = arr[0]
    let roundingTo = arr[1]
    let rounder =1;

    for(let i =0; i<roundingTo;i++){
        rounder*=10
    }

    let number = Math.round((num*rounder))/rounder
    return number
}
console.log(rounding([10.54332423428523523523, 10]))