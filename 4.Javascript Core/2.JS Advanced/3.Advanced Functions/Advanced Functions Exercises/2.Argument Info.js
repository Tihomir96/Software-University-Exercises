function result(){

    let objArgs ={}
    for (let i = 0; i < arguments.length; i++) {
        let argValue = arguments[i]
        console.log(`${typeof argValue}: ${argValue}`);
        if(!objArgs.hasOwnProperty(typeof argValue)){
            objArgs[typeof argValue] =  0        
        }
        objArgs[typeof argValue]++

    }
    let sortedArr=[]
    for (const argumentType in objArgs) {
        if (objArgs.hasOwnProperty(argumentType)) {
            const element = objArgs[argumentType];
            sortedArr.push([argumentType,element])            
        }
    }
    sortedArr = sortedArr.sort((a,b)=> b[1]-a[1])
    for (let i = 0; i < sortedArr.length; i++) {
        let element = sortedArr[i]
        let argumentType = element[0]
        let count = element[1]
        console.log(`${argumentType} = ${count}`);
        
        
    }
}
result(undefined,undefined,undefined);