Console.WriteLine("Шаг 1");
int[] recordBooks = {1042, 1058, 1071, 1093, 1105};
int target = 2095;
bool found = false;

foreach (int number in recordBooks){
    if (number == target){
        found = true;
        break;
    }
}
Console.WriteLine(found ? "Студент найден" : "Студент не найден");

Console.WriteLine("Шаг 2");
int variant = 177;
bool isPrime = true;

if (variant < 2){
    Console.WriteLine("Число не является ни простым, ни составным");
}
else{
    for (int divisor = 2; divisor < variant; divisor++){
    if (variant % divisor == 0){
        isPrime = false;
        break;
    }
}
Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
}

Console.WriteLine("Шаг 3");
int[] pointsPerLab = {8, -1, 10, 9, -1, 7};
int sum = 0;
int count = 0;

foreach (int points in pointsPerLab){
    if (points < 0){
        continue;
    }
    sum += points;
    count++;
}
Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
Console.WriteLine($"Количество сданных работ: {count}");

Console.WriteLine("Шаг 4");
int[] groupIds = {101, 104, 107, 104, 110};
bool hasDuplicates = false;

for (int i = 0; i < groupIds.Length; i++){
    for (int j = i + 1; j < groupIds.Length; j++){
        if (groupIds[i] == groupIds[j]){
            Console.WriteLine($"Найдены дубликаты: {groupIds[i]} и {groupIds[j]}");
            hasDuplicates = true;
            break;
        }
    }
    if (hasDuplicates){
        break;
    }
}
if(!hasDuplicates){
    Console.WriteLine($"все номера уникальны");
}

Console.WriteLine("Шаг 5");
int days = 5;
int lessonsPerDay = 6;
bool found1 = false;

for (int day = 1; day <= days && !found1; day++){
    for (int lesson = 1; lesson <= lessonsPerDay; lesson++){
        bool isFree = (day == 3 && lesson == 4);

        if (isFree){
            Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
            found1 = true;
            break;
        }
    }
}
if (!found1){
    Console.WriteLine("Свободных слотов нет");
}

Console.WriteLine("Самостоятельное задание В");
int[] numbers1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int sum1 = 0;

foreach (int num in numbers1){
    if (num % 2 != 0){
        continue;
    }
    sum1 += num;
}
Console.WriteLine($"Сумма четных чисел: {sum1}");

Console.WriteLine("Самостоятельное задание Г");
int[] n = {1, 5, 3, 7, 9};
bool hasDuplicates1 = false;

for (int k = 0; k < n.Length; k++){
    for (int c = k + 1; c < n.Length; c++){
        if (n[k] == n[c]){
            hasDuplicates1 = true;
            break;
        }
    }
    if (hasDuplicates1){
        break;
    }
}
Console.WriteLine(hasDuplicates1 ? "Еусть повторяющие элементы" : "Все элементы уникальны");


Console.Write("Введите свою фамилию: "); string surname = Console.ReadLine()!.Trim(); 
 
if (string.IsNullOrEmpty(surname)) { 
    Console.WriteLine("Фамилия не введена. Завершение работы.");     return; 
}  
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
 
var assigned = Enumerable.Range(1, 10) 
    .OrderBy(_ => rnd.Next()) 
    .Take(2) 
    .OrderBy(x => x) 
    .ToList(); 
 
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 


Console.WriteLine("Вариант 3");
int[] numbers2 = {1, 2, 3, 4, 5, 6, 7, 8, 9};
int summ = 0;

foreach (int num1 in numbers2){
    if (num1 % 3 == 0){
        continue;
    }
    summ += num1;
}
Console.WriteLine($"сумма: {summ}");

Console.WriteLine("Вариант 4");
int[] groupIds3 = {105, 107, 111, 107, 110};
bool hasDuplicates2 = false;

for (int s = 0; s < groupIds3.Length; s++){
    for (int g = s + 1; g < groupIds3.Length; g++){
        if (groupIds3[s] == groupIds3[g]){
            Console.WriteLine($"Найдены дубликаты: {groupIds3[s]} и {groupIds3[g]}");
            hasDuplicates2 = true;
            break;
        }
    }
    if (hasDuplicates2){
        break;
    }
}
if(!hasDuplicates2){
    Console.WriteLine($"все номера уникальны");
}