using BookLoanApp.Modals;

namespace BookLoanApp.Data
{
    public class SeedingData
    {

        public static void Seed(IApplicationBuilder appBuilder)
        {
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                var dBContext = serviceScope.ServiceProvider.GetService<AppDBContext>();

                if (!dBContext.Books.Any())
                {
                    dBContext.AddRange(new Book
                    {

                        BookName = "Harry potter and the philosopher's stone",
                        ImageCoverURL = "https://m.media-amazon.com/images/I/815v2OuIHXL._AC_UF1000,1000_QL80_.jpg",
                        Author = "J.K. Rowling",
                        Available = true,
                        DateAdded = DateTime.Now.AddDays(-10)

                    },

                    new Book
                    {
                        BookName = "The hobbit - An unexpected journey.",
                        ImageCoverURL = "https://d2iltjk184xms5.cloudfront.net/uploads/photo/file/81835/original.jpg",
                        Author = "J.R.R. Tolkien",
                        Available = false,
                        DateAdded = DateTime.Now
                    },


                    new Book
                    {
                        BookName = "Pippi Långstrump",
                        ImageCoverURL = "https://www.rabensjogrenagency.se/files/101660_29692464_o_1.png-393x512.jpeg",
                        Author = "Astrid Lindgren",
                        Available = true,
                        DateAdded = DateTime.Now.AddDays(-30)
                    }


                    );

                    dBContext.SaveChanges();
                }
            }
        }
    }
}
