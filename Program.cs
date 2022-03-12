class test
{
    static void Main(string[] args)
    {
        Kodebuah buah1 = new Kodebuah();
        Kodebuah.NamaBuah inputBuah = Kodebuah.NamaBuah.Apel;
        Console.WriteLine(buah1.GetKodeBuah(inputBuah));

    }
}
}