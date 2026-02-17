// See https://aka.ms/new-console-template for more information
using StackQueue2026;

Console.WriteLine("Hello, World!");
MyStackLinkedList<Person> persons = new MyStackLinkedList<Person>();

Person p1 = new Person(1, "Person 1", 18);
Person p2 =new Person(2, "Person 2", 10);
Person p3 = new Person(3, "Person 3", 91);
persons.Push(p1);

persons.Peek();
Console.WriteLine(persons);
persons.Pop();
Console.WriteLine(persons);