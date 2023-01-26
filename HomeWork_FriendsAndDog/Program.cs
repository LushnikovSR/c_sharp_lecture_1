Console.WriteLine("Задача\nДва друга двигаются на встречу друг другу по прямой, при этом у одного из них есть собака"+
" которая бежит от одно друга к другому и возвращается двигаясь быстрее чем кто либо из друзей. Вопрос сколько раз собака добежит"+
" до каждого друга?\nДля решения задачи введите следующие параметры:");
int friends = 2;
Console.WriteLine("Скорость первого друга (м/с): ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Скорость второго друга (м/с): ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Начальное расстояние между друзьями(м): ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Скорость собаки (м/с): ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());
int count = 0;
double time = 0;

while (distance > 10)
{
    if (friends == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friends = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friends = 1;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.WriteLine("Хотите узнать ответ? (Введите 'да' или 'нет'): ");
string answer = Console.ReadLine();
if (answer.ToLower() == "да")
{
    Console.WriteLine($"Собака прибежит {count} раз");
}
else{
    if (answer.ToLower() == "нет")
{
    Console.WriteLine("Удачи с решением задачи!");
}
else{
    Console.WriteLine("Веденная команда не соответствует предложенным вариантам. Удачи с решением задачи.");
}
}
