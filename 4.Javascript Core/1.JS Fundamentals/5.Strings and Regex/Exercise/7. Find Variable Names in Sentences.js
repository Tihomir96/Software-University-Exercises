function variableNames(text){
    let myRegex  = /\b_[A-Za-z0-9]+\b/g
    text+=''
    let result = text.match(myRegex)
    result+=''
    let result2=''
    for (const word of result.split(',')) {
        result2 += word.substr(1)+','
        
    }
    if(result2.length>0){
        console.log(result2.substring(0,result2.length-1));
    }
    
}
variableNames("The _id and _age variables are both integers.")