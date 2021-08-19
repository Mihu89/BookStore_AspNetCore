using BookStoreSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Repos
{
    public interface IBookRepo
    {
        IQueryable<Book> Books { get; }
    }
}
