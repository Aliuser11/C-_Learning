/*Tworzenie Typów*/
using System;

public class Test
{
    public const string Message = "Witaj, świecie"; //stała
}
//metody wyrażeniowe
class MetodyWyrazeniowe
    /*int Foo (int x) { return x * 2; }
     mozna zapisać inaczej : */ 
{
    int Foo(int x) => x * 2; // zastępuje return

    void Fool(int x) => Console.WriteLine(x); //typ zwrotny -> void
}