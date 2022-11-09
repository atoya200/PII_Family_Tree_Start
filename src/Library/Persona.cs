namespace Library
{
    public class Persona
    {
        public int Edad {get; private set;}
        
        public string Nombre {get; private set;}

        public Persona(string nombre, int edad)
        {
            this.Edad = edad;
            this.Nombre = nombre;
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