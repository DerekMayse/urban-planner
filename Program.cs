using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building vampireStateBuilding = new Building("1313 Mockingbird Lane"){
                Stories = 1000,
                Width = 1000.67,
                Depth = 1000.87
            };

            vampireStateBuilding.Designer("Steve Brule");
            vampireStateBuilding.Construct(DateTime.Now);
            vampireStateBuilding.Purchase("Json Doe");
            
             

             Building howlsMovingCastle = new Building ("where ever you want baby"){
                 Stories = 42,
                 Width = 42.42,
                 Depth = 42.42
             };

             howlsMovingCastle.Designer("Mike Hunt");
             howlsMovingCastle.Construct(DateTime.Now);
             howlsMovingCastle.Purchase("Bart Man");

             Console.WriteLine(vampireStateBuilding.makeBuilingReport());

            
           
        }
    }
}
