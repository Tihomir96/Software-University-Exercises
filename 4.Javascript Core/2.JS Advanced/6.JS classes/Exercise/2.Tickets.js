function tickets(ticketDescription,sortingCriteria){

    class Ticket {
        constructor(destination,price,status){
            this.destination = destination
            this.price = Number(price)
            this.status = status
        }
    }
    let ticketArray =[]
    for (const ticketString of ticketDescription) {
        let tokens = ticketString.split('|')
        let ticket = new Ticket(tokens[0],tokens[1],tokens[2])
        ticketArray.push(ticket)
    }
    if(sortingCriteria ==='destination'){
        return ticketArray.sort((a,b)=> a.destination>b.destination)
    }else if(sortingCriteria==="price"){
        return ticketArray.sort((a,b)=>a.price>b.price)
        
    }
    return ticketArray.sort((a,b)=>a.status>b.status)

}
console.log(tickets(['Philadelphia|94.20|available',
                     'New York City|95.99|available',
                     'New York City|95.99|sold',
                     'Boston|126.20|departed'],
                     'destination'));

