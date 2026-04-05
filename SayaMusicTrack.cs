public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        this.title = title;
        this.id = Random.Shared.Next(10000, 100000); 
        this.playCount = "0";
    }
    public void IncreasePlayCount(int count)
    {
        int currentPlayCount = int.Parse(playCount);
        currentPlayCount += count;
        playCount = currentPlayCount.ToString();
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