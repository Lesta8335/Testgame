// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
//Добавить 1
//Удалить 2
//Изменить 3
//Найти 4
//Выход 5
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("");
    Console.WriteLine("------------------");
    Console.WriteLine("Welcome to menu:");
    Console.WriteLine("Press [1] to Add");
    Console.WriteLine("Press [2] to Delete");
    Console.WriteLine("Press [3] to Change");
    Console.WriteLine("Press [4] to Find");
    Console.WriteLine("Press [5] to Exit");
    Console.WriteLine("------------------");
    string menus = Console.ReadLine();
    int menu = Convert.ToInt32(menus);
    string cases = Console.ReadLine();
    switch (menu)
    {
        case 1: 
            Console.WriteLine("What would you like to add?"); break;
        case 2: 
            Console.WriteLine("What would you like to delete?"); break;
        case 3:
            Console.WriteLine("What would you like to change"); break;
        case 4:
            Console.WriteLine("What would you like to find"); break;
        case 5:
            Console.WriteLine("What would you like to exit"); break;
    }
}