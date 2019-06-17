using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class BookInfo
    {
        private string Image;

        public string image
        {
            get { return Image; }
            set { Image = value; }
        }
        private int ISBN;
        private int ID;
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        private string bookName;
        private string bookAuthor;

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private int countIn;

        public int CountIn
        {
            get { return countIn; }
            set { countIn = value; }
        }
        private int countOut;

        public int CountOut
        {
            get { return countOut; }
            set { countOut = value; }
        }
        private string bookAbout;

        public string BookAbout
        {
            get { return bookAbout; }
            set { bookAbout = value; }
        }
        private string bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public int isbn
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

    }
}
