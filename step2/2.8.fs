//Задания 1
for i = 0 to 5 do
    printfn "%d" i
(*0
1
2
3
4
5*)

//Задания 2
for _ = 1 to 3 do
    let name = System.Console.ReadLine()
    printfn "Привет, %s!" name
(*Привет, Alex!
Привет, Po!
Привет, Roma!*)

//Задания 3
let mutable i = 1
while i <= 10 do
    printfn "%d" i
    i <- i + 1
(*1
2
3
4
5
6
7
8
9
10*)

//Задания 4
let mutable number = -1
while number <> 0 do
    let input = System.Console.ReadLine()
    number <- int input
printfn "Программа завершена"
//Программа завершена

//Задания 5
for i = 1 to 20 do
    if i % 2 = 0 then
        printfn "%d" i
(*2
4
6
8
10
12
14
16
18
20*)

//Задания 6
for _ = 1 to 4 do
    for _ = 1 to 5 do
        printf "*"
    printfn ""
(* *****
   *****
   *****
   *****
*)

//Задания 7
let numbers = [4; 7; 2; 9; 15; 3]
let mutable found = false
for n in numbers do
    if n = 9 then
        found <- true
if found then
    printfn "Число найдено"
else
    printfn "Число не найдено"
//Число найдено

//Задания 8
let n = System.Console.ReadLine() |>int
for i = 1 to n do
    printfn "%d" i
(* 1
2
3
4
5 *)

//Задания 9
for i = 10 downto 1 do
    printfn "%d" i
(* 10
9
8
7
6
5
4
3
2
1 *)

//Задания 10
for i in 5..5..30 do
    printfn "%d" i
(* 5
10
15
20
25
30*)
