function dayOfWeek(day) {  
    let lowerCaseDay = day.toLowerCase()
    if (lowerCaseDay == 'monday') return 1;
    if(lowerCaseDay =='tuesday') return 2;
    if(lowerCaseDay =='wednesday') return 3
    if(lowerCaseDay =='thursday') return 4
    if(lowerCaseDay =='friday') return 5
    if(lowerCaseDay =='saturday') return 6
    if (lowerCaseDay == 'sunday') return 7;
    return "error";
}
 console.log(dayOfWeek('SunDay'));
  