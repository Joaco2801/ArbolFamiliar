namespace Library;

public abstract class Person
{
    public string nombre { get; set; }
    public int edad { get; set; }

    public Person(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public class individuo : Person
    {
        public individuo(string nombre, int edad) : base(nombre, edad)
        {
        }
    }
}