﻿//Задача №3: Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите цыфру от 1 до 7, соответсвующую дню недели");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("День недели: ");
switch (day)
{
    case 1: Console.WriteLine("понедельник"); break;
    case 2: Console.WriteLine("вторник"); break;
    case 3: Console.WriteLine("среда"); break;
    case 4: Console.WriteLine("четверг"); break;
    case 5: Console.WriteLine("пяьница"); break;
    case 6: Console.WriteLine("суббота"); break;
    case 7: Console.WriteLine("воскресенье"); break;
    default: Console.WriteLine("неверный ввод"); break;
  }
