function snatchMeals(meals,commands){
    let mealsEaten = 0
    
    let actions = {
        Serve :() => {
            if(meals.length>0)
            console.log(`${meals.pop()} served!`)
        },
        Add: ([meal]) => {
            if(meal!=''){
                meals.unshift(meal)}
            },
        Shift: ([startIdx,endIdx]) =>{
            let isValid = startIdx && endIdx && startIdx >=0 && endIdx < meals.length && startIdx < endIdx
           
            if(isValid){
                let temp = meals[startIdx]
                meals[startIdx] = meals[endIdx]
                meals[endIdx] = temp
            }
        } ,
        Eat:()=> {
            if(meals.length>0){
                console.log(`${meals.shift()} eaten`)
                mealsEaten++
            }
        },
        Consume:([startIdx,endIdx])=>{
            let isValid = startIdx && endIdx && startIdx >=0 && endIdx < meals.length && startIdx < endIdx
            
            if(isValid){
                let portionsCount = endIdx- startIdx+1
                mealsEaten+=portionsCount
                meals.splice(startIdx,portionsCount)
                console.log(`Burp!`);                
            }
        },
        End: ()=>{
            if(meals.length>0){
                console.log(`Meals left: ${meals.join(', ')}`);            
            }
            else{
                console.log(`The food is gone`);                
            }
            console.log(`Meals eaten: ${mealsEaten}`);            
        }        
    }
    for (const commandArgs of commands) {
        let cmdParams = commandArgs.split(' ')
        let action = cmdParams.shift()
        if(actions[action]){
            actions[action](cmdParams)
            if(action==='End'){
                break
            }
        }
    }
}

//tests
let testInput1 = ['fries', 'fish', 'beer', 'chicken', 'beer', 'eggs']
let testInput2 = ['Add spaghetti','Shift 0 1','Consume 1 4','End']
snatchMeals(testInput1,testInput2)