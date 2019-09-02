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

    fun problem2() {
        var counter = 0
        var currentNumber = 1
        var previousNumber = 1

        while (currentNumber < 4000000) {
         if (currentNumber % 2 == 0) {
             counter += currentNumber
         }
            currentNumber += previousNumber
            previousNumber = currentNumber - previousNumber

        }

        println("The sum of fibonacci sequence under 400000 is: $counter")
    }
}