//Задания 1
let findMax a b = max a b
let result = findMax 67 52
printfn "%d" result
//67

//Задания 2
let calculate a b = a + b
let a = 10
let b = 20
let result = calculate a b
printfn "%d" result
//30

//Задания 3 
let getDay n =
    match n with
    | 1 -> "Понедельник"
    | 2 -> "Вторник"
    | 3 -> "Среда"
    | 4 -> "Четверг"
    | 5 -> "Пятница"
    | 6 -> "Суббота"
    | 7 -> "Воскресенье"
    | _ -> "Некорректный номер"
let input = System.Console.ReadLine()
let dayNumber = int input
let result = getDay dayNumber
printfn "%s" result
//"Пятница"

//Задания 4
let processCommand command =
    match command with
    | "start" -> "Программа запущена"
    | "stop" -> "Программа остановлена"
    | "restart" -> "Программа перезапущена"
    | "help" -> "Доступные команды: start, stop, restart, help"
    | _ -> "Неизвестная команда"
let input = System.Console.ReadLine()
let result = processCommand input
printfn "%s" result
//"Программа остановлена"

//Задания 5 
let square x = x * x
let result = square 5
printfn "%d" result
//25

//Задания 6
let multiply a b = a * b
let result = multiply 6 9
printfn "%d" result
//54

//Задания 7 
let input1 = System.Console.ReadLine()
let input2 = System.Console.ReadLine()
let a = int input1
let b = int input2
let add x y = x + y
let result = add a b
printfn "Сумма: %d" result
//Сумма: 9

//Задания 8
let absolute x = abs x
let result = absolute -25
printfn "%d" result
//25

//Задания 9
let checkNumber n =
    match n with
    | x when x > 0 -> "Положительное"
    | x when x < 0 -> "Отрицательное"
    | _ -> "Ноль"
let result = checkNumber 64
printfn "%s" result
//"Положительное"
