using System;
using System.Collections.Generic;

class MinhaPilha
{
    private Stack<string> pilha = new Stack<string>();

    public void Push(string item)
    {
        pilha.Push(item);
    }

    public string Pop()
    {
        if (pilha.Count == 0)
        {
            Console.WriteLine("A pilha está vazia. Não é possível realizar a operação Pop.");
            return null;
        }
        return pilha.Pop();
    }

    public string Peek()
    {
        if (pilha.Count == 0)
        {
            Console.WriteLine("A pilha está vazia. Não é possível realizar a operação Peek.");
            return null;
        }
        return pilha.Peek();
    }

    public bool IsEmpty()
    {
        return pilha.Count == 0;
    }

    public void PrintStack()
    {
        if (pilha.Count == 0)
        {
            Console.WriteLine("A pilha está vazia.");
            return;
        }

        Console.WriteLine("Conteúdo da Pilha:");
        foreach (var item in pilha)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        MinhaPilha minhaPilha = new MinhaPilha();

        // Adicionando valores à pilha
        minhaPilha.Push("Item 1");
        minhaPilha.Push("Item 2");
        minhaPilha.Push("Item 3");

        // Exibindo conteúdo da pilha
        Console.WriteLine("Conteúdo inicial da Pilha:");
        minhaPilha.PrintStack();

        // Realizando operações Pop e Peek
        string popResult = minhaPilha.Pop();
        Console.WriteLine($"Item removido (Pop): {popResult}");

        string peekResult = minhaPilha.Peek();
        Console.WriteLine($"Item no topo (Peek): {peekResult}");

        // Exibindo conteúdo da pilha após operações
        Console.WriteLine("Conteúdo atual da Pilha:");
        minhaPilha.PrintStack();
    }
}
