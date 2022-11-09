namespace Library
{
    public class Visitor1: Visitor
    {
        public int SumaEdades {get; private set;}

        /// <summary>
        /// Se encarga de visitar al objeto persona que contiene el nodo, y luego
        /// pasa a visitar a los nodos hijos, en un bucle que se detiene cuando llega a un nodo sin hijos. 
        /// </summary>
        /// <param name="nodo">Objeto de tipo nodo que se devuleve a si mismo durante la ejecución del método Acept</param>
        public override void Visit(Node nodo)
        {
            nodo.Persona.Accept(this);
            foreach(Node item in nodo.Children)
            {
                item.Accept(this);
            }

        }

        /// <summary>
        /// Como ahora visitor1 conoce al objeto persona en cuestión, por que se paso a si mismo en el método Acept
        /// ahora accedemos a su edad y la sumamos al resto. Limpiamos el StringBuilder que contiene el mensaje, 
        /// para así actualizar la edad en él.
        /// </summary>
        /// <param name="persona"></param>
        public override void Visit(Persona persona)
        {
            ContentBuilder.Clear();
            SumaEdades += persona.Edad;
            ContentBuilder.Append($"La suma de todas las edades es {SumaEdades}");
        }

    }
}