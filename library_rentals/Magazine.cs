public class Magazine : Loanable {

    private string _edition;
    private string _title;
    private string _releaseDate;


    public Magazine( string title, string edition, string date)
    {
        _title = title;
        _edition = edition;        
        _releaseDate = date;

    }

    public void ShowMagazineDetails()
    {
        Console.WriteLine($"{_title}: {_edition} - {_releaseDate}");
    }
}