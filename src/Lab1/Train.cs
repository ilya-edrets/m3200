namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Train
{
    public Train(int mass)
    {
        if (mass < 0)
        {
            throw new ArgumentException("mass should be greater than zero");
        }

        Mass = mass;
    }

    public int Mass { get; private set; }
}