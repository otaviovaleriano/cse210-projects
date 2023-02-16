public class ForeignDvd : Dvd
{

    private string _language;

    public Dvd(string language)
    {
        _language = language;
    }

    // public void ShowDvdDetails()
    // {
    //     Console.WriteLine($"{_serialNumber}:- {_title}");
    // }
}