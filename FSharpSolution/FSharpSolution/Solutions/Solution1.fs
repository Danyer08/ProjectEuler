module Solution1

open System

let Solution = 
    let mutable sumOfMultiplies:int32 = 0

    let test number =
        if number % 3 = 0 || number % 5 = 0 then true
        else false

    for number = 1 to 1000 do
        if test number then sumOfMultiplies <- number + sumOfMultiplies
        else sumOfMultiplies <- 0 + sumOfMultiplies
    printfn "%d" sumOfMultiplies
    let _stop = Console.ReadLine();
    0

