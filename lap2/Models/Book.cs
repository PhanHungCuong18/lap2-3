using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lap2.Models
{
    public class Book
    {

        private int id;
        private string title;
        private string author;
        private string image_cover;

        public Book()
        {
        }
        public Book(int id, string title, string author, string image_cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_cover = image_cover;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "Tieu De Khong Duoc Trong")]
        [StringLength(250, ErrorMessage = "Tieu De khong duoc vuot qua 250")]
        [Display(Name = "Tieu De")]
        

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ImageCover
        {
            get { return image_cover; }
            set { image_cover = value; }
        }
    }
}