using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        BigInteger b = 1;
        for(int i = 2; i <= 100; i++)
            b*=i;

        BigInteger sum = 0;
        while(b>0){
            BigInteger rem;
            b = BigInteger.DivRem(b, 10, out rem);
            sum += rem;
        }

        Console.WriteLine(sum);
    }
}