package models

class Euler() {
    fun problem1() {
        var threshold = 0
        var counter = 0
        for (number in threshold..1000) {
            if (number % 3 == 0 || number % 5 == 0) {
                counter += number
            }
            threshold++
        }
        println("Sum of numbers multiplies of 3 and 5 is: $counter")
    }

        var problem2 = {sample: String -> println(sample)}
}