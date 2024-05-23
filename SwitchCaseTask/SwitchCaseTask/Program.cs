namespace SwitchCaseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonthTranslater();
            MonthTranslater1();
        }

        public static void MonthTranslater()
        {
            string season = Console.ReadLine().ToLower();

            switch (season)
            {
                case "spring":
                    season = "yaz";
                    break;
                case "winter":
                    season = "qış";
                    break;
                case "autumn":
                    season = "payız";
                    break;
                case "summer":
                    season = "yay";
                    break;
                default:
                    season = "invalid season name";
                    break;
            }

            Console.WriteLine(season);
        }

        public static void MonthTranslater1()
        {
            string season = Console.ReadLine().ToLower();

            string seasonVal = season switch
            {
                "spring" => "yaz",
                "winter" => "qis",
                "autumn" => "payiz",
                "summer" => "yay",
                _ => "invalid season name"
            };

            Console.WriteLine(seasonVal);
        }
    }
}
