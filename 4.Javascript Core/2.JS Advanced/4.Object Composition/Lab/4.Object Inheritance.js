function processComands(commands){
    
    let map = new Map()
    let cmdExecutor = {
    create:function([objName,inherits,parent]){
        parent = parent?map.get(parent):null
        let newObj = Object.create(parent)
        map.set(objName,newObj)
        return newObj
    },
    set:function([objName,key,value]){
        let obj = map.get(objName)
        obj[key]=value
    },
    print:function([objName]){
        let obj = map.get(objName),objects =[]
        for (const key in obj) {
            objects.push(`${key}:${obj[key]}`)
        }
        console.log(objects.join(', '));
        
    }
    }
    for (const command of commands) {
        let commandParameters = command.split(' ')
        let action = commandParameters.shift()
        cmdExecutor[action](commandParameters)
    }
}