public class Dvd : Loanable
{

    private string _serialNumber;
    private string _title;

    public Dvd(string sn, string title)
    {
        _serialNumber = sn;
        _title = title;
    }

    public void ShowDvdDetails()
    {
        Console.WriteLine($"{_serialNumber}:- {_title}");
    }
}