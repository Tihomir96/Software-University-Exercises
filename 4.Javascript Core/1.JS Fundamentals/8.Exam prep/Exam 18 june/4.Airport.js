function aeroporto(strArr) {
    let flights = {};
    let airports = {}
    for (const string of strArr) {

        let [id, airport, passengers, action] = string.split(' ')

        if (action === 'land') {
            if (flights[id]) {
                continue;
            } else {
                if (airports[airport]) {
                    airports[airport].arival += Number(passengers)
                } else {
                    airports[airport] = {
                        arival: Number(passengers),
                        airport: airport
                    }
                }
                if (!airports[airport].planes)
                    airports[airport].planes = {};
                airports[airport].planes[id] = true;
                flights[id] = {
                    id: id,
                    airport: airport,
                    passengers: Number(passengers),
                    action: action
                }
            }
        } else {
            if (!flights[id]) {
                continue;
            } else {
                if (airports[airport]) {
                    if (airports[airport].departures) {
                        airports[airport].departures += Number(passengers)
                    } else {
                        airports[airport].departures = Number(passengers)
                    }
                } else {
                    airports[airport] = {
                        departures: Number(passengers),
                        airport: airport
                    }
                }
                if (!airports[airport].planes)
                    airports[airport].planes = {};
                airports[airport].planes[id] = true;

                delete flights[id];
            }
        }
    }
    console.log(`Planes left:`);

    Object.keys(flights).sort((a, b) => {
      
        return a.localeCompare(b);
    }).forEach(key => console.log(`- ${key}`))
    let newAirportStructure = []
    for (let a in airports) {
        newAirportStructure.push(airports[a])
    }
    newAirportStructure = newAirportStructure.sort((a, b) => {
        if (a.arival === b.arival) {
           
            return a.airport.localeCompare(b.airport);
        } else {
            return b.arival - a.arival
        }
    })

    for (const key of newAirportStructure) {
        console.log(key['airport']);
        console.log(`Arrivals: ${key['arival']}`);
        console.log(`Departures: ${key['departures']?key['departures']:'0'}`);
        console.log(`Planes:`);
        let planes = Object.keys(key['planes']).sort((a, b) => {
            return a.localeCompare(b)}) 
       for (const plane of planes ) {
           console.log(`-- ${plane}`);
           
       }


    }
}



aeroporto([
    "Airbus Paris 356 land",
    "Airbus London 321 land",
    "Airbus Paris 213 depart",
    "Airbus Ljubljana 250 land"
    ])

