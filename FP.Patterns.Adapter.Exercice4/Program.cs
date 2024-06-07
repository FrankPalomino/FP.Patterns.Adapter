using FP.Patterns.Adapter.Exercice4;

ThirdPartyImageProcessor thirdPartyImageProcessor = new ThirdPartyImageProcessor();
ImageProcessorAdapter adapter = new ImageProcessorAdapter(thirdPartyImageProcessor);

adapter.LoadImage();
adapter.ApplyFilter();
adapter.SaveImage();
