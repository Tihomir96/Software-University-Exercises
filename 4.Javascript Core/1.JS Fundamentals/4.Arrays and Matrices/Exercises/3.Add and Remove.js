function addAndRemove(input){
    let arr = []
    let counter =0
    for (let i = 0; i < input.length; i++) {
        if(input[i]==='add'){
            arr.push(++counter)
        }else{
            arr.pop()
            counter++
        }       
    }
    if(arr.length===0){
        console.log('Empty')
    }else{
        for (let i = 0; i < arr.length; i++) {
            console.log(arr[i])            
        }
    }
}
addAndRemove(['add','add','remove','add','add'])