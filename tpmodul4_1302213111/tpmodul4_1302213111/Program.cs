// See https://aka.ms/new-console-template for more information

public class KodePos
{
    public enum Kelurahan{ Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja }

    public static int getKodePos(Kelurahan kelurahan)
    {
        int[] kode_pos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kode_pos[(int)kelurahan];
    }



    public static void Main()
    {
        KodePos kode_pos = new KodePos();
        int getKodePos = KodePos.getKodePos(KodePos.Kelurahan.Jatisari);
        Console.WriteLine(getKodePos); //kode pos seharusnya : 40286
        Console.WriteLine();
    }
}

