function sortingArr(arr){
    let newArr=  []
    newArr.push(arr[0])
    for (let i = 1; i < arr.length; i++) {
   let num1 = newArr[newArr.length-1]
   let num2 = arr[i]
        if(num1<=num2){
            newArr.push(num2)
        }
        
    }
    console.log(newArr.join('\r\n'))
}
sortingArr([1,3,8,4,10,12,3,2,24])