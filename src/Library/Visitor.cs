using System.Text;

namespace Library
{
    public abstract class Visitor
    {
        public string Content
        {
            get
            {
                return this.ContentBuilder.ToString();
            }
        }

        protected StringBuilder ContentBuilder { get; } = new StringBuilder();

        public abstract void Visit(Node nodo);
        public abstract void Visit(Person persona);

        
    }
}