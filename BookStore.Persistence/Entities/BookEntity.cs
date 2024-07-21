using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Persistence.Entities
{
    public class BookEntity
    {
        public const int MAX_TITLE_LENGTH = 250;
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Price { get; set; }
    }
}
