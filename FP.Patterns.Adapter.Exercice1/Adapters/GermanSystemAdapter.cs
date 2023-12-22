using FP.Patterns.Adapter.Exercice1.ExternalAPIs;

namespace FP.Patterns.Adapter.Exercice1.Adapters
{
    internal class GermanSystemAdapter : IPaySystemAdapter
    {
        private readonly GermanSystem _germanSystem;

        public GermanSystemAdapter(GermanSystem germanSystem)
        {
            _germanSystem = germanSystem;
        }

        public void Pay()
        {
            _germanSystem.MachenZahlung();
        }

        public void Verify()
        {
            _germanSystem.UberprufenZahlung();
        }

        public void Refund()
        {
            _germanSystem.GeldZuruck();
        }
    }
}
