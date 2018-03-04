var doSearch = function(array, targetValue) {
	var min = 0;
	var max = array.length - 1;
    var guess = (max + min) /2;
    var bool = guess<max && guess >min;

    while(bool){
     if(guess<targetValue &&guess>min){
        max = guess ;
        guess = (min + max) /2;
    
     }else if(guess===targetValue){
         console.log(array.indexOf(guess)) 
         bool=false
    
     }
     else if(guess>targetValue && guess<max){
         min = guess;
         guess = (min+max)/2;
     }
     
     
    
    }


	return -1;
};

var primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 
		41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97];

var result = doSearch(primes, 73);