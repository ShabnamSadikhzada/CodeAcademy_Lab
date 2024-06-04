namespace MethodTasks;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("radiusu daxil edin:");
        int radius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ucbucagin tereflerini daxil edin:");
        int teref1 = Convert.ToInt32(Console.ReadLine());
        int teref2 = Convert.ToInt32(Console.ReadLine());

        int daireArea;
        double ucbucaqArea;

        AreaCalculator(radius, out daireArea);
        AreaCalculator(teref1 , teref2 , out ucbucaqArea);

        Console.WriteLine("Daire sahe: {0}\nUcbucaq sahe: {1}", daireArea, ucbucaqArea);
    }

    static void AreaCalculator(int R, out int area) //daire ucun
    {
        int pi = 3;
        area = pi * R * R;
    }
    static void AreaCalculator(int a, int b, out double area) //duzbucaqli ucbucaq
    {
        area = (double) a * b / 2;
    }
}
