using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab {
    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    //TODO: ILibraryUser interface declaration was moved to the separate .cs file

    //Exception class, to determinate when a limit of books is reached for this user
    class BookLimitIsReachedException : ApplicationException {
        public BookLimitIsReachedException() { }
        public BookLimitIsReachedException(string description) : base(description) { }
    }

    // 2) declare class LibraryUser, it implements ILibraryUser
    class LibraryUser : ILibraryUser {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Id { get; private set; }
        public string Phone { get; set; }
        public int BookLimit { get; private set; }

        // 4) declare field (bookList) as a string array
        private List<String> bookList = new List<string>();
        private const int DefaultBookLimit = 10;
        private static int nextId = 1;

        // 5) declare indexer BookList for array bookList
        public string this[int index] {
            //List indexer throws ArgumentOutOfRangeException if index is out of range
            get { return bookList[index]; }
            set { bookList[index] = value; }
        }

        // 6) declare constructors: default and parameter
        public LibraryUser(): this("UndefinedFirstName","UndefinedLastName") { }

        public LibraryUser(string firstName, string lastName) : this(firstName, lastName, DefaultBookLimit) { }

        public LibraryUser(string firstName, string lastName, int bookLimit) {
            Id = nextId++;
            FirstName = firstName;
            LastName = lastName;
            BookLimit = bookLimit;
        }
        
        // 7) declare methods: 
        //AddBook() – add new book to array bookList,
        public void AddBook(string book) {
            if (BookLimit <= BookCount()) {
                throw new BookLimitIsReachedException("Can't add a book to a list. Book limit is reached for this user.");
            }
            bookList.Add(book);
        }
        //RemoveBook() – remove book from array bookList,
        //This method removes only the first occurrence of a book from the list
        //To remove all of them, we can write a method, that will use List<T>.RemoveAll(Predicate<T>) method
        public bool RemoveBook(string book) {
            return bookList.Remove(book);
        }

        //BookInfo() – returns book info by index,
        public string BookInfo(int index) {
            return this[index];
        }

        //BooksCout() – returns current count of books
        public int BookCount() {
            return bookList.Count;
        }

        public override string ToString() {
            return "Id: "+Id+
                ", First name: "+FirstName+
                ", Last name: "+LastName+
                ", Phone: "+Phone+
                ", Book limit: "+BookLimit;
        }
    }
}
