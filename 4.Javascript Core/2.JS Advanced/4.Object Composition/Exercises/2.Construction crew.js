function constructionCrew(workerObj){
    if(workerObj.handsShaking){
        let requiredAmountAlcohol = (0.1 * workerObj.weight) *workerObj.experience
        workerObj.bloodAlcoholLevel += requiredAmountAlcohol
        workerObj.handsShaking = false
    }
    return workerObj
}
