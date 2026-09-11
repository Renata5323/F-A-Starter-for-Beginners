//Задание 1
let a = 6
let b = 5
let result = a*b
printf "%d" result //30

//Задание 2
let a, b = 10, 10
let result = a=b
printf "%A" result //true

//Задание 3
let result = 7<12
printf "%A" result //true

//Задание 4
let a = true
let b = false
let result = a&&b
printf "%A" result //false

//Задание 5
let age = 20
let hasTicket = true
let b = age>18
let result = b&&hasTicket
printf "%A" result //true

//Задание 6
let number = 100
number |> printfn "%A" //100

//Задание 7
let a = [1..5]
printf "%A" a //[1; 2; 3; 4; 5]

//Задание 8
let a = [10..-1..5]
printf "%A" a //[10; 9; 8; 7; 6; 5]

//Задание 9
let a = 15
let b = 7
let sum = a+b
printf "%d" sum //22

//Задание 10
let a = 17
let b = 5
let result = a%b
printf "%A" result //2
