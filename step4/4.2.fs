//Задание 1 
let numbers = [| 4; 7; 2; 9; 15; 3 |]
let index = Array.findIndex (fun x -> x = 9) numbers
printfn "%d" index
//3

//Задание 2
let numbers = [| -5; 10; -3; 7; 0; 15 |]
let positive = Array.filter (fun x -> x > 0) numbers
printfn "%A" positive
//[|10; 7; 15|]

//Задание 3
let mutable numbers = [||]
for _ = 1 to 5 do
    System.Console.WriteLine("Введите число:")
    let input = System.Console.ReadLine()
    numbers <- Array.append numbers [| int input |]
printfn "%A" numbers
//[|10; 20; 30; 40; 50|]

//Задание 4
System.Console.WriteLine("Введите число:")
let input = System.Console.ReadLine()
let number = int input
let result = Array.map (fun x -> x * x) [| number |]
printfn "%A" result
//Массив: [|840889|]

//Задание 5 
let containsNumber number numbers =
    Array.exists (fun x -> x = number) numbers
let result = containsNumber 9 [|4; 7; 2; 9; 15|]
printfn "%b" result
//true

//Задание 6
let mutable numbers = [||]
for _ = 1 to 7 do
    let input = System.Console.ReadLine()
    numbers <- Array.append numbers [| int input |]
let result =
    numbers
    |> Array.filter (fun x -> x > 0)
    |> Array.filter (fun x -> x % 2 = 0)
    |> Array.map (fun x -> x * x)
    |> Array.sort
printfn "%A" result
//[|4; 36; 64; 100|]

//Задание 7
let emptyArray = [||]
let result = Array.isEmpty emptyArray
printfn "%b" result
//true

//Задание 8
let numbers = [| 10; 20; 30; 40; 50 |]
let element = numbers.[2]
printfn "%d" element
//30

//Задание 9
let numbers = [| 10; 20; 30; 40; 50 |]
let first = numbers.[0]
let last = numbers.[numbers.Length - 1]
printfn "%d, %d" first last
//10, 50

//Задание 10
let numbers = [| 1; 2; 3; 4; 5 |]
for i = 0 to numbers.Length - 1 do
    numbers.[i] <- numbers.[i] * 2
printfn "%A" numbers
//[|2; 4; 6; 8; 10|]
