using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms
{
    public class BookLibrary
    {
        public class Authors
        {
            public int AuthorId { get; set; }
            public string AuthorName { get; set; }
            public string AuthorEmail { get; set; }

            public List<Books> bookli=new List<Books>();
        }

        public class BookCategory
        {
            public int BookCategoryId { get; set; }
            public string BookCategoryName { get; set; }

            public List<Authors> authors=new List<Authors>();
                
        }

        public class Books
        {
            public int BookId { get; set; }
            public string BookName { get; set; }
        }

        public static void Main(string[] args)
        {
            List<BookCategory> bookCategories = new List<BookCategory>()
            {
                new BookCategory
                {
                    BookCategoryId=01,
                    BookCategoryName="Mystery",

                    authors =
                    {
                        new Authors
                        {
                            AuthorId=1301,
                            AuthorName="Dan Brown",
                            AuthorEmail="browndan@gmail.com",

                            bookli =
                            {
                                new Books{BookId=111,BookName="The Da Vinci Code"},
                                new Books{BookId=112,BookName="Angels & Demons"},
                            }

                        },
                        new Authors
                        {
                            AuthorId=1320,
                            AuthorName="Agatha Christie",
                            AuthorEmail="agathachristie@gmail.com",


                            bookli =
                            {
                                new Books{BookId=123,BookName="And Then There Were None"},
                            }
                        }




                    },

                },
                 new BookCategory
                 {
                     BookCategoryId=02,
                     BookCategoryName="Science Fiction",

                     authors =
                     {
                         new Authors
                         {
                             AuthorId=3214,
                             AuthorName="George Orwell",
                             AuthorEmail="georgeorwell@gmail.com",

                             bookli=
                             {
                                new Books{BookId=456,BookName="Nineteen Eighty-Four"}
                             }
                         },
                         new Authors
                         {
                             AuthorId=6544,
                             AuthorName="Frank Herbert",
                             AuthorEmail="frankherbert@gmail.com",

                             bookli =
                             {
                                 new Books{BookId=789,BookName="Dune"}
                             }
                         },
                         new Authors
                         {
                             AuthorId=9512,
                             AuthorName="Douglas Adams",
                             AuthorEmail="douglasadams@gmail.com",

                             bookli=
                             {
                                 new Books{ BookId=753,BookName="The Hitchhiker's Guide to the Galaxy"}
                             }
                         }
                     },
                 },

                 new BookCategory
                 {
                     BookCategoryId=09,
                     BookCategoryName="War",

                     authors =
                     {
                         new Authors
                         {
                             AuthorId=9632,
                             AuthorName="Eric Maria Remarque",
                             AuthorEmail="eric123@gmail.com",

                             bookli=
                             {
                                 new Books{BookId=532,BookName="All Quiet on the Western Front"},
                             }

                              
              
                         },

                         new Authors
                         {
                             AuthorId=5986,
                             AuthorName="Jack Higgins",
                             AuthorEmail="jack123@gmail.com",

                             bookli =
                             {
                                 new Books{BookId=654,BookName="The Eagle Has Landed"},
                             }
                         },
                     }
                 },

            };

            foreach(BookCategory bc in bookCategories)
            {
                Console.WriteLine("Book Category Id: "+bc.BookCategoryId);
                Console.WriteLine("Book Category Name: " + bc.BookCategoryName);
                Console.WriteLine("\n");

                foreach(Authors a in bc.authors)
                {
                    Console.WriteLine("    Author ID: " + a.AuthorId);
                    Console.WriteLine("    Author Name: " + a.AuthorName);
                    Console.WriteLine("    Author Email: " + a.AuthorEmail);
                    Console.WriteLine("\n"); 
                    

                    foreach(Books b in a.bookli)
                    {
                        Console.WriteLine("         Book Id: " + b.BookId);
                        Console.WriteLine("         Book Name: " + b.BookName);
                        Console.WriteLine("\n");
                    }
                }
            }

        }
        
    }



}
   
