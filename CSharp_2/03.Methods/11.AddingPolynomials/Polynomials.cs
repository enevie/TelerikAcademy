using System;
using System.Text;


class Polynomials
{
    static int[] FillingPolynomial(int number)
    {
        int[] polynom = new int[number];
        for (int i = 0, j=polynom.Length-1; i < polynom.Length; i++, j--)
        {
            Console.Write("Enter x^{0}: ",j);
            polynom[i] = int.Parse(Console.ReadLine());
        }
        return polynom;
    }
    static int[] CastingPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] result = new int[firstPolynomial.Length];
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            result[i] = firstPolynomial[i] + secondPolynomial[i];
            
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter the power of the polynom: ");
        int n = int.Parse(Console.ReadLine());

        int[] firstPolynom = new int[n];
        int[] secondPolynom = new int[n];
        Console.WriteLine("Enter the numbers first polynom: ");
        firstPolynom = FillingPolynomial(n);
        Console.WriteLine("Enter the numbers second polynom: ");
        secondPolynom = FillingPolynomial(n);

        int[] result = CastingPolynomials(firstPolynom, secondPolynom);

        StringBuilder builder = new StringBuilder();
       
        for (int i = 0, j = result.Length-1; i < result.Length; i++, j--)
        {
            builder.Append(result[i]).Append('x').Append('^').Append(j).Append(' ').Append('+').Append(' ');
        }
        Console.WriteLine(builder);

    }
}

