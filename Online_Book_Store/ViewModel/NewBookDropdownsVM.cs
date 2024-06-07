﻿using Online_Book_Store.Models;

namespace Online_Book_Store.ViewModel
{
    public class NewBookDropdownsVM
    {
        public List<Author> Authors {get; set; }

        public List<Publisher> Publisher{get; set; }
   
        public NewBookDropdownsVM() 
        {
          Authors= new List<Author>();
     
          Publisher= new List<Publisher>();
        
        }
    }
     
}
