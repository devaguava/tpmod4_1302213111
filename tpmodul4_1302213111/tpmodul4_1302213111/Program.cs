// See https://aka.ms/new-console-template for more information

public class KodePos
{
    public enum Kelurahan{ Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja }

    public static int getKodePos(Kelurahan kelurahan)
    {
        int[] kode_pos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kode_pos[(int)kelurahan];
    }

    public class DoorMachine
    {
        enum State { Terkunci, Terbuka }

        public static void Main()
        {
            KodePos kode_pos = new KodePos();
            int getKodePos = KodePos.getKodePos(KodePos.Kelurahan.Jatisari); // misalnya menggunakan kelurahan Jatisari
            Console.WriteLine("Kode Pos Kelurahan "+Kelurahan.Jatisari+" adalah "+getKodePos+Environment.NewLine); //kode pos seharusnya : 40286

            State state = State.Terkunci;
            string[] screenName = { "Pintu Terkunci", "Pintu Tidak Terkunci" };
            while (state != null)
            {
                Console.WriteLine(screenName[(int)state]);
                Console.Write("Enter Command : ");

                String command = Console.ReadLine();
                switch (state)
                {
                    case State.Terkunci:
                        if (command == "Kunci Pintu")
                            state = State.Terkunci;
                        else if (command == "Buka Pintu")
                            state = State.Terbuka;
                        else
                        {
                            state = State.Terkunci;
                            Console.WriteLine("Command Salah");
                        }
                        Console.WriteLine(Environment.NewLine);
                        break;

                    case State.Terbuka:
                        if (command == "Buka Pintu")
                            state = State.Terbuka;
                        else if (command == "Kunci Pintu")
                            state = State.Terkunci;
                        else
                        {
                            state = State.Terbuka;
                            Console.WriteLine("Command Salah");
                        }
                        Console.WriteLine(Environment.NewLine);
                        break;
                }

            }
        }

    }

    
}

