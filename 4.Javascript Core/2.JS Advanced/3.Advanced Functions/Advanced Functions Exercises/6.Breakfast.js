function breakfast () {
   let robot = {
       protein : 0,
       carbohydrate:0,
       fat:0,
       flavour:0
   } 
   let products = {
       apple:{
           carbohydrate:1,
           flavour:2
       },
       coke:{
           carbohydrate:10,
           flavour:20
       },
       burger:{
           carbohydrate:5,
           fat:7,
           flavour:3
       },
       omelet:{
           protein:5,
           fat:1,
           flavour:1
       },
       cheverme:{
           protein:10,
           carbohydrate:10,
           fat:10,
           flavour:10
       }
       
   }
   return function (inputStr) {
       let input = inputStr.split(' ')
       let command = input[0]
       if(command==='restock'){
           let microElement = input[1]
           let quantity = Number(input[2])
           robot[microElement]+=quantity
           return'Success'
       }else if(command ==='report'){
        return`protein=${robot.protein} carbohydrate=${robot.carbohydrate} fat=${robot.fat} flavour=${robot.flavour}`
       }else if(command==='prepare'){
            let selectedProduct = input[1]
            let selectedProductQuantity = Number(input[2])
            let currentProductStats =products[selectedProduct]
            
            let canProductBeCooked =true
            for (const microElement in currentProductStats) {
                if (currentProductStats.hasOwnProperty(microElement)) {
                    const microElementQuantity = currentProductStats[microElement];
                    if(robot[microElement]<microElementQuantity*selectedProductQuantity){
                         canProductBeCooked=false
                         return `Error: not enough ${microElement} in stock`
                         break;
                    }       
                }
            }
            if(canProductBeCooked){
                for (const microElement in currentProductStats) {
                    if (currentProductStats.hasOwnProperty(microElement)) {
                        const microElementQuantity = currentProductStats[microElement];
                        if(robot[microElement]-=microElementQuantity*selectedProductQuantity){
                        }       
                    }
                }
                return 'Success'                
            }
        }
   }
}