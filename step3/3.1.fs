//Задание 1
let number = -50
match sign number with
| -1 -> printfn "Отрицательное число"
| 0 -> printfn "Ноль"
| 1 -> printfn "Положительное число"
//-1

//Задание 2
let a = 25
let b = 50
let minimum = min a b
let maximum = max a b
printfn "Минимум: %d" minimum
printfn "Максимум: %d" maximum
//Минимум: 25
//Максимум: 50

//Задание 3
let number = -12.7
let absoluteValue = abs number
let result = floor absoluteValue
printfn "%f" result
//12.7
//-13.0

//Задание 4
let number = System.Console.ReadLine() |>float
let result = sqrt number
printfn "%f" result
//57.0

//Задание 5
let a = 15
let b = 8
let minimum = min a b
printfn "%d" minimum
//8

//Задание 6
let number = 81.0
let result = sqrt number
printfn "%f" result
//9.0

//Задание 7
let number = 5.7
let result = round number
printfn "%f" result
//6

//Задание 8
let a = -15
let b = 20
let absoluteA = abs a
let result = max absoluteA b
printfn "%d" result
//15, 20

//Задание 9
let number = 16.0
let root = sqrt number
let result = pown root 2
printfn "%f, %f" root result
//4, 16
