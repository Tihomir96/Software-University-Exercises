function rotateArr(arr){
    let n = arr.pop()
    let rotations = n % arr.length
    let splicedArr = arr.splice(arr.length - rotations,arr.length)
    
    let newArr = splicedArr

    for (let i = 0; i < arr.length; i++) {
        newArr.push(arr[i])      
    }     
    
   console.log(newArr.join(' '));
}
rotateArr(['Banana', 'Orange', 'Coconut', 'Apple', 15])