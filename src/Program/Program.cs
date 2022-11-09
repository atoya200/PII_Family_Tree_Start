using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // José es el más veterano, tiene dos hijos, Lucía y Luca
            Node n1 = new Node("José", 100);
            Node n2 = new Node("Lucía", 77);
            Node n3 = new Node("Luca", 72);
            // Luca tiene 2 hijos Tom y Mary
            Node n4 = new Node("Tom", 43);
            Node n5 = new Node("Mary", 27);
            // Lucía tiene también dos hijos, Frank y Greta
            Node n6 = new Node("Greta", 40);
            Node n7 = new Node("Frank", 37);
            // De los nietos de José,  Mary tiene tres hijos, Linda, Mat y Jess
            Node n8 = new Node("Linda", 2);
            Node n9 = new Node("Mat", 7);
            Node n10 = new Node("Jessie", 5);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n6);
            n2.AddChildren(n7);

            n3.AddChildren(n4);
            n3.AddChildren(n5);

            n5.AddChildren(n8);
            n5.AddChildren(n9);
            n5.AddChildren(n10);


            // visitar el árbol aquí
            Visitor visitador = new Visitor1();
            visitador.Visit(n1);
            Console.WriteLine(visitador.Content);
            // Parte 1 del desafio
            visitador = new Visitor2();
            visitador.Visit(n1);
            Console.WriteLine(visitador.Content);
            // Parte 2 del desafio
            visitador = new Visitor3();
            visitador.Visit(n1);
            Console.WriteLine(visitador.Content);
        }
    }
}
