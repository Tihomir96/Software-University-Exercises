function airPolution(matrixParams,cmdArr){
    //Make matrix
    let matrix =[]
    for (let i = 0; i < 5; i++) {
        let stringNumbers = matrixParams[i].split(' ')
        matrix.push((stringNumbers.map(x=>Number(x))))       
     }
    //Make Obj commands

    let cmdObj = {
        breeze:(idx)=>{
            if(idx>=0 && idx <5){
                matrix[idx] = matrix[idx].map(x=>x-15<0 ? x=0  : x-=15)     
            }
        },
        gale:(idx)=>{

            idx= Number(idx)
            if(idx>=0 && idx<5){
                for (let row = 0; row < matrix.length; row++) {
                    for (let col = 0; col < matrix[row].length; col++) {
                        if(col===idx){
                            if(matrix[row][col]-20 >0){
                                matrix[row][col]-=20
                            }
                            else{
                                matrix[row][col]=0
                            }
                        }                    
                    }                
                }
            }
            
            
        },
        smog:(value)=>{
            value=Number(value)
            for (let row = 0; row < matrix.length; row++) {
                for (let col = 0; col < matrix[row].length; col++) {
                    matrix[row][col]+=value
                }
                
            }
        }
    }
    
    //Read Commands
    
    for (const commands of cmdArr) {
        let tokens =commands.split(' ')
        let cmd = tokens[0].toLowerCase()
        let number = tokens[1]
        cmdObj[cmd](number)
    
    //check for polluted areas
    let polluted = []
    for (let row = 0; row < matrix.length; row++) {

    }        for (let col = 0; col < matrix.length; col++) {
            if(matrix[row][col]>=50){
                polluted.push(`[${row}-${col}]`)
            }            
        }
        
    }
    
    if(polluted.length>0){
        console.log(`Polluted areas: ${polluted.join(', ')}`);
    }
    else{
        console.log(`No polluted areas`);
        
    }
    

}