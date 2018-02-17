function roomOrder(rooms, guests) {
    let filledRooms = [];
    // let females = [];
    // let males = [];
    let sameGenderCouple = [];
    let couples = [];
    for (let couple of guests) {
      if (couple.first.gender !== couple.second.gender) {
        couples.push(couple);
      } else if (couple.first.gender === 'female') {
        sameGenderCouple.push(couple);
        // females.push(couple);
      } else {
        sameGenderCouple.push(couple);
        // males.push(couple);
      }
    }
    let doubleRooms = [];
    let tripleRooms = [];
    for (let room of rooms) {
      if (room.type === 'double-bedded') {
        doubleRooms.push(room);
      } else {
        tripleRooms.push(room);
      }
    }
    couples = couples.reverse();
    doubleRooms = doubleRooms.reverse();
    tripleRooms = tripleRooms.reverse();
    
    let couplesLeft = [];
    let halfFilledRooms = [];
    let males = [];
    let females = [];
    for (let couple of guests) {
      if (couple.first.gender !== couple.second.gender) {
        if (doubleRooms.length > 0) {
          let room = doubleRooms.pop();
          filledRooms.push({
            number: room.number,
            guests: [couple.first, couple.second],
            emptyBeds: 0
          });
        } else {
          let male = couple.first.gender == 'male' ? couple.first : couple.second;
          let female = couple.first.gender == 'female' ? couple.first : couple.second;
          males.push(male);
          females.push(female);
        }
      } else {
        if (tripleRooms.length > 0) {
          let room = tripleRooms.pop();
          halfFilledRooms.push({
            number: room.number,
            guests: [couple.first, couple.second],
            gender: couple.first.gender,
            emptyBeds: 1
          });
        } else {
          if (couple.first.gender == 'male') {
            males.push(couple.first);
            males.push(couple.second);
          } else {
            females.push(couple.first);
            females.push(couple.second);
          }
        }
      }
    }
    halfFilledRooms = halfFilledRooms.reverse();
    male = males.reverse();
    female = females.reverse();
    while (halfFilledRooms.length > 0) {
      let room = halfFilledRooms.pop();
      if (room.gender === 'female') {
        if (female.length > 0) {
          room.guests.push(female.pop());
          room.emptyBeds = 0;
        }
      } else {
        if (male.length > 0) {
          room.guests.push(male.pop());
          room.emptyBeds = 0;
        }
      }
      filledRooms.push(room);
    }
   
    let sortNumber = (a,b) => {
      if (a.number < b.number) return -1;
      if (a.number > b.number) return 1;
      return 0;
    };
   
    let sortGuest = (a,b) => {
      if (a.name < b.name) return -1;
      if (a.name > b.name) return 1;
      return 0;
    };
   
    filledRooms.sort(sortNumber).forEach((room) => {
      console.log(`Room number: ${room.number}`);
      room.guests.sort(sortGuest).forEach((guest) => {
        console.log(`--Guest Name: ${guest.name}`);
        console.log(`--Guest Age: ${guest.age}`);
      })
      console.log(`Empty beds in the room: ${room.emptyBeds}`);
    })
    let moved = females.length + males.length;
    console.log(`Guests moved to the tea house: ${moved}`);
  }