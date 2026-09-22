//Задание 1
let add a b =
    a + b
let multiply a b =
    a * b
let add10 = add 10
let multiplyBy2 = multiply 2
let result = 5 |> add10 |> multiplyBy2
printfn "%d" result
//30

//Задание 2
let double x =
    x * 2
let result = 15 |> double
printfn "%d" result
//30

//Задание 3
let number = -50
let result = number |> abs
printfn "%d" result
//50

//Задание 4
let add a b =
    a + b
let result = 30 |> add 30
printfn "%d" result
//60

//Задание 5
let getDay day =
    match day with
    | 1 -> "Понедельник"
    | 2 -> "Вторник"
    | 3 -> "Среда"
    | _ -> "Другой день"
let result = 2 |> getDay
printfn "%s" result
//Вторник

//Задание 6
let input = System.Console.ReadLine()
let result =
    input
    |> int
    |> abs
    |> fun x -> x * 2
if result >= 100 then
    printfn "Число большое"
else
    printfn "Число небольшое"
//Число большое

//Задание 7
let number = 100
number |> printfn "%d"
//100

//Задание 8
let double x =
    x * 2
let addTen x =
    x + 10
let result = 5 |> double |> addTen
printfn "%d" result
//20

//Задание 9
let square x = x * x
let double x = x * 2
let addTen x = x + 10
let result = 5 |> square |> double |> addTen
printfn "%d" result
//70
