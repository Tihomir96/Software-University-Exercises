function bitcoinMining(strArr){
    strArr = strArr.map(x=>parseInt(x))
    let bitcoinPrice = 11949.16 
    let gramOfGoldPrice = 67.51 
    let goldPerDay;
    let money=0
    let dayOfFirstBtc=0
    let btcBought = 0
    
    for (let i = 1; i <= strArr.length; i++) {
        if(i%3===0){
            goldPerDay += Number(strArr[i-1]) - Number((strArr[i-1] *0.3))
            money+= goldPerDay * gramOfGoldPrice
            if(money>=bitcoinPrice){
                money-=bitcoinPrice
                dayOfFirstBtc=i-1
                btcBought++
            }
        }
        else{
            goldPerDay += Number(strArr[i-1])
            money+=goldPerDay * gramOfGoldPrice
            if(money>=bitcoinPrice){
                money-=bitcoinPrice
                dayOfFirstBtc=i-1
                btcBought++
            }
        }        
    }
    console.log(btcBought);
    console.log(dayOfFirstBtc);
    console.log(money);
    
    
    
    

    
}
bitcoinMining([100, 200, 300])