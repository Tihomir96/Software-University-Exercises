function bitcoinMining(strArr){
    strArr = strArr.map(x=>Number(x))
    let bitcoinPrice = 11949.16 
    let gramOfGoldPrice = 67.51 
    let goldPerDay=0.0
    let money=0.0
    let dayOfFirstBtc=0
    let btcBought = 0
    
    for (let i = 1; i <= strArr.length; i++) {
        if(i%3===0){
            goldPerDay = Number(strArr[i-1]) - Number((strArr[i-1] *0.3))
            money+= goldPerDay * gramOfGoldPrice
            while(money>=bitcoinPrice){
                money-=bitcoinPrice
                if(btcBought===0){
                    dayOfFirstBtc=i
                }
                btcBought++
            }
        }
        else{
            goldPerDay = Number(strArr[i-1])
            money+=goldPerDay * gramOfGoldPrice
            while(money>=bitcoinPrice){
                money-=bitcoinPrice
                if(btcBought===0){
                    dayOfFirstBtc=i
                }
                btcBought++
            }
        }        
    }
    console.log(`Bought bitcoins: ${btcBought}`);
    if(dayOfFirstBtc!==0){
        console.log(`Day of the first purchased bitcoin: ${dayOfFirstBtc}`);
        console.log(`Left money: ${(Math.round(money*100)/100).toFixed(2)} lv.`)        
    }
    else{
        console.log(`Left money: ${(Math.round(money*100)/100).toFixed(2)} lv.`)

    }
    
}
bitcoinMining([3124.15
    ,504.212
    ,2511.124])