namespace TEST
{
    internal class Program
    {
        static void Main()
        {
            Player p1 = new Player();
            Cube y = new Trippe_cube();

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

            p1.money = 100;
            int player_posotion = 0;
            
            for (int i = 0; i < 10; i++)
            {
                int y_result = y.Throw_cube();
                Console.WriteLine("Throw: " + y_result);

                p1.Move(y_result);
                Console.WriteLine("P1 current x:" + p1.GetX());
                player_posotion = (int) p1.GetX();

                int abc = player_posotion % mon_filed.Length;
                mon_filed[abc].field_touch(p1);

                p1.Buy(mon_filed[abc]);
            }
            Console.WriteLine(p1.money);
            Console.ReadLine();
        }
    }
}
