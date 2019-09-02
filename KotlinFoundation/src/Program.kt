import models.Euler

val euler = Euler()

fun main(args: Array<String>) {
    println("Choose an euler problem")
    when (readLine()!!.toInt()) {
        1 -> euler.problem1()
        2 -> euler.problem2("Hello")
    }
}