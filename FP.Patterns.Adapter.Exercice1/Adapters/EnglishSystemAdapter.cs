using FP.Patterns.Adapter.Exercice1.ExternalAPIs;

namespace FP.Patterns.Adapter.Exercice1.Adapters
{
    internal class EnglishSystemAdapter : IPaySystemAdapter
    {
        private readonly EnglishSystem _englishSystem;

        public EnglishSystemAdapter(EnglishSystem englishSystem)
        {
            _englishSystem = englishSystem;
        }

        public void Pay()
        {
            _englishSystem.MakePayment();
        }

        public void Verify()
        {
            _englishSystem.VerifyPayment();
        }

        public void Refund()
        {
            _englishSystem.ReturnMoney();
        }
    }
}
