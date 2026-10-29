namespace TEST
{
    internal class Program
    {
        static void Main()
        {
            Player p1 = new Player("Player 1", 500 );
            Player p2 = new Player("Player 2", 500);
            Player p3 = new Player("Player 3", 500);
            Player p4 = new Player("Player 4", 500);

            Player[] players = { p1, p2, p3, p4 };

            Cube cube = new Cube();
            Cube double_c = new Double_cube();
            Cube tripple_c = new Trippe_cube();
            Cube random_c = new Random_cube();

            Cube[] cubes = { cube, double_c, tripple_c, random_c };

            Field[] mon_filed = new Field[10];

            mon_filed[0] = new Field("A1",10);
            mon_filed[1] = new Field("A2",20);
            mon_filed[2] = new Field("A3",30);
            mon_filed[3] = new Field("B1",10);
            mon_filed[4] = new Field("B2",5);
            mon_filed[5] = new Field("B3",60);
            mon_filed[6] = new Field("C1",10);
            mon_filed[7] = new Field("C2",5);
            mon_filed[8] = new Field("C3",20);
            mon_filed[9] = new Field("Finish", 100);

            int turns = 10;


            for (int i = 0; i < turns; i++)
            {
                for (int j = 0; j < players.Length; j++)
                {
                    Player currentPlayer = players[j];
                    Cube currentCube = cubes[j];

                    Console.WriteLine("\n" + currentPlayer.p_Name);

                    int y_result = currentCube.Throw_cube();
                    Console.WriteLine("Throw: " + y_result);

                    currentPlayer.Move(y_result);

                    Console.WriteLine("Current position: " + currentPlayer.GetX());

                    int player_posotion = (int)currentPlayer.GetX();
                    int abc = player_posotion % mon_filed.Length;
                    mon_filed[abc].field_touch(currentPlayer);
                    currentPlayer.Buy(mon_filed[abc]);

                    Console.WriteLine("Money: " + currentPlayer.money);
                    Console.WriteLine("Purchased fields: " + currentPlayer.PurchasedFields);
                }
            }


            Console.WriteLine("\n__________Results_________");
            int maxFields = 0;

            //Результати кожного гравця
            foreach (Player player in players)
            {
                Console.WriteLine(player.p_Name);
                Console.WriteLine("Money: " + player.money);
                Console.WriteLine("Purchased fields: " + player.PurchasedFields);

                if (player.PurchasedFields > maxFields)
                {
                    maxFields = player.PurchasedFields;
                }
            }
            //Переможці
            Console.WriteLine("\n______Winer______");

            if (maxFields == 0)
            {
                Console.WriteLine("Nobody purchased any fields.");
            }
            else
            {
                foreach (Player player in players)
                {
                    if (player.PurchasedFields == maxFields)
                    {
                        Console.WriteLine(player.p_Name + " purchased the most fields: " + maxFields);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
