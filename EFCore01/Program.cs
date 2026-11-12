namespace EFCore01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            bool isCreated = dbContext.Database.EnsureCreated();

            if (isCreated)
            {
                Console.WriteLine(
                    "Database created successfully!");
            }
            else
            {
                Console.WriteLine(
                    "Database already exists!");
            }
        }
    }
}
