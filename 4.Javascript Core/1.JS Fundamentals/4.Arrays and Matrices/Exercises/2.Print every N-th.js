    function  printNthElement(input){
        let n = parseInt(input.pop()) 
        for (let i = 0; i < input.length; i+=n) {
            console.log(input[i]);
        }
    }

    printNthElement([ 'dsa', 'asd', 'test', 'tset', '2' ])