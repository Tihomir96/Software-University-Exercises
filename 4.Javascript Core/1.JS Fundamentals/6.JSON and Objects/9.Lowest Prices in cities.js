function getLowestPriceInCities (strArr){
    let obj = {}
    for (const str of strArr) {
        let [town,product,price] = str.split(/\s\|\s/g)
        price = Number(price)
        if(!obj[product]){
            obj[product] = {}
        }     
        obj[product][price]=town
        
    }
    function print(obj){
        
        for (let product in obj) {
            let output=product
            for (let town in obj[product]) {
                output+= ` -> ${town} (${obj[product][town]})`
            }
            console.log(output);
            
        }        
    }
}