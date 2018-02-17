function buildPyramid(base,increment){
    
    let lapis = 0
    let gold = 0
    let steps = Math.ceil(base/2)
    let marble = (base-1) * 4
    let stone =(base-2) * (base-2)
    let height = 2
    if(base%2==0){
        gold = 4
    }
    else{
        gold=1
    }
    base-=2
    
    for (let i = 2; i < steps; i++) {
        if(i%5==0){
            lapis+=(base-1) *4
            stone+= (base-2) * (base-2)
            height++
            base-=2
        }else{
            marble+=(base-1) *4
            stone+=(base-2)*(base-2)
            height++
            base-=2
        }
    }
    console.log("Stone required: "+Math.ceil(stone*increment));
    console.log("Marble required: "+Math.ceil(marble*increment));
    console.log("Lapis Lazuli required: "+Math.ceil(lapis*increment));
    console.log('Gold required: '+Math.ceil(increment*gold));
    console.log("Final pyramid height: "+Math.floor(increment*height));
}
