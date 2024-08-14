
public struct Ogrenci
{
    public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet)
    {
        Numara = numara;
        Adi = adi;
        Soyadi = soyadi;
        Cinsiyet = cinsiyet;
    }

    public int Numara { get; set; } //property -özellik

    public string Adi { get; set; }   //PROP yaz tab tab yap geliyor      

    public string Soyadi { get; set; }

    public bool Cinsiyet { get; set; }

    //override /ezmek/geçersiz kılmak

    public override string ToString()
    {
        return $"{Numara,-5} " +
            $"{Adi,-6}" +
            $" {Soyadi,-10} " +
           string.Format("{0,-8}", Cinsiyet == true ? "bay" : "bayan");


    }
}