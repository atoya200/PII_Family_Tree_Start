namespace Library
{
    public class LongestName: Visitor
    {

        private Person longNamePerson;
        private int nameSize = 0;


        /// <summary>
        /// Se encarga de visitar los nodos, por cada nodo que visita le hace una 
        /// visita a la persona que contiene ese nodo. 
        /// </summary>
        /// <param name="nodo">Objeto de tipo nodo</param>
        public override void Visit(Node nodo)
        {
            
            nodo.Person.Accept(this);
            foreach(Node item in nodo.Children)
            {
                item.Accept(this);
            }

        }

        /// <summary>
        /// Se encarga de la visita a la persona. Toma el nombre de la persona, quitar los espacios 
        /// que pueda llegar a tener adelante y/o atrás. Luego recoje el largo de se nombre modificado y revisa 
        /// que la cantidad de letras sea mayor o igual a la cantidad que ya estaba de la pasada anterior o del por defecto.
        /// Luego limpia el mensaje y le carga el texto de cual es el nombre que tiene más letras, con la cantidad de letras que tiene.
        /// </summary>
        /// <param person="person">Objeto de tipo Person, persona</param>
        public override void Visit(Person person)
        {
            string name  = person.Name.Trim();
            int cantidadLetrasName = name.Length;
            if(nameSize <= cantidadLetrasName)
            {
                nameSize = cantidadLetrasName;
                longNamePerson = person;
            }
            ContentBuilder.Clear();
            ContentBuilder.Append($"El nombre {longNamePerson.Name} es el más largo, tiene  {nameSize} letras");

        } 
    }
}