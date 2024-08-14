namespace FP.Patterns.Adapter.Exercice5
{
    public class MediaPlayer : IMediaPlayer
    {
        public void Play(string fileName)
        {
            Console.WriteLine("Play a MediaPlayer");
        }
    }
}
