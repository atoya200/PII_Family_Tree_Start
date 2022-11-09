namespace Library
{
    public class Visitor2: Visitor
    {
        private Node nodoMayor;

        private int tamaño = 0;


        /// <summary>
        /// Hace la visita al nodo, tomando el tamaño de la rama como la cantidad de nodos hijos que tiene.
        /// Revisa si esa cantidad esa mayor a la que ya estaba como la del más grande, si es igual o mayor
        /// la del nodo que llega, se sustituye el nodo mayor de la clase Visitor2 por este entrante. 
        /// </summary>
        /// <param name="nodo">Objeto de tipo nodo</param>
        public override void Visit(Node nodo)
        {
            int cantidadHijos = nodo.Children.Count;
            if(tamaño <= cantidadHijos)
            {
                nodoMayor =  nodo;
                tamaño = cantidadHijos;
            }
            nodoMayor.Persona.Accept(this);

            foreach(Node item in nodo.Children)
            {
                item.Accept(this);
            }

        }

        /// <summary>
        /// Se encarga de tomar el nombre de la persona que almacena el nodo, para así hacerlo un poco 
        /// mejor el mensaje o el resultado de la ejecución. Diciendo que tal persona tiene tantos hijos, siendo
        /// esta contenida en el nodo más grande. 
        /// </summary>
        /// <param name="persona">Objeto de tipo persona</param>
        public override void Visit(Persona persona)
        {
            ContentBuilder.Clear();
            ContentBuilder.Append($"{persona.Nombre} tiene  {tamaño} hijos");

        } 
    }
}