﻿using Homework_10._01._2023_Practice_;
using Homework_10._01._2023_Practice_.Controllers;
using System.Reflection;

#region Indexer,Reflection
//Book book1 = new Book() { Id = 1, Name = "Xosrov" };
//Book book2 = new Book() { Id = 2, Name = "7 gozel" };

//Library library = new();
//library[0] = book1;
//library[1] = book2;


//Console.WriteLine(library[0].Name);
//Console.WriteLine(library[1].Name);


//Assembly assembly = Assembly.GetExecutingAssembly();

//foreach (var item in assembly.GetTypes())
//{
//	foreach (var item2 in item.GetMembers())
//	{
//		Console.WriteLine(item2);
//	}
//}
#endregion

AccountContreller account = new AccountContreller();
account.Register();


