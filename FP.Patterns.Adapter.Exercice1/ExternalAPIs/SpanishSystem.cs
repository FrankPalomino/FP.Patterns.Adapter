namespace FP.Patterns.Adapter.Exercice1.ExternalAPIs
{
    internal class SpanishSystem
    {
        public void HacerPago()
        {
            Console.WriteLine("El pago se ha hecho");
        }

        public void VerificarPago()
        {
            Console.WriteLine("El pago ha sido verificado");
        }

        public void DevolverDinero()
        {
            Console.WriteLine("El dinero se devolvió");
        }
    }
}
