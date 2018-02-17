function compoundInterest(data){
    let sum = data[0]
    let interestRate = data[1]/100
    let freq = 12/data[2]
    let years = data[3]
    let f = sum * Math.pow(1+interestRate/freq , freq * years)
    console.log(Math.round(f*100)/100)
}
compoundInterest([1500, 4.3, 3, 6])