using System;

class Program
{
    static void Main(string[] args)
    {
        Cars car = new Cars("Renault", "Clio", "Yellow", 6);
        car.carİnfo();
    }
}
public class Cars
{
    public Cars(string marka, string model,string renk, int kapisayisi)
    {
        _marka= marka;
        _model= model;
        _color= renk;
        DoorNumber= kapisayisi;
    }
    public string _marka { get; set; }
    public string _model { get; set; }
    public string _color { get; set; }
    private int _doorNumber;
    public int DoorNumber
    {

        get
        {
            return _doorNumber;
        }
        set 
        {
            if (value != 2 && value != 4)
            {
                Console.WriteLine("Door number must be 2 or 4!");
                _doorNumber--;
            }
            else
            {
                _doorNumber = value;
            }
        }
    }
        
    public void carİnfo()
    {
        Console.WriteLine("Arabanın Markası : " + " " + _marka + "Arabanın Modeli " + " " + _model + " " + "Arabanın Rengi " + " " + _color + " " + "Araç Kapı Sayısı : " + " " + DoorNumber );
    }

}