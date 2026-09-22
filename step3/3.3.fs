//Задание 1
let input = System.Console.ReadLine()
let number = int input
let square = fun x -> x * x
let result = square number
printfn "%d" result
//4489

//Задание 2
let process = fun x ->
    let doubled = x * 2
    doubled + 10
let result = process 5
printfn "%d" result
//20

//Задание 3
let input = System.Console.ReadLine()
let day = int input
let getDay = fun n ->
    match n with
    | 1 -> "Понедельник"
    | 2 -> "Вторник"
    | 3 -> "Среда"
    | 4 -> "Четверг"
    | 5 -> "Пятница"
    | 6 -> "Суббота"
    | 7 -> "Воскресенье"
    | _ -> "Некорректный номер"
let result = getDay day
printfn "%s" result
//"Суббота"

//Задание 4
let double = fun x -> x * 2
let result = double 10
printfn "%d" result
//100

//Задание 5
let square = fun x -> x * x
let result = square 6
printfn "%d" result
//36

//Задание 6
let check = fun x ->
    if x > 0 then "Положительное"
    else "Неположительное"
let result = check -10
printfn "%s" result
//"Положительно"

//Задание 7
let findMax = fun a b -> max a b
let result = findMax 15 27
printfn "%d" result
//27

//Задание 8
let input = System.Console.ReadLine()
let greet = fun name -> "Привет, " + name + "!"
let result = greet input
printfn "%s" result
//Привет, Alex!

//Задание 9
let square = fun x -> x * x
for i = 1 to 5 do
    let result = square i
    printfn "%d" result
//1
//4
//9
//16
//25

//Задание 10
let operation = fun a b -> a * b
let result = operation 6 8
printfn "%d" result
//48
