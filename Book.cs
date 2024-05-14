﻿namespace BookstoreManagementAPI;

public class Book
{

    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genders { get; set; } = string.Empty;
    public double Price {  get; set; }
    public int QuantityInStock { get; set; }

}
