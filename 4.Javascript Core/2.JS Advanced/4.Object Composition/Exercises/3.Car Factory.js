function carFactory(objCar){
    let engines = {
        smallEngine: { power: 90, volume: 1800 },
        normalEngine: { power: 120, volume: 2400 },
        monsterEngine: { power: 200, volume: 3500 }
    }    
    let finestEngine = Number.MAX_SAFE_INTEGER
    let engineForTheCar = ''
    for (const engine in engines) {
        let differenceBetweenEngines = Math.abs(objCar.power - engines[engine].power)
        if(differenceBetweenEngines<finestEngine){
            finestEngine = differenceBetweenEngines
            engineForTheCar = {power: engines[engine].power , volume:engines[engine].volume}
        }
    }
    let wheelsArr=[objCar.wheelsize,objCar.wheelsize,objCar.wheelsize,objCar.wheelsize]
    if(objCar.wheelsize%2===0){
        let wheelsForDaKAR = objCar.wheelsize-1
        wheelsArr=[wheelsForDaKAR,wheelsForDaKAR,wheelsForDaKAR,wheelsForDaKAR]
    }
    
    
    return {
        model : objCar.model,
        engine : engineForTheCar,
        carriage : {
            type : objCar.carriage,
            color : objCar.color
        },
        wheels:wheelsArr
    }   
}


console.log(carFactory({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}));
