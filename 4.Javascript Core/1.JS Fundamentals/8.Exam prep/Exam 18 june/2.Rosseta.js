function roseta(stringArr) {
    let matrix = stringArr.map(row => row.split(' ').map(num => Number(num)))
    let num = parseInt(matrix.shift())
    let secondMatrix = matrix.splice(0, num)
    let secondaryRow = 0
    let secondaryCol = 0
  
    for (let row = 0; row < matrix.length; row++) {
        if (secondaryRow === secondMatrix.length) {
            secondaryRow = 0
            
        }
        
        for (let col = 0; col < matrix[row].length; col++) {
            if (secondaryCol === secondMatrix[secondaryRow].length) {
                secondaryCol = 0
            }
            matrix[row][col] += secondMatrix[secondaryRow][secondaryCol++]
        }
        secondaryRow++
        secondaryCol=0
    }
    let str = ''
    
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            let ostatuk = matrix[i][j]%27
            if(ostatuk===0){
                str+=' '
            }else{
                str+=String.fromCharCode(96 +(ostatuk))

            }
            
        }
        
    }
    console.log(str.toUpperCase());
    

}
roseta([ '2',
'59 36',
'82 52',
'4 18 25 19 8',
'4 2 8 2 18',
'23 14 22 0 22',
'2 17 13 19 20',
'0 9 0 22 22' 
]
)