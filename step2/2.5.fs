//Задания 1
let a = "FSharp"
let result = [5]
printf "%A" result //'p'

//Задания 2
let name = System.Console.ReadLine() //Alexander
let result = name.Length
printf "%A" result //9

//Задания 3
let b = System.Console.ReadLine() //PANDA
let result = b.ToLower()
printf "%A" result //"panda"

//Задания 4
let name1 = System.Console.ReadLine()
let name2 = System.Console.ReadLine()
let result = name1 + name2
printf "%A" result //"AlexPo"

//Задания 5
let name = System.Console.ReadLine()
let result = sprintf "Имя: %s" name
printf "%s" result //"Имя: Alex"

//Задания 6
let c = "Hello, Alex!"
let result = c.Replace("Alex", "Ivan")
printf "%A" result //"Hello, Ivan!"

//Задания 7
let d = "Hello, world!"
let result = d.StartsWith("Hello")
printf "%A" result //true

//Задания 8
let e = "Alex,Ivan,Peter"
let result = e.Split (',')
printf "%A" result //[|"Alex"; "Ivan"; "Peter"|]

//Задания 9
let names = System.Console.ReadLine()
let name = names.Split (',')
let result = String.concat ", " name
printf "%A" result //"Alex,Ivan,Peter"

//Задания 10
let a = System.Console.ReadLine()
let b = a.Trim()
let c = b.Length
let d = a.ToUpper()
let e = d.Contains("F#")
printfn "Длина строки: %d" c
printfn "Верхний регистр: %s" d
printfn "Содержит F#: %b" e
//Длина строки: 50
//Верхний регистр:    Я ИЗУЧАЮ F# И ХОЧУ НАУЧИТЬСЯ ПРОГРАММИРОВАТЬ НА F#         
//Содержит F#: true
