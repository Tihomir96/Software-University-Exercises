function xmlMessenger(strInput){
    strInput = strInput.replace('\n','[sonko]')
    const fullRegex = new RegExp(/^(<message\s(to|from)="([A-Z a-z]+)(\s*\w+=".+|\s*)"\s(to|from)="[A-Za-z ]+"(>|\s*\w+=".+">))((.+)<\/message>)$/gm);
    const attributeRegex = /<message\s(to|from)="([A-Z a-z]+)"(\s*\w+=".+|\s*)"\s(to|from)="([A-Za-z ]+)"(>|\s*\w+=".+">)/
    
    let result = `<article>\n`
    let validInput = fullRegex.exec(strInput)
    let validAttribute = attributeRegex.exec(strInput)
    if(validInput!==null){
       if(validAttribute[1].startsWith('from')){
            var sender = validAttribute[2]
            var recipient = validAttribute[4]            
       }
       else if (validAttribute[1].startsWith('to')){
            var recipient = validAttribute[2]
            var sender = validAttribute[4]                
       }       
       let messages = validInput[validInput.length-1].split('[sonko]')
       result+=`  <div>From: <span class="sender">${sender}</span></div>\n`
       result+=`  <div>To: <span class="recipient">${recipient}</span></div>\n`
       result+=`  <div>\n`
       for (const message of messages) {
           result+=`    <p>${message}</p>\n`
       }
       result+=`  </div>\n</article>`
    }else if(validAttribute===null){
        strInput.match();
         if (strInput.indexOf('to') == -1 || strInput.indexOf('from') == -1){
            console.log(`Missing attributes`);        
                return
        }
         else {
            console.log(`Invalid message format`);
                return
         }
    }
    else {
        console.log(`Invalid message format`);
        return
    }
    console.log(result);
}

xmlMessenger(`<message to="You" format="1080p" from="Rachel Starr">I hope you like it</message>`)