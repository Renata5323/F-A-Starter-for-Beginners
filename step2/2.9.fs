//Задание 1
let number = 15 
match number with
| n when n > 10 -> printfn "Число больше 10"
| _ -> printfn "Число 10 или меньше"
//Число больше 10

//Задание 2
let day = System.Console.ReadLine() |>int
match day with
| 1 -> printfn "Понедельник"
| 2 -> printfn "Вторник"
| 3 -> printfn "Среда"
| 4 -> printfn "Четверг"
| 5 -> printfn "Пятница"
| 6 -> printfn "Суббота"
| 7 -> printfn "Воскресенье"
| _ -> printfn "Некорректный номер дня"
//Четверг

//Задание 3
let numbers = [10; 20; 30]
match numbers with
| first :: _ -> printfn "Первый элемент: %d" first
| [] -> printfn "Список пуст"
//Первый элемент: 10

//Задание 4
let score = 85
match score with
| s when s >= 90 && s <= 100 -> printfn "Отлично"
| s when s >= 70 && s <= 89 -> printfn "Хорошо"
| s when s >= 50 && s <= 69 -> printfn "Удовлетворительно"
| s when s >= 0 && s <= 49 -> printfn "Неудовлетворительно"
| _ -> printfn "Некорректный балл"
//Хорошо

//Задание 5
let number = 2
match number with
| 1 -> printfn "Один"
| 2 -> printfn "Два"
| _ -> printfn "Другое число"
//Два

//Задание 6
let isBlocked = false
match isBlocked with
| true -> printfn "Пользователь заблокирован"
| false -> printfn "Пользователь не заблокирован"
//Пользователь заблокирован

//Задание 7
let day = "Sunday"
match day with
| "Saturday" | "Sunday" -> printfn "Выходной"
| _ -> printfn "Рабочий день"
//Выходной

//Задание 8
let number = 25
match number with
| x when x > 20 -> printfn "Число: %d" x
| _ -> printfn "Число 20 или меньше"
//Число: 25

//Задание 9
let point = (0, 5)
match point with
| (0, 0) -> printfn "Начало координат"
| (0, y) -> printfn "Точка на оси Y"
| (x, 0) -> printfn "Точка на оси X"
| _ -> printfn "Обычная точка"
//Точка на оси Y

//Задание 10
let age = System.Console.ReadLine() |>int
match age with
| a when a < 18 -> printfn "Несовершеннолетний"
| a when a >= 18 && a <= 59 -> printfn "Взрослый"
| _ -> printfn "Пожилой человек"
//Несовершеннолетний
