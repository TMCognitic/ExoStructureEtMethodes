namespace ExoStructureEtMethodes
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature;
            do
            {
                Console.Clear();
                Console.WriteLine("Quelle température en Celsius fait il dans la pièce ? ");
                Console.Write("Entrez la valeur de a : ");
            } while (!double.TryParse(Console.ReadLine(), out temperature));

            Celsius celsius = new Celsius();
            celsius.Temperature = temperature;

            Fahrenheit fahrenheit = celsius.Convert();
            Console.WriteLine($"La température en Fahrenheit : {fahrenheit.Temperature}");
            celsius = fahrenheit.Convert();
            Console.WriteLine($"La température en Celsius : {celsius.Temperature}");
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();

            double a, b, c;
            do
            {
                Console.Clear();
                Console.WriteLine("Pour une équation du second degrés (ax² + bx + c = 0)");
                Console.Write("Entrez la valeur de a : ");
            } while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Clear();
                Console.WriteLine("Pour une équation du second degrés (ax² + bx + c = 0)");
                Console.Write("Entrez la valeur de b : ");
            } while (!double.TryParse(Console.ReadLine(), out b));

            do
            {
                Console.Clear();
                Console.WriteLine("Pour une équation du second degrés (ax² + bx + c = 0)");
                Console.Write("Entrez la valeur de c : ");
            } while (!double.TryParse(Console.ReadLine(), out c));

            if(Eq2D(a, b, c, out double? x1, out double? x2))
            {
                Console.WriteLine($"x1 : {x1.Value} - x2 : {x2.Value}");
            }
            else
            {
                Console.WriteLine("Aucun résultat");
            }
        }

        static bool Eq2D(double a, double b, double c, out double? x1, out double? x2)
        {
            x1 = x2 = null;

            if(a == 0D)
            {
                //todo : Transformer en Exception
                Console.WriteLine("Ce n'est pas une équation du second degré!");
                return false;
            }

            double delta = (b * b) - (4 * a * c);

            if(delta >= 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return true;
            }

            return false;
        }
    }
}

