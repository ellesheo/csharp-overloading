using System;
using System.Collections.Generic;
using System.Text;

public class Playlist
{
    private readonly List<string> tracks = new();

    public void Add(string title) => tracks.Add(title);

    private void ValidatePosition(int position)
    {
        if (position < 0 || position >= tracks.Count)
            throw new ArgumentOutOfRangeException(nameof(position), "Позиция вне диапазона.");
    }

    public string this[int position]
    {
        get
        {
            ValidatePosition(position);
            return tracks[position];
        }
        set
        {
            ValidatePosition(position);
            tracks[position] = value;
        }
    }

    public int this[string title] => tracks.IndexOf(title);

    public override string ToString()
    {
        string result = "";

        for (int i = 0; i < tracks.Count; i++)
        {
            if (i > 0)
                result += ", ";

            result += $"{i}: {tracks[i]}";
        }

        return result;
    }
}