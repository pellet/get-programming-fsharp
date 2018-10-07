open System

/// Gets the distance to a given destination 
let getDistance (destination) =
    if destination = "Gas" then 10
    elif destination = "Office" then 50
    elif destination = "Home" then 25
    elif destination = "Stadium" then 25
    else failwith "Unknown destination!"

// Couple of quick tests
getDistance("Home") = 25
getDistance("Stadium") = 25

let calculateRemainingPetrol(currentPetrol:int, distance:int) : int =
    if currentPetrol >= distance then currentPetrol - distance
    else failwith "Oops! You've run out of petrol!"

// more tests
calculateRemainingPetrol(100, 10) = 90
//calculateRemainingPetrol(50, 50) = 0

// combined tests
let distanceToGas = getDistance("Gas")
calculateRemainingPetrol(25, distanceToGas)
//calculateRemainingPetrol(5, distanceToGas)

let driveTo (petrol:int, destination:string) : int =
    let distance = getDistance(destination)
    if destination = "Gas"
    then (calculateRemainingPetrol(petrol, distance)) + 50
    else calculateRemainingPetrol(petrol, distance)
    
let a = driveTo(100, "Office")
let b = driveTo(a, "Stadium")
let c = driveTo(b, "Gas")
let answer = driveTo(c, "Home")