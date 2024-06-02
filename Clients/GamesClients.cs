using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClients
{

   private readonly List<GameSummary> games = [
  new(){
    Id = 1,
    Name = "Lol",
    Genre = "Fighting",
    Price = 19.99M,
    ReleaseDate = new DateOnly(1992, 7, 15)
  },
   new(){
    Id = 2,
    Name = "Lole",
    Genre = "Fightingvv",
    Price = 349.99M,
    ReleaseDate = new DateOnly(1992, 6, 15)
  },
   new(){
    Id = 3,
    Name = "POPL",
    Genre = "Yes",
    Price = 190.99M,
    ReleaseDate = new DateOnly(1992, 7, 06)
  }
  ];

public GameSummary[] GerGames() => [.. games];
}
