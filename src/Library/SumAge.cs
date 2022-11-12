namespace Library
{
    public class SumAge: Visitor
    {
        public int SumaAgees {get; private set;}

        /// <summary>
        /// Se encarga de visitar al objeto persona que contiene el nodo, y luego
        /// pasa a visitar a los nodos hijos, en un bucle que se detiene cuando llega a un nodo sin hijos. 
        /// Volviendo a la rama en la que arranco para así pasar a hacer lo mismo con otra rama del árbol
        /// </summary>
        /// <param name="nodo">Objeto de tipo nodo que se devuleve a si mismo durante la ejecución del método Acept</param>
        public override void Visit(Node nodo)
        {
            nodo.Person.Accept(this);
            foreach(Node item in nodo.Children)
            {
                item.Accept(this);
            }

        }

        /// <summary>
        /// Como ahora SumAge conoce al objeto persona en cuestión, por que se paso a si mismo en el método Acept
        /// ahora accedemos a su age y la sumamos al resto. Limpiamos el StringBuilder que contiene el mensaje, 
        /// para así actualizar la age en él.
        /// </summary>
        /// <param name="persona"></param>
        public override void Visit(Person persona)
        {
            ContentBuilder.Clear();
            SumaAgees += persona.Age;
            ContentBuilder.Append($"La suma de todas las agees es {SumaAgees}");
        }

    }
}