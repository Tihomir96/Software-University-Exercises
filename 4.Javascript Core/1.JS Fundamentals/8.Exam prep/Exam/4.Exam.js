function kingdoms(arrKingdoms,kingdomsBattles){
    
    let kingdoms = []
    for (const kingdomFromArr of arrKingdoms) {
        if(!kingdoms[kingdomFromArr.kingdom]){
            kingdoms.push(kingdomFromArr.kingdom) 
            kingdoms[kingdomFromArr.kingdom] = [] 
            kingdoms[kingdomFromArr.kingdom].push({general:kingdomFromArr.general,army:kingdomFromArr.army})

        }else{
           if(!kingdoms[kingdomFromArr.kingdom][kingdomFromArr.general]) {
               
               kingdoms[kingdomFromArr.kingdom].push({general:kingdomFromArr.general,army:kingdomFromArr.army})

           }else{
            console.log(kingdoms[kingdomFromArr.kingdom][kingdomFromArr.general]);
              
            
           }

            

        }
    }
    
   

    
    
}
kingdoms([ { kingdom: "Maiden Way", general: "Merek", army: 5000 },
{ kingdom: "Stonegate", general: "Ulric", army: 4900 },
{ kingdom: "Stonegate", general: "Doran", army: 70000 },
{ kingdom: "YorkenShire", general: "Quinn", army: 0 },
{ kingdom: "YorkenShire", general: "Quinn", army: 2000 },
{ kingdom: "Maiden Way", general: "Berinon", army: 100000 } ],
[ ["YorkenShire", "Quinn", "Stonegate", "Ulric"],
["Stonegate", "Ulric", "Stonegate", "Doran"],
["Stonegate", "Doran", "Maiden Way", "Merek"],
["Stonegate", "Ulric", "Maiden Way", "Merek"],
["Maiden Way", "Berinon", "Stonegate", "Ulric"] ]
)