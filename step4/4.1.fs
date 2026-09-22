//Задание 1
let numbers = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
let filtered = List.filter (fun x -> x > 5) numbers
printfn "%A" filtered
//[6; 7; 8; 9; 10]

//Задание 2
let numbers = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
let filtered = List.filter (fun x -> x > 5) numbers
printfn "%A" filtered
//[6; 7; 8; 9; 10]

//Задание 3
let mutable numbers = []
for _ = 1 to 5 do
    let input = System.Console.ReadLine()
    numbers <- numbers @ [int input]
printfn "%A" numbers
//[45; 34; 7; 65; 99]

//Задание 4
let numbers = [1; 2; 3; 4; 5]
let result =
    numbers
    |> List.filter (fun x -> x > 2)
    |> List.map (fun x -> x * 10)
printfn "%A" result
//[30; 40; 50]

//Задание 5
let getEven numbers =
    List.filter (fun x -> x % 2 = 0) numbers
let result = getEven [1; 2; 3; 4; 5; 6]
printfn "%A" result
//[2; 4; 6]

//Задание 6
let mutable numbers = []
for _ = 1 to 5 do
    let input = System.Console.ReadLine()
    numbers <- numbers @ [int input]
let result =
    numbers
    |> List.filter (fun x -> x > 0)
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map (fun x -> x * 2)
    |> List.sort
printfn "%A" result
//[8; 16]

//Задание 7
let numbers = [1..10]
printfn "%A" numbers
//[1; 2; 3; 4; 5; 6; 7; 8; 9; 10]

//Задание 8
let first = [1; 2; 3]
let second = [4; 5; 6]
let result = first @ second
printfn "%A" result
//[1; 2; 3; 4; 5; 6]

//Задание 9
let numbers = [10; 20; 30; 40]
let lastElement = List.last numbers
printfn "%d" lastElement
//40
