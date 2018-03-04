
(function solve(){
Array.prototype.last = function (){
    return this[this.length-1]
}
Array.prototype.skip = function(n){
    if(n>=this.length){
        throw new Error ("Out of range")
    }
    let newArr =[]
    for (let i = n; i < this.length; i++) {
        newArr.push(this[i])
    }
    return newArr
}
Array.prototype.take = function(n){
  let newArr = []
    for (let i = 0; i < n; i++) {
    newArr.push(this[i])
  }
   return newArr
}
Array.prototype.sum = function(){
    let sum = 0
    for (let i = 0; i < this.length; i++) {
        sum+=this[i]
    }
    return sum
}
Array.prototype.average = function(){
    let sum = 0
    for (let i = 0; i < this.length; i++) {
        sum+=this[i]
    }
    return sum /this.length
}
})()