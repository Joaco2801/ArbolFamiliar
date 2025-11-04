using System;
using Library;

namespace Program
{
    class Program
    {
        static void main(String[] args)
        {
            Person.Individuo UEUAA = new Person.Individuo("Mario", 37);
            Person.Individuo TingTang = new Person.Individuo("Dylan", 17);
            Person.Individuo WalaWala = new Person.Individuo("Juanjo", 28);
            Person.Individuo bingbong = new Person.Individuo("Arieri", 45);
            Person.Individuo UEUAA1 = new Person.Individuo("Maria", 12);
            Person.Individuo TingTangWalaWala = new Person.Individuo("Natasha", 15);
            Person.Individuo BangBaaaaaang = new Person.Individuo("La Sheni", 19);
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
