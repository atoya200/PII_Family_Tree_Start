namespace Library
{
    public class Person
    {
        public int Age {get; private set;}
        
        public string Name {get; private set;}

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
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