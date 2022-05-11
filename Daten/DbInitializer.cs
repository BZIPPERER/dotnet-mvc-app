using gameapplication.Models;
using gameapplication.Daten;

namespace gameapplication
{
    public class DbInitializer
    {
        public DbInitializer
        (){
            
        }

        public static void Initialize(GameContext context)
        {
            if (context.Games.Any())
            {
                return;
            }
            var games = new List<Game>
            {
                new Game{Name="Super Mario Bros"},
                new Game{Name="The Legend of Zelda"},
                new Game{Name="Metroid"},
                new Game{Name="Donkey Kong Country"}
            };
            games.ForEach(g => context.Games.Add(g));
            context.SaveChanges();
        }
    }

}