using Wordle.Api.Data;

namespace Wordle.Api.Services;

public class PlayerService
{
    private AppDbContext _context;
    public PlayerService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Player> GetPlayers()
    {
            return _context.Players
                .AsEnumerable()
                .OrderBy(item => item.AverageGuesses)
                .Reverse();
    }

    public void Update(string name, int guesses, int seconds)
    {
        if(guesses < 1 || guesses > 6){
            throw new ArgumentException("Guesses must be between 1 and 6");
        }
        if(seconds < 1)
        {
            throw new ArgumentException("Seconds must be greater than 0");
        }
        
        Player player = _context.Players.First(item => item.Name.CompareTo(name) == 0);
        if (player != null)
        {
            double aggregateGuesses = (player.AverageGuesses * player.GameCount) + guesses;
            int aggregateSeconds = (player.AverageSecondsPerGame * player.GameCount) + seconds;
            player.GameCount += 1;
            player.AverageGuesses = aggregateGuesses / player.GameCount;
            player.AverageSecondsPerGame = aggregateSeconds / player.GameCount;
        }
        else
            _context.Players.Add(new Player()
            {
                PlayerId = _context.Players.ToArray().Length,
                Name = name,
                GameCount = 1,
                AverageGuesses = guesses,
                AverageSecondsPerGame = seconds
            });
        
        _context.SaveChanges();
    }
}