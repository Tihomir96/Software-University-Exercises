function restingHouse(roomsArr, guestsArr) {
    let rooms = {}
    let couples = []

    //Extract rooms
    // for (const room of roomsArr) {
    //     if(!rooms[room.number]){
    //         rooms[room.number]= room.type                  
    //     }        
    // }

    let sameGenderCouples = []
    //Extract couples
    for (const guest of guestsArr) {

        let firstGuest = guest.first
        let secondGuest = guest.second
        //Check if couples are different gender
        if (firstGuest.gender === secondGuest.gender) {

            sameGenderCouples.push(guest)


        } else {
            couples.push(guest)
        }
    }
    let takenRooms = []
    //Get rooms for couples    
    
    for (const room of roomsArr) {
        if (room.type === 'double-bedded') {
            if (couples.length > 0) {
                let couple = couples.pop()


                takenRooms.push({
                    roomNumber: room.number, firstGuestName: couple.first.name
                    , firstGuestAge: couple.first.age, secondGuestName: couple.second.name,
                    secondGuestAge: couple.second.age, emptyBeds: 0
                })
            }
        }
        //Rooms for singles
        else {
            if (sameGenderCouples.length > 0) {
                let them = sameGenderCouples.pop()
                takenRooms.push({
                    roomNumber: room.number, firstGuestName: them.first.name,
                    firstGuestAge: them.first.age, secondGuestName: them.second.name, secondGuestAge: them.second.age, gender: them.first.gender,
                    emptyBeds: 1
                })
            }
        }
    }
    let guestMovedToTeaHouse = 0
    let males = []
    let females = []
    for( let couple of sameGenderCouples) {
        if (couple.first.gender =='female') {
            females.push(couple.first)
            females.push(couple.second)
        } else {
            males.push(couple.first)
            males.push(couple.second)
        }
    }
    for (const room of takenRooms) {
        if (room['emptyBeds'] === 1 && room['gender'] === 'male') {
            if(males.length>0){
                let man = males.pop()

                room.thirdGuestName = man.first.name
                room.thirdGuestAge = man.first.age
                room.emptyBeds = 0    
            }
            continue
            
        } else if (room['emptyBeds'] === 1 && room['gender'] === 'female') {
            if(females.length>0){
                let women = females.pop()

                room.thirdGuestName = women.first.name
                room.thirdGuestAge = women.first.age
                room.emptyBeds = 0    
            }
            continue
        }

    }

}



restingHouse([{ number: '206', type: 'double-bedded' },
{ number: '311', type: 'triple' }],
    [{
        first: { name: 'Tanya Popova', gender: 'female', age: 24 },
        second: { name: 'Miglena Yovcheva', gender: 'female', age: 23 }
    },
    {
        first: { name: 'Katerina Stefanova', gender: 'female', age: 23 },
        second: { name: 'Angel Nachev', gender: 'male', age: 22 }
    },
    {
        first: { name: 'Tatyana Germanova', gender: 'female', age: 23 },
        second: { name: 'Boryana Baeva', gender: 'female', age: 22 }
    }]
)