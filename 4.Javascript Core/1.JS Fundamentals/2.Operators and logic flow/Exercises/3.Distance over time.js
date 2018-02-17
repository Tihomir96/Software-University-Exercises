function distOverTime(arr){
    let v1 = arr[0]
    let v2 = arr[1]
    let time = arr[2]
    let dist1 = v1 * (time/3600)
    let dist2 = v2 * (time/3600)
    let distBetween = Math.abs(dist1-dist2)*1000
    return distBetween
}
distOverTime([5, -5, 40])