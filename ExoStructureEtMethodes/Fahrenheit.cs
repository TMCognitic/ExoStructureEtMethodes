namespace ExoStructureEtMethodes
{
    public struct Fahrenheit
    {
        public double Temperature;

        public Celsius Convert()
        {
            Celsius celsius = new Celsius();
            celsius.Temperature = (Temperature - 32) / 1.8;
            return celsius;
        }
    }
}