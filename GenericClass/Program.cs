using System;
using GenericClass.SimpleStack;

//StackDouble();
//StackString();
StackGeneric();

void StackGeneric()
{
    var stack = new SimpleStackGeneric<string>();
    stack.Push("Hasnat");
    stack.Push("Rabi");
    stack.Push("karim");
    while(stack.Count > 0){
        var item = stack.Pop();
        Console.WriteLine(item);
    }
}

static void StackString()
{
    var stack = new SimpleStackString();
    stack.Push("Tanvir");
    stack.Push("Ornob");
    stack.Push("ornik");
    while(stack.Count >0){
        var item = stack.Pop();
        Console.WriteLine(item);
    }     
}

Console.ReadLine();

static void StackDouble()
{
var stack = new SimpleStack();
var sum = 0.0;
stack.Push(1.2);
stack.Push(2.8);
stack.Push(3.0);
while (stack.Count > 0)
{
    var item = stack.Pop();
    sum += item;
    Console.WriteLine(item);
}
Console.WriteLine(sum);
}


