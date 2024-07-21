using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models
{
    public class Book
    {
        public const int MAX_TITLE_LENGTH = 250;
        public Guid Id { get; }
        public string Title { get; }
        public string Description { get; }
        public uint Price { get; }

        public Book(Guid id, string title, string description, uint price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public static (Book Book, string Error) Create(Guid id, string title, string description, uint price)
        {
            var error = string.Empty;
            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
            {
                error = "Title is empty";
            }

            var book = new Book(id, title, description, price);

            return (book, error);
        }
    }
}
