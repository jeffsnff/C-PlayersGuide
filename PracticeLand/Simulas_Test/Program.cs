using System; 

namespace Simulas_Test{
  internal class Program{
    static void Main(string[] args){
      Status chestStatus = Status.Locked;
      while(true){
        Console.Write($"The Chest is {chestStatus}. What do you want to do? ");
        string userInput = Console.ReadLine();
        
        // UNLOCKS a LOCKED chest
        if(chestStatus == Status.Locked && userInput.Equals("unlock")){
          chestStatus = Status.Unlocked;
        }
        // LOCKS a UNLOCKED and CLOSED chest
        if(chestStatus != Status.Open && chestStatus != Status.Locked && userInput.Equals("lock")){
          chestStatus = Status.Locked;
        }
        // OPENS a CLOSED chest
        if(chestStatus == Status.Closed || chestStatus == Status.Unlocked && userInput.Equals("open")){
          chestStatus = Status.Open;
        }
        // CLOSES a OPENED chest
        if(chestStatus == Status.Open && userInput.Equals("close")){
          chestStatus = Status.Closed;
        }
      }
    }
  }
  enum Status { Locked, Unlocked, Closed, Open }
}
