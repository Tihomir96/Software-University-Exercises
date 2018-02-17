function galactinElections(objArr){
    let systems = {}

    for (let obj of objArr) {
        if(!systems[obj.system]) {
            systems[obj.system] = {};
        }
        if(!systems[obj.system][obj.candidate]) {
            systems[obj.system][obj.candidate] = 0;
        }
        systems[obj.system][obj.candidate] += obj.votes;        
    }
    let newObj = Object.assign({}, systems);
    var systemWinners = {};
    for (let systemName in systems) {
        var candidates = systems[systemName]
        var winnerName;        
        var votes = 0;
        systemWinners[systemName] = {};
        winnerVotes = 0;
        for (let candidate in candidates) {
            votes+=candidates[candidate];
            if (candidates[candidate] > winnerVotes) {
                winnerName = candidate
                winnerVotes = candidates[candidate];
            }
        }
        // winners[systemName][winnerName] = votes;
        systemWinners[systemName] = {
            candidate: winnerName,
            votes: votes,
        };
    }
    var allVotes =0
    var leftCandidates = {}
    for (const systemName in systemWinners) {
        let system = systemWinners[systemName];
        if(!leftCandidates[system.candidate]) {
            leftCandidates[system.candidate] = 0;
        } 
        allVotes+=system.votes
        leftCandidates[system.candidate]+= system.votes        
    }
    let percentages = [];
    for (const key in leftCandidates) {
        percentages.push({
            candidate: key,
            percatage: (leftCandidates[key] / allVotes) * 100 
        });    
    }
    if (percentages.length == 1) {
        console.log(`${percentages[0].candidate} wins with ${leftCandidates[percentages[0].candidate]} votes`);
        console.log(`${percentages[0].candidate} wins unopposed!`);        
        return
    }

    let sorted = percentages.sort((a, b) =>  b.percatage -a.percatage).slice(0, 2);
    if(sorted[0].percatage>50){
        console.log(`${sorted[0].candidate} wins with ${leftCandidates[sorted[0].candidate]} votes`);
        console.log(`Runner up: ${sorted[1].candidate}`);
        
        let runnerSystems = [];
        for(let systemName in systemWinners) {
            if (systemWinners[systemName].candidate === sorted[1].candidate) {
                runnerSystems.push({
                    system: systemName,
                    votes: systemWinners[systemName].votes
                });
            }
        }
        runnerSystems = runnerSystems.sort((a, b) =>b.votes- a.votes  );
        for (const cukaBlyat of runnerSystems) {
            console.log(`${cukaBlyat.system}: ${cukaBlyat.votes}`);
            
        }
        
        
    }else{
        console.log(`Runoff between ${sorted[0].candidate} with ${Math.round(sorted[0].percatage).toFixed(0)}% and ${sorted[1].candidate} with ${Math.floor(sorted[1].percatage).toFixed(0)}%`);
        
    }
}  

galactinElections([ 
{ system: 'Theta' ,   candidate: 'Kitler',     votes: 50 },
{ system: 'Theta',   candidate: 'Space Cow',     votes: 45 },
{ system: 'Theta',   candidate: 'Huge Manatee',     votes: 45 },
{ system: 'Theta',   candidate: 'Flying Shrimp', votes: 45 },
{ system: 'Tau', candidate: 'Kitler', votes: 50 },
{ system: 'Tau', candidate: 'Space Cow',       votes: 60 } ,
{ system: 'Sigma', candidate: 'Kitler',       votes: 50 },
{ system: 'Sigma', candidate: 'Huge Manatee',       votes: 60 },
{ system: 'Omicron', candidate: 'Kitler',       votes: 50 }]

)