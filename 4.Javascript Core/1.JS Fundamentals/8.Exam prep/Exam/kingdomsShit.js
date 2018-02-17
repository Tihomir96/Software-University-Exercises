function kingdoms(arrKingdoms, kingdomsBattles) {
    let kingdoms = {}
    //store kingdoms data
    for (let obj of arrKingdoms) {
        if (!kingdoms[obj.kingdom]) {
            kingdoms[obj.kingdom] = {};
        }
        if (!kingdoms[obj.kingdom][obj.general]) {
            kingdoms[obj.kingdom][obj.general] = {army:0,wins:0,looses:0};
        }
        kingdoms[obj.kingdom][obj.general].army += obj.army;
    }
console.log(kingdoms);

    //batles
//     let battles = []
//     for (let i = 0; i < kingdomsBattles.length; i++) {
//         for (let j = 0; j < 4; j++) {
//             battles.push(kingdomsBattles[i][j])
//         }
//     }
//     let wins = []
//     let looses = []
//     for (let i = 0; i < battles.length; i += 4) {
//         let attackingKingdom = battles[i]
//         let attackingGeneral = battles[i + 1]
//         let defendingKingdom = battles[i + 2]
//         let defendingGeneral = battles[i + 3]

//         if (attackingKingdom !== defendingKingdom) {
//             for (const kingdom of Object.keys(kingdoms)) {

//                 if (kingdom === attackingKingdom) {

//                     for (const def of Object.keys(kingdoms)) {
//                         if (def === defendingKingdom) {
//                             //atacker wins
//                             if (kingdoms[attackingKingdom][attackingGeneral] > kingdoms[defendingKingdom][defendingGeneral]) {
//                                 let defeatedPercentage = kingdoms[defendingKingdom][defendingGeneral] * 0.1
//                                 let winnerPercentage = kingdoms[attackingKingdom][attackingGeneral]* 0.1
                                
//                                 kingdoms[defendingKingdom][defendingGeneral] -= defeatedPercentage
//                                 kingdoms[attackingKingdom][attackingGeneral] += defeatedPercentage

//                                 wins.push({kingdom : attackingKingdom, general: attackingGeneral,army:kingdoms[attackingKingdom][attackingGeneral]})
//                                 looses.push({kingdom : defendingKingdom, general: defendingGeneral,army:kingdoms[defendingKingdom][defendingGeneral]})
//                             }
//                             //deffender wins
//                              else if(kingdoms[attackingKingdom][attackingGeneral] < kingdoms[defendingKingdom][defendingGeneral]) {
//                                 let defeatedPercentage = kingdoms[attackingKingdom][attackingGeneral] * 0.1
//                                 let winnerPercentage = kingdoms[defendingKingdom][defendingGeneral]* 0.1
                          
//                                 kingdoms[defendingKingdom][defendingGeneral] += winnerPercentage
//                                 kingdoms[attackingKingdom][attackingGeneral] -= defeatedPercentage
                          
//                                 wins.push({kingdom :defendingKingdom, general: defendingGeneral,army:kingdoms[defendingKingdom][defendingGeneral]})
//                                 looses.push({kingdom : attackingKingdom, general: attackingGeneral,army:kingdoms[attackingKingdom][attackingGeneral]})
//                             }
//                             //draw nothing happens
//                             else{
//                                 continue
//                             }

//                         }
//                     }
//                 }
//             }
//         }

//     }
// console.log(kingdoms);
    
    

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