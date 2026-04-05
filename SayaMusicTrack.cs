using System.Diagnostics;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        try
        {
            Debug.Assert(title != null, "Title cannot be null");
            Debug.Assert(title.Length < 100, "Title must be shorter than 100 characters");
            this.title = title;
            this.id = Random.Shared.Next(10000, 100000);
            this.playCount = "0";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating music track: {ex.Message}");
        }
    }
    public void IncreasePlayCount(int count)
    {
        try
        {
            Debug.Assert(count > 0, "Play count increment must be positive");
            Debug.Assert(count <= 10000000, "Play count cannot exceed 10,000,000");
            checked
            {
                int currentPlayCount = int.Parse(playCount);
                currentPlayCount += count;
                playCount = currentPlayCount.ToString();
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Play count overflow: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error increasing play count: {ex.Message}");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("Track Details:");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
        Console.WriteLine("-------------------------");
    }
}