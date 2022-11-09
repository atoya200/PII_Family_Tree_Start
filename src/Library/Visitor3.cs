namespace Library
{
    public class Visitor3: Visitor
    {

        private Persona personaNombreLargo;
        private int tamañoNombre = 0;


        /// <summary>
        /// Se encarga de visitar los nodos, por cada nodo que visita le hace una 
        /// visita a la persona que contiene ese nodo. 
        /// </summary>
        /// <param name="nodo">Objeto de tipo nodo</param>
        public override void Visit(Node nodo)
        {
            
            nodo.Persona.Accept(this);
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
        /// <param name="persona">Objeto de tipo persona</param>
        public override void Visit(Persona persona)
        {
            string nombre  = persona.Nombre.Trim();
            int cantidadLetrasNombre = nombre.Length;
            if(tamañoNombre <= cantidadLetrasNombre)
            {
                tamañoNombre = cantidadLetrasNombre;
                personaNombreLargo = persona;
            }
            ContentBuilder.Clear();
            ContentBuilder.Append($"El nombre {personaNombreLargo.Nombre} es el más largo, tiene  {tamañoNombre} letras");

        } 
    }
}