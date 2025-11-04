namespace Library;

public abstract class Person
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Person(string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }

    public class individuo : Person
    {
        public individuo(string nombre, int edad) : base(nombre, edad)
        {
        }
    }
}