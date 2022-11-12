namespace Library
{
    public class OldestSon: Visitor
    {
        private Node majorNode;

        private int nodoSize = 0;


        /// <summary>
        /// Hace la visita al nodo, tomando el tamaño de la rama como la cantidad de nodos hijos que tiene.
        /// Revisa si esa cantidad esa mayor a la que ya estaba como la del más grande, si es igual o mayor
        /// la del nodo que llega, se sustituye el nodo mayor de la clase OldestSon por este entrante. 
        /// </summary>
        /// <param name="nodo">Objeto de tipo nodo</param>
        public override void Visit(Node nodo)
        {
            int cantChildren = nodo.Children.Count;
            if(nodoSize <= cantChildren)
            {
                majorNode =  nodo;
                nodoSize = cantChildren;
            }
            majorNode.Person.Accept(this);

            foreach(Node item in nodo.Children)
            {
                item.Accept(this);
            }

        }

        /// <summary>
        /// Se encarga de tomar el name de la persona que almacena el nodo, para así hacerlo un poco 
        /// mejor el mensaje o el resultado de la ejecución. Diciendo que tal persona tiene tantos hijos, siendo
        /// esta contenida en el nodo más grande. 
        /// </summary>
        /// <param name="person">Objeto de tipo Person</param>
        public override void Visit(Person person)
        {
            ContentBuilder.Clear();
            ContentBuilder.Append($"{person.Name} tiene  {nodoSize} hijos");

        } 
    }
}