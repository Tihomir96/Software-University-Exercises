function getsortedList(){
    return {
        arr : [],
        size:0,
        add : function(element) {
            this.arr.push(element)
            this.size++
            this.sort()
        },
        remove: function(index){
            if(index>=0 && index<this.arr.length){
                this.arr.splice(index,1)
                this.size--
            }
        },  
        get:function(index){
            if(index>=0 && index<this.arr.length){
                 return this.arr[index]
            }            
        },
        toString: function(){
            return this.arr.join(' ')
        },
        sort: function(){
            this.arr = this.arr.sort((a,b)=>a-b)
        }

        
    }
}
