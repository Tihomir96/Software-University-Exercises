function arithmetile(numbsarr){
    let maxProduct =Number.MIN_SAFE_INTEGER
    for (let i = 0; i < numbsarr.length; i++) {

        if(numbsarr[i]>0&&numbsarr[i]<=9){
            let product = 1;

            
            for (let j = i+1; j < numbsarr.length && j <= i+parseInt(numbsarr[i]) ; j++) {
               
                
                product*=numbsarr[j]
                
            }
            if(product>maxProduct){
                maxProduct=product
            }
        }
    }
    console.log(maxProduct);
}
arithmetile([10,20,2,30,44,3,56,20,24])