class SortList{
    constructor(){
        this.arr = []
        this.size =0
    } 
    
        add (element){
            this.arr.push(element)
            this.size++
            this.sort()
        }
        remove(index){
            if(index>=0 && index<this.arr.length){
                this.arr.splice(index,1)
                this.size--
            }
        }
        get(index){
            if(index>=0 && index<this.arr.length){
                 return this.arr[index]
            }            
        }
        toString(){
            return this.arr.join(' ')
        }
        sort(){
            this.arr = this.arr.sort((a,b)=>a-b)
        }

        
    }

