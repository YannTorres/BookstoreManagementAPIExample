namespace BookstoreManagementAPI.Comunication.Requests;

public class RequestUpdateBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genders { get; set; } = string.Empty;
    public double Price { get; set; }
    public int QuantityInStock { get; set; }
}
