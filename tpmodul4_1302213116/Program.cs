class KodePos
{
    private String[] Kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
    private String[] Kode_Pos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };

    public string GetKodePos(String Kelurahan)
    {
        foreach (String data_kelurahan in this.Kelurahan)
        {
            if(Kelurahan == data_kelurahan)
            {
                return "Kode Pos : "+Kode_Pos[Array.IndexOf(this.Kelurahan, data_kelurahan)];
            }
        }
        return "Data Tidak Ditemukan";
    }

}

class DoorMachine
{
    public enum state { TERKUNCI, TERBUKA };
    private state pintu = state.TERKUNCI;
    String[] status = { "Pintu Terkunci", "Pintu Tidak Terkunci" }; 

    public void set_status_pintu(String aksi)
    {
        switch (pintu)
        {
            case state.TERKUNCI:
                if(aksi == "BukaPintu")
                {
                    pintu = state.TERBUKA;      
                }
                Console.WriteLine(status[(int)pintu]);
            break;
            case state.TERBUKA:
                if (aksi == "KunciPintu")
                {
                    pintu = state.TERKUNCI;
                }
                Console.WriteLine(status[(int)pintu]);
            break;
        }
    }
}

public class Program
{
    public static void Main(String[] args)
    {
        KodePos kode = new KodePos();

        Console.Write("Masukan Nama Kelurahan : "); string Kelurahan = Console.ReadLine();

        Console.WriteLine(kode.GetKodePos(Kelurahan));

        DoorMachine obj = new DoorMachine();

        obj.set_status_pintu("BukaPintu");
        obj.set_status_pintu("KunciPintu");
        obj.set_status_pintu("KunciPintu");
        obj.set_status_pintu("BukaPintu");

    }  
}
