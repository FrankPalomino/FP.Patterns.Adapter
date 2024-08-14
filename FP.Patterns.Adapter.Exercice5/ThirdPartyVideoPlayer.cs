namespace FP.Patterns.Adapter.Exercice5
{
    public class ThirdPartyVideoPlayer : IVideoPlayer
    {
        public void StartVideo(string videoFile)
        {
            Console.WriteLine($"Start {videoFile} in VideoPlayer");
        }
    }
}
