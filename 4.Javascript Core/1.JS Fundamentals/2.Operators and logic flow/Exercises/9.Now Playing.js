function nowPlayin(arr){
    let song = arr[0]
    let artist = arr[1]
    let length = arr[2]
    console.log(`Now Playing: ${artist} - ${song} [${length}]`)
}
nowPlayin(['Number One', 'Nelly', '4:09'])