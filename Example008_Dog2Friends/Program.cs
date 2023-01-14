/* Задача "Два друга и собака":
Два друга идут на встречу друг другу, собака носится между ними.
Сколько раз собака успеет пробежать от одного друга к другому? */

int count = 0;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

Console.Write("Введите расстояние между друзьями: ");
int distance = Convert.ToInt32(Console.ReadLine());

while (distance > 10)
{
  if (friend == 1)
  {
    time = distance / (firstFriendSpeed + dogSpeed);
    friend = 2;
  }
  else
  {
    time = distance / (secondFriendSpeed + dogSpeed);
    friend = 1;
  }
  distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
  count ++;
}

Console.WriteLine($"Собака успеет пробежать от одного друга к другому {count} раз.");