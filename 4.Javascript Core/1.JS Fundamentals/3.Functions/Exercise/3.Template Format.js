function templateFormat(input){
    let str = '<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<quiz>\r\n'
    for (let i = 0; i < input.length; i+=2) {
        let questionText = input[i]
        let answerText = input[i+1]
        str += `  <question>\r\n    ${questionText}\r\n  </question>\r\n  <answer>\r\n    ${answerText}\r\n  </answer>\r\n`
                
    }
    console.log(str+`</quiz>`);
}
