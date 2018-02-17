function buildAWall(crews){
    let dailyUsedConcrete = []
    let workingAtTheMoment=0
    let crewsWorked30Days=0;
   
    while(true){        
        for (let i = 0; i < crews.length; i++) {            
            if(crews[i]<30){
                workingAtTheMoment++      
                crews[i]++        
            }  
           
        }
        dailyUsedConcrete.push(workingAtTheMoment*195)      
        workingAtTheMoment=0
        crews = crews.filter(x=>x<30);  
        if(crews.length === 0){
            break
        }    
               
    }
    let totalAmountPesos = dailyUsedConcrete.reduce((a,b)=>a+b,0) * 1900
    console.log(dailyUsedConcrete.join(", "));
    console.log(totalAmountPesos+" pesos");    
}
buildAWall([21, 25, 28])
