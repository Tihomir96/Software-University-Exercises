function getStoreCatalogue(strArr){    
    let catalog = new Map
    let upperCaseLetters = new Set
    for (const str of strArr) {
        let[product,price] = str.split(' : ')
        catalog.set(product,price)
        let fisrtLetter = product[0].toUpperCase()
     
        if(!upperCaseLetters[fisrtLetter]){
            upperCaseLetters.add(fisrtLetter)
        }
    }
        let sortedLetters = Array.from(upperCaseLetters.values()).sort()
        for (let letter of sortedLetters) {
            console.log(letter)
            for (const key of [...catalog.keys()].sort()) {
                if(key[0].toUpperCase()===letter){
                    console.log(`  ${key}: ${catalog.get(key)}`);
                }
                
            }
        }
    }
        
