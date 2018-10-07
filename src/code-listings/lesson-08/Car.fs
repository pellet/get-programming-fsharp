module Car

open System

/// Gets the distance to a given destination 
let getDistance (destination) =
    if destination = "Gas" then 10
    elif destination = "Office" then 50
    elif destination = "Home" then 25
    elif destination = "Stadium" then 25
    else failwith "Unknown destination!"
    
let calculateRemainingPetrol(currentPetrol:int, distance:int) : int =
        if currentPetrol >= distance then currentPetrol - distance
        else failwith "Oops! You've run out of petrol!"

/// Drives to a given destination given a starting amount of petrol
let driveTo (petrol:int, destination:string) : int =
    let distance = getDistance(destination)
    if destination = "Gas"
    then (calculateRemainingPetrol(petrol, distance)) + 50
    else calculateRemainingPetrol(petrol, distance)