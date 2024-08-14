// Using the built-in media player
using FP.Patterns.Adapter.Exercice5;

IMediaPlayer mediaPlayer = new MediaPlayer();
mediaPlayer.Play("movie.mp4");

Console.WriteLine();

// Using the third-party video player with an adapter
IVideoPlayer thirdPartyPlayer = new ThirdPartyVideoPlayer();
IMediaPlayer adapter = new Adapter(thirdPartyPlayer);
adapter.Play("another_movie.mp4");

Console.ReadLine(); // Keep console window open