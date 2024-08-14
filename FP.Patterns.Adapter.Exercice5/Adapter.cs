namespace FP.Patterns.Adapter.Exercice5
{
    public class Adapter : IMediaPlayer
    {
        private readonly IVideoPlayer _player;

        public Adapter(IVideoPlayer player)
        {
            _player = player;
        }

        public void Play(string fileName)
        {
            _player.StartVideo(fileName);
        }

    }
}
