function concatenateAndReverse(str){
    let allStr = str.join('')
    let chars = Array.from(allStr)
    let revChars = chars.reverse();
    return chars.join('')
}