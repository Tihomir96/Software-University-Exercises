function spiralMatrix(rows,cols)
{ 
    let targetNum = rows*cols
    let number = 1
    let matrix = fillMatrixWithZeros(rows,cols)

    let currentRow = 0
    let currentCol =0
    let rotatios =0
    while(targetNum>=number){

        for (let i = rotatios; i < cols-rotatios; i++) {
            matrix[currentRow][currentCol++]= number++
        }
        
        currentCol-=1
        for (let i = ++currentRow; i <= rows-1-rotatios; i++) {
            matrix[currentRow++][currentCol] = number++            
        }

        currentRow-=1
        for (let i = --currentCol; i >=rotatios; i--) {
            matrix[currentRow][currentCol--] = number++
        }

        currentCol+=1
        for (let i = --currentRow; i >rotatios ; i--) {
            matrix[currentRow--][currentCol]=number++
        }  

        rotatios++
        currentCol++
        currentRow++   

    }
    printMatrix(matrix)

    function printMatrix(matrix){
        console.log(matrix.map(e=>e.join(' ')).join('\n'))
    }
    function fillMatrixWithZeros(rows,cols){
        let matrix = []
        for (let i = 0; i < rows; i++) {
            matrix.push('0'.repeat(cols).split('').map(Number))
        }
        return matrix
    }
}
spiralMatrix(5,5)