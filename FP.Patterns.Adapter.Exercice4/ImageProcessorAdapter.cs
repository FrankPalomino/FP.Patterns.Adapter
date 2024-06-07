namespace FP.Patterns.Adapter.Exercice4
{
    public class ImageProcessorAdapter : IImageProcessor
    {
        private readonly ThirdPartyImageProcessor _processor;

        public ImageProcessorAdapter(ThirdPartyImageProcessor processor)
        {
            _processor = processor;
        }

        public void ApplyFilter()
        {
            _processor.ApplyExternalFilter();
        }

        public void LoadImage()
        {
            _processor.LoadExternalImage();
        }

        public void SaveImage()
        {
            _processor.SaveExternalImage();
        }
    }
}
