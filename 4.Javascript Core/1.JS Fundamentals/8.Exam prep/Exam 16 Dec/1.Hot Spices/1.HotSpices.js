function hotSpices(number){
    let startingYield = Number(number)
    let days =0
    let totalAmount = 0
    let forTheHungryWorkers = 26
    if(startingYield<100){
        console.log(0);
        console.log(0);    
        return    
    }
    while(startingYield>=100){
        days++
        totalAmount+=startingYield
        totalAmount-=forTheHungryWorkers
        startingYield-=10
    }
    totalAmount-=forTheHungryWorkers
    console.log(days);
    console.log(totalAmount);
    
    
}
