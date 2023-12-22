namespace FP.Patterns.Adapter.Exercice1.ExternalAPIs
{
    internal class EnglishSystem
    {
        public void MakePayment()
        {
            Console.WriteLine("The payment has been done");
        }

        public void VerifyPayment()
        {
            Console.WriteLine("The verify has been done");
        }

        public void ReturnMoney()
        {
            Console.WriteLine("The money has been returned");
        }
    }
}
