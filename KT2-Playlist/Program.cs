using System;

class Program
{
    static void Main()
    {
        var playlist = new Playlist();
        playlist.Add("Track A");
        playlist.Add("Track B");
        playlist.Add("Track C");

        Console.WriteLine(playlist[1]);
        Console.WriteLine(playlist["Track C"]);
        Console.WriteLine(playlist["Track Z"]);

        playlist[0] = "New Track A";
        Console.WriteLine(playlist);

       // Console.WriteLine(playlist[10]);
    }
}