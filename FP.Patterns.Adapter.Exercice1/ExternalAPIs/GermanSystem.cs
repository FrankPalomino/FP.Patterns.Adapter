namespace FP.Patterns.Adapter.Exercice1.ExternalAPIs
{
    internal class GermanSystem
    {
        public void MachenZahlung()
        {
            Console.WriteLine("Die Zahlung wurde durchgeführt");
        }

        public void UberprufenZahlung()
        {
            Console.WriteLine("Die Zahlung wurde überprüft");
        }

        public void GeldZuruck()
        {
            Console.WriteLine("Das Geld wurde zurückgegeben");
        }
    }
}
