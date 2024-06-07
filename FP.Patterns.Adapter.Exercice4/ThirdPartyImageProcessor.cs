namespace FP.Patterns.Adapter.Exercice4
{
    public class ThirdPartyImageProcessor
    {
        public void LoadExternalImage()
        {
            Console.WriteLine("The external API is Loading Image");
        }
        public void ApplyExternalFilter()
        {
            Console.WriteLine("The external API is Appling Filter");
        }
        public void SaveExternalImage()
        {
            Console.WriteLine("The external API is Saving Image");
        }
    }
}
