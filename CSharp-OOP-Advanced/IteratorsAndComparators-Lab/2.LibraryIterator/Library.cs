using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    public Library(params Book[] books)
    {
        this.Books = new List<Book>(books);
    }

    public List<Book> Books { get; set; }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.Books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        public LibraryIterator(IEnumerable<Book> books)
        {
            this.books = new List<Book>(books);
        }

        private IReadOnlyList<Book> books;
        private int currentIndex;

        public Book Current => this.books[currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose() {}

        public bool MoveNext()
        {
            this.currentIndex++;

            return this.currentIndex < this.books.Count;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }
    }
}