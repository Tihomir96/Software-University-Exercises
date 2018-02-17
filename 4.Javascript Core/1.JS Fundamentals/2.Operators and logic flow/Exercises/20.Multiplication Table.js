function multiplicationTable(n){
    let output = `<table border=1>`
    output+=`<tr>`
    for(let i =1; i<=n;i++){
        if(i==1){
            output+='<th>x</th>'
        }
        output+=`<th>${i}<th>`}
        output+=`</tr>\n`
        for (let row = 1; row <= n; row++) {
            output+=`<tr>`
            output+=`<th>${row}</th>`
            for (let col = 1; col <= n; col++) {
                output+= `<td>${row*col}</td>`              
            }       
            output+=`</tr>`             
            output+=`\n`
        }
        output+=`</table>`
        console.log(output);
    }
    multiplicationTable(5)
