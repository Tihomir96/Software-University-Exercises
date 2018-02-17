function eexpedition (primaryMatrix,secondaryMatrix,targetCordinates,startCordinates){
    let steps = 0
    for (const coordinate of targetCordinates) {
        modifyPrimaryMatrix(coordinate)
    }
    let prevDirection;
    
    let currentRow = startCordinates[0]
    let currentCol = startCordinates[1]
    while(true){
        //down
        if(currentRow+1<primaryMatrix.length && primaryMatrix[currentRow+1][currentCol]==0 && prevDirection !='up'){
            prevDirection ='down'
            currentRow++
        }
        //right
        else if(currentCol+1<primaryMatrix[0].length && primaryMatrix[currentRow][currentCol+1]==0 && prevDirection !='left'){
            prevDirection = 'left'
            currentCol++
        }
        //up
        else if(currentRow-1<=0 && primaryMatrix[currentRow-1][currentCol]==0 && prevDirection !='down'){
            prevDirection = 'up'
            currentRow--
        }
        //left
        else if(currentCol-1<0 && primaryMatrix[currentRow][currentCol-1]==0 && prevDirection !='right'){
            prevDirection = 'right'
            currentCol--
        }else{
            break;
        }      
        steps++
    }
    console.log(steps);
    definePosition(currentRow,currentCol)
    
    function definePosition(endRow,endCol){
        let output;
        //top border
        if(endRow==0){
            output='Top'           
        }
        //left border
        else if(endCol==0){
            output='Left'
        }
        //bottom
        else if(endRow==primaryMatrix.length-1){
            output='Bottom'
        }else if(endRow==primaryMatrix[0].length-1){
            output=`Right`        
        }
        //dead ends
        else if(endRow<primaryMatrix.length/2 && endCol>=primaryMatrix[0].length/2){
            output = `Dead end 1`
        }else if(endRow<primaryMatrix.length/2 && endCol<primaryMatrix[0].length/2){
            output = `Dead end 2`
        }else if(endRow>= primaryMatrix.length/2 && endCol<primaryMatrix[0].length/2){
            output='Dead end 3'
        }else if(endRow>=primaryMatrix.length/2 && endCol>=primaryMatrix[0].length/2){
            output = `Dead end 4`
        }
        console.log(output);
        
    }
    function modifyPrimaryMatrix([targetRow,targetCol]){
        for(let row=0;row<secondaryMatrix.length;row++){
            let secondaryMatrixRow = secondaryMatrix[row]
            if(primaryMatrix[targetRow+row][targetCol]!=undefined && primaryMatrix[targetRow+row][targetCol]){
                for (let col = 0; col < secondaryMatrix[0].length; col++) {

                    if(secondaryMatrix[row][col]==1 && primaryMatrix[targetRow+row][targetCol+col]!=undefined){
                        primaryMatrix[targetRow+row][targetCol+col] = primaryMatrix[targetRow+row][targetCol+col]==1?0:1
                    }
                }
            }
        }
       
    }
}
let testMatrix = [
                [1, 1, 0, 1, 1, 1, 1, 0],
                [0, 1, 1, 1, 0, 0, 0, 1],
                [1, 0, 0, 1, 0, 0, 0, 1],
                [0, 0, 0, 1, 1, 0, 0, 1],
                [1, 0, 0, 1, 1, 1, 1, 1],
                [1, 0, 1, 1, 0, 1, 0, 0]
                                        ]
let secondaryMatrixTest =[[0, 1, 1],
                         [0, 1, 0],
                         [1, 1, 0]];
                                      
let targetCord =  [[1, 1],
                    [2, 3],
                    [5, 3]];
                                      
let startCords = [0, 2]
eexpedition(testMatrix,secondaryMatrixTest,targetCord,startCords)