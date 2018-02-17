function lost(keyword,stringForRegex){
    let messageRegex = new RegExp(`(?:${keyword})(.+)(?:${keyword})`);
    let northRegex =  /(?:north)(?:\D*|\s)*(\d{2})(?:\w|\s)*(,)(?:\D*|\s)*(\d{6})/ig
    let northRegex2 =  /(?:north)(?:\D*|\s)*(\d{2})(?:\w|\s)*(,)(?:\D*|\s)*(\d{6})/i
    let eastRegex = /(?:east)(?:\D*|\s)*(\d{2})(?:\w|\s)*(,)(?:\D*|\s)*(\d{6})/ig
    let eastRegex2 = /(?:east)(?:\D*|\s)*(\d{2})(?:\w|\s)*(,)(?:\D*|\s)*(\d{6})/i
    let message = stringForRegex.match(messageRegex)[1]
    let northCords = stringForRegex.match(northRegex)  
    let eastCords = stringForRegex.match(eastRegex)  
    let e = eastCords[eastCords.length - 1].match(eastRegex2)
    let m = northCords[northCords.length - 1].match(northRegex2);
    let result = `${m[1]}.${m[3]} N\n`
    result += `${e[1]}.${e[3]} E\n`
    result+=`Message: ${message}`
    console.log(result);
    

    
}
let testInp1= "4ds"
let testInp2 = "eaSt 19,432567noRt north east 53,123456north 43,3213454dsNot all those who wander are lost.4dsnorth 47,874532"
lost(testInp1,testInp2)


