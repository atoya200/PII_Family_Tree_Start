using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person person;

        /// <summary>
        /// Lista de nodos hijos, esta privada por encapsulación.
        /// </summary>
        private List<Node> children = new List<Node>();

        /// <summary>
        /// Propiage que se refiere a la variable privada person
        /// </summary>
        /// <value>Objeto de tipo Person.</value>
        public Person Person {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        /// <summary>
        /// Por Creator el nodo debe ser el encargado de crear los objetos de tipo Person, ya que 
        /// contiene objetos de este tipo. Por ende, se le pasan los datos para su creación
        /// </summary>
        /// <param name="name"> Nombre de la persona</param>
        /// <param name="age"> Edad de la persona </param>
        public Node(string name, int age)
        {
            Person newPerson = new Person(name, age);
            this.person = newPerson;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        /// <summary>
        /// Siguiendo el patron visitor, se implementa un método "Acept", en las clases que van a ser 
        /// visitadas. Esta forma de hacerlo, hace que se pueda cumplir la Ley de Demeter. A su vez, permite
        /// aplicar el principio de LSP, ya que cualquier objeto que tenga como supertipo a "Visitor", puede ser recibido
        /// como argumento en ese método.
        /// </summary>
        /// <param name="visitor">Objeto del tipo visitante</param>
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        
    }
}
