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


