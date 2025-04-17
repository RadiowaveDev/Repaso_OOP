using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Model
{
    public class Book
    {
        private string _title;
        public string Title
        { 
         get {  return _title; }
        set { _title = value; }
        }
        private string _author;
        public string Author 
        {
            get { return _author; }
            set { _author = value; }
        }
        private string _editorial;
        public string Editorial
        {
            get { return _editorial; }
            set { _editorial = value; }
        }
        private int _edition;
        public int Edition
        {
            get { return _editorial == null ? 0 : _edition;}
            set { _edition = value; }
        }
        private string _publicationYear;
        public string PublicationYear
        {
            get { return _publicationYear; }
            set { _publicationYear = value; }
        }
        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }  
        
        }
        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

       public Book(string _title,string _author, string _editorial, int _edition, string _publicationYear,string _category,string _state )
        {
            this._title = _title;  
            this._author = _author; 
            this._editorial = _editorial;   
            this._edition = _edition;
            this._publicationYear = _publicationYear;
            this._category = _category;
            this._state = _state;
        }

        public Book(string _title, string _author, string _publicationYear, string _category)
        {
            this._title = _title;
            this._author = _author;
            this._publicationYear = _publicationYear;
            this._category = _category;
        }

        public void toString()
        {
            Console.WriteLine("Titulo: " + _title);
            Console.WriteLine("Autor: " + _author);
            Console.WriteLine("Año de publicacion: " + _publicationYear);
            Console.WriteLine("Categoria: "+_category);
        }
    }
}
