﻿namespace Online_Book_Store.Models;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageURL { get; set; }

    public List<Book> Books { get; set; }
}
