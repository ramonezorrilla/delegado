// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Reflection;

public delegate void D();

public class ComprobacionDelegados
{
    public static void Main()
    { 
        Type t = typeof(ComprobacionDelegados);
        MethodInfo m = t.GetMethod("Método1");
        D obj = (D) Delegate.CreateDelegate(typeof(D), m);
        obj();
    }

    public static void Método1()
    { Console.WriteLine("Ejecutado Método1");}

    public static void Método2(string s)
    { Console.WriteLine("Ejecutado Método2"); }

}