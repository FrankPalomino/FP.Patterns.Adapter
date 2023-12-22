using FP.Patterns.Adapter.Exercice1.ExternalAPIs;

namespace FP.Patterns.Adapter.Exercice1.Adapters
{
    internal class SpanishSystemAdapter : IPaySystemAdapter
    {
        private readonly SpanishSystem _spanishSystem;

        public SpanishSystemAdapter(SpanishSystem spanishSystem)
        {
            _spanishSystem = spanishSystem;
        }

        public void Pay()
        {
            _spanishSystem.HacerPago();
        }

        public void Verify()
        {
            _spanishSystem.VerificarPago();
        }

        public void Refund()
        {
            _spanishSystem.DevolverDinero();
        }
    }
}
