using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List <int> sayiList = new List<int>();

        sayiList.Add(23);
        sayiList.Add(10);
        sayiList.Add(4);
        sayiList.Add(5);
        sayiList.Add(92);
        sayiList.Add(34);

        List<string> renkList = new List<string>();

        renkList.Add("kırmızı");
        renkList.Add("mavi");
        renkList.Add("turuncu");
        renkList.Add("sarı");
        renkList.Add("yeşil");

        //count
        Console.WriteLine(sayiList.Count);
        Console.WriteLine(renkList.Count);

        foreach (var sayi in sayiList)
        {
            Console.WriteLine(sayi);
        }
        foreach (var renk in renkList)
        {
            Console.WriteLine(renk);
        }
        sayiList.ForEach(sayi=>Console.WriteLine(sayi));
        renkList.ForEach(renk=>Console.WriteLine(renk));

        // listeden eleman çıkarma
        sayiList.Remove(4);
        renkList.Remove("yeşil");

        sayiList.ForEach(sayi=>Console.WriteLine(sayi));
        renkList.ForEach(renk=>Console.WriteLine(renk));

        sayiList.RemoveAt(0);
        renkList.RemoveAt(1);

        sayiList.ForEach(sayi=>Console.WriteLine(sayi));
        renkList.ForEach(renk=>Console.WriteLine(renk));

        // Liste içerisinde arama

        if(sayiList.Contains(10)){
            Console.WriteLine("10 liste içerisinde bulundu");
        }
        // Eleman ile index e erişme
        Console.WriteLine(renkList.BinarySearch("sarı"));

        // diziyi List'e dönüştürme
        string[] hayvanlar={"kedi, köpek, kuş"};
        List<string> hayvalarListesi=new List<string>(hayvanlar);

        // listeyi temizleme

        hayvalarListesi.Clear();

        // liste içerisinde nesne tutma
        List<Kullanıcılar> kullanıcıListesi= new List<Kullanıcılar>();
        Kullanıcılar kullanıcı1= new Kullanıcılar();
        kullanıcı1.Isim="Ayşe";
        kullanıcı1.Soyadı="Yılmaz";
        kullanıcı1.Yas=26;

        Kullanıcılar kullanıcı2=new Kullanıcılar();
        kullanıcı2.Isim="Özcan";
        kullanıcı2.Soyadı="Çalışkan";
        kullanıcı2.Yas=27;

        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);

        List<Kullanıcılar> yeniListe=new List<Kullanıcılar>();
        yeniListe.Add(new Kullanıcılar(){
            Isim="Deniz",
            Soyadı="Arda",
            Yas=24
        });

        foreach (var kullanıcı in kullanıcıListesi)
        {
            Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
            Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyadı);
            Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Yas);
        }

        yeniListe.Clear();
    }
}

public class Kullanıcılar{
    private string isim;
    private string soyadı;
    private int yas;

    public string Isim { get=> isim; set=>isim=value;}

    public string Soyadı {get=>soyadı; set=>soyadı=value;}
    public int Yas { get=>yas; set=>yas=value;}

}