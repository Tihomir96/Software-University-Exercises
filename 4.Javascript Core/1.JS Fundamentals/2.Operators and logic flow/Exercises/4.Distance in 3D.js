function distanceBetweenTwoPoints(arr){ 
    let x1 = arr[0]
    let y1 = arr[1]
    let z1 = arr[2]
    let x2 = arr[3]
    let y2 = arr[4]
    let z2 = arr[5]

   console.log( Math.sqrt(((x1-x2)*(x1-x2))+((y1-y2)*(y1-y2))+((z1-z2)*(z1-z2))));
   
}
distanceBetweenTwoPoints([1, 1, 0, 5, 4, 0])