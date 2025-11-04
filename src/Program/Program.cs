using System;
using Library;

namespace Program
{
    class Program
    {
        static void main(String[] args)
        {
            Person.individuo UEUAA = new Person.individuo("Mario", 37);
            Person.individuo TingTang = new Person.individuo("Dylan", 17);
            Person.individuo WalaWala = new Person.individuo("Juanjo", 28);
            Person.individuo bingbong = new Person.individuo("Arieri", 45);
            Person.individuo UEUAA1 = new Person.individuo("Maria", 12);
            Person.individuo TingTangWalaWala = new Person.individuo("Natasha", 15);
            Person.individuo BangBaaaaaang = new Person.individuo("La Sheni", 19);
        }
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n2.AddChildren(n4);
            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            SumVisitor visitor = new SumVisitor();
            n1.Accept(visitor);
            Console.WriteLine(visitor.Sum);
        }
    }
}
