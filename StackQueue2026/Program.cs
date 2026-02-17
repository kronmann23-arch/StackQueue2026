// See https://aka.ms/new-console-template for more information
using StackQueue2026;

Console.WriteLine("Hello, World!");
MyStackLinkedList<Person> persons = new MyStackLinkedList<Person>();

Person p1 = new Person(1, "Person 1", 18);
Person p2 =new Person(2, "Person 2", 10);
Person p3 = new Person(3, "Person 3", 91);

try
{
persons.Pop();
}
catch (MyStackIsEmptyException msieex)
{
    Console.WriteLine(msieex.Message);
}

persons.Push(p1);
persons.Push(p2);
persons.Push(p3);

//Console.WriteLine(persons.Peek());
//foreach (Person p in persons)
//{
//    Console.WriteLine(p);
//}

Console.WriteLine(persons.Peek());
persons.Pop();
Console.WriteLine(persons.Peek());

persons.Pop();
Console.WriteLine(persons.Peek());

//persons.Pop();
//Console.WriteLine(persons.Peek());