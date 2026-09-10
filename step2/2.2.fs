//Задание 1
let name = "Ivan"
let age = 20
printfn "Имя: %s" name
printfn "Возраст: %d" age

//Задание 2
let a, b, c = 5, 10, 15
printfn "%d" a
printfn "%d" b
printfn "%d" c

//Задание 3
let age: int = 25
let name: string = "Alex"
printfn "%d" age
printfn "%s" name

//Задание 4
let number = 500
printfn "%A" number

//Задание 5
let message = sprintfn "Имя: %s" "Alex"
printf "%s" message

//Задание 6
printfn "Введите имя:"
let name = System.Console.ReadLine()
printfn "Привет, %s" name

//Задание 7
let a = System.Console.ReadLine() |> int
let b = System.Console.ReadLine() |> int
printfn "Первое число: %d" a
printfn "Второе число: %d" b

//Задание 8
let name = System.Console.ReadLine()
let age = System.Console.ReadLine() |> int
let info = sprintf "Пользователь %s, возраст %d" name age
printfn "%s" info

//Задание 9
let a = 10
let b = 20
let sum = a + b
printfn "Сумма: %d" sum
