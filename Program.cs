using System;

public class Seminar02 {
    static void Zadacha01(){
        Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.");
        int a;
        Console.Write("Введите число: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine((a/100)*10+(a%10));
    }

    static void Zadacha02(){
        int a, x, result = 1;
        a = int.Parse(Console.ReadLine());
        x = a%10;
        a = (a/10)%10;
        for (int i = 0; i < x; i++) result *= a;
        Console.WriteLine(result);
    }
    
    static void Zadacha03(){
        int a, b;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        if (a % b == 0) Console.WriteLine("да");
        else Console.WriteLine($"нет, {a%b}");
    }
    
    static void Zadacha04(){
        int a = int.Parse(Console.ReadLine());
        if (a > 99) Console.WriteLine(a/100%10);
        else Console.WriteLine("Третьей цифры нет");
    }
    
    static void Dz01(){
        int a = int.Parse(Console.ReadLine());
        if (a % 7 == 0 & a % 23 == 0) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
    
    static void Dz02(){
        Console.Write("Введите Х: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Введите Y: ");
        int y = int.Parse(Console.ReadLine());
        if (x>0 & y>0) Console.WriteLine(1);
        if (x<0 & y>0) Console.WriteLine(2);
        if (x<0 & y<0) Console.WriteLine(3);
        if (x>0 & y<0) Console.WriteLine(4);
    }
    static void Dz03(){
        Console.Write("Введите двузначное число: ");
        int a = int.Parse(Console.ReadLine());
        if (a%10 >= a/10) Console.WriteLine(a%10);
        else Console.WriteLine(a/10);
    }
    static void Dz04(){
        Console.Write("Введите число: ");
        string a = Console.ReadLine();
        int x = a.Length;
        for (int i = 0; i<x-1; i++){
            Console.Write($"{a[i]}, ");
        }
        Console.WriteLine($"{a[x-1]}.");
    }
    static public void Main(){
        string x = "";
        Console.Clear();
        while (x != "q"){
            Console.Write("Выберите задачу для проверки (p1,p2,p3,p4,d1,d2,d3,d4): ");
            x = Console.ReadLine();
            Console.Clear();
            switch(x)
            {
                case "p1":
                    Zadacha01();
                    break;
                case "p2":
                    Zadacha02();
                    break;
                case "p3":
                    Zadacha03();
                    break;
                case "p4":
                    Zadacha04();
                    break;
                case "d1":
                    Dz01();
                    break;
                case "d2":
                    Dz02();
                    break;
                case "d3":
                    Dz03();
                    break;
                case "d4":
                    Dz04();
                    break;
            }
        }
    }
}
