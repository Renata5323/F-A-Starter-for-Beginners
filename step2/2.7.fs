//Задание 1
let age = System.Console.ReadLine() |>int
if age>=18 then
  printfn "Доступ разрешен"
else
  printfn "Доступ запрещён" 
//Доступ разрешен

//Задание 2
let num = System.Console.ReadLine() |> int
if num>100 then 
  printfn "больше 100"
elif num>=50 && num>=100 then
  printfn "от 50 до 100"
elif num<=49 && num<>0 then
  printfn "от 1 до 49"
elif num=0 then
  printfn "равно 0"
else 
  printfn "меньше 0"
//от 50 до 100
  
//Задание 3
let isBlocked = false
if not isBlocked then
    printfn "Доступ разрешён"
//Доступ разрешен

//Задание 4 
let number = 10
if number%2=0 then 
  let result = number * 2
  printfn "%d" result
else 
  let result = number * (-1)
  printfn "%d" result
//20

//Задание 5
let number = System.Console.ReadLine() |> int
if number >= 1 && number <= 10 then
    printfn "Число входит в диапазон"
else
    printfn "Число не входит в диапазон"
//Число не входит в диапазон

//Задание 6
let a = System.Console.ReadLine() |> int
let b = System.Console.ReadLine() |> int
if a > b then
    printfn "Первое число больше"
elif b > a then
    printfn "Второе число больше"
else
    printfn "Числа равны"
//Первое число больше

//Задание 7
let age = System.Console.ReadLine() |>int
if age >= 0 && age <= 12 then
    printfn "Ребёнок"
elif age >= 13 && age <= 17 then
    printfn "Подросток"
elif age >= 18 && age <= 59 then
    printfn "Взрослый"
else
    printfn "Пожилой человек"
//Пожилой человек

//Задание 8
let number = 15
if number > 0 then
    printfn "Положительное число"
//Положительное число

//Задание 9 
let password = "12345"
if password = "12345" then
    printfn "Пароль верный"
else
    printfn "Пароль неверный"
//Пароль верный
