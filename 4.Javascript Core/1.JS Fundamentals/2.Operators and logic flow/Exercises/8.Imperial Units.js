function inchToFoot(num){
    let feet = Math.floor(num/12)
    let inch = num-feet*12
    console.log(feet+'\''+ '-'+inch+'\"')
}
inchToFoot(55)