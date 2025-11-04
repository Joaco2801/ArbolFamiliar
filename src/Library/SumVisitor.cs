namespace Library;

public class SumVisitor: IVisitor
{
    private int sum = 0;

    public int Sum
    {
        get
        {
            return this.sum;
        }
    }

    public void Visit(Node node)
    {
        sum += node.Number;
    }

    public void Visit2(Person individuo)
    {
        sum +=  individuo.Edad;
    }
}
