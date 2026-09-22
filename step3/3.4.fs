//Задание 1
let power degree number =
    pown number degree
let square = power 2
let result = square 7
printfn "%d" result
//49

//Задание 2
let add a b =
    a + b
let addTen = add 10
let result = addTen 5
printfn "%d" result
//15

//Задание 3
let calculate a b c =
    a * b * c
let step1 = calculate 2
let step2 = step1 3
let result = step2 4
printfn "%d" result
//24

//Задание 4 
let calculate x y =
    x + y
let addNeg20 = calculate -20
let result = addNeg20 5
let absoluteResult = abs result
printfn "%d" absoluteResult
//15

//Задание 5
let getDay prefix day =
    match day with
    | 1 -> prefix + "Понедельник"
    | 2 -> prefix + "Вторник"
    | 3 -> prefix + "Среда"
    | 4 -> prefix + "Четверг"
    | 5 -> prefix + "Пятница"
    | 6 -> prefix + "Суббота"
    | 7 -> prefix + "Воскресенье"
    | _ -> prefix + "Некорректный номер"
let dayWithPrefix = getDay "День: "
let input = System.Console.ReadLine()
let dayNumber = int input
let result = dayWithPrefix dayNumber
printfn "%s" result
//Воскресенье

//Задание 6
let greet greeting name =
    sprintf "%s, %s!" greeting name
let sayHello = greet "Привет"
let result = sayHello "Alex"
printfn "%s" result
//Привет, Alex!

//Задание 7
let checkScore minimum score =
    if score >= minimum then
        "Зачёт"
    else
        "Незачёт"
let checkExam = checkScore 60
let input = System.Console.ReadLine()
let score = int input
let result = checkExam score
printfn "%s" result
//Зачет

//Задание 8
let multiply a b =
    a * b
let double = multiply 2
let result = double 8
printfn "%d" result
//16

//Задание 9
let calculate a b c =
    a + b + c
let step1 = calculate 10
let result = step1 20 30
printfn "%d" result
//60

//Задание 10
let add a b =
    a + b
let add100 = add 100
let result = add100 50
printfn "%d" result
//150
