using System;

namespace CSharp_Net_module1_2_1_lab {
    public interface ILibraryUser {
        void AddBook(string book);
        bool RemoveBook(string book);
        string BookInfo(int index);
        int BookCount();
    }
}
