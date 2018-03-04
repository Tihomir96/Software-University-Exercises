function personalBmi(name,age,weight,height){
    let obj = {
        name,
        personalInfo : {
            age,
            weight,
            height
        },
        BMI :(function () {
            height = height/100
           return Math.round( weight/ ( height*height))           
        })()        
    }
    obj.status =(function () {
        
    
        if(obj.BMI<18.5){
            return"underweight"
        }
        else if(  obj.BMI < 25){
            return"normal"
        }
        
        else if( obj.BMI< 30){
            return"overweight"
        }
        else{
            return "obese"
        }
        
    })()
    if(obj.status ==='obese'){
        obj.recommendation= 'admission required' 
    }
    return obj
     
}
personalBmi('Honey Boo Boo', 9, 57, 137)