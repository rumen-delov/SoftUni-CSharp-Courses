using System;

namespace Articles
{
    class Program
    {
        public class Article
        {
            // Properties         
            public string Title { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }


            // Methods
            public void Edit(string newContent)
            {
                Content = newContent;
                // also an option
                //this.Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }

            public void Rename(string newTitle)
            {
                Title = newTitle;
            }

            // The base class method overrides the derived class method, when they share the same name.
            // However, C# provides an option to override the base class method, by
            // adding the "virtual" keyword to the method inside the base class, and by
            // using the "override" keyword for each derived class methods
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            // Instantiate an article and initialize it
            Article article = new Article
            {
                Title = articleData[0],
                Content = articleData[1],
                Author = articleData[2]
            };

            // Number of commands which will follow
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandParts = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandParts[0];
                string argument = commandParts[1];

                if (command == "Edit")
                {
                    article.Edit(argument);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(argument);
                }
                else
                {
                    article.Rename(argument);
                }
            }

            // Override the method ToString() in the class to print the object
            Console.WriteLine(article);
            // or
            //Console.WriteLine(article.ToString());
        }
    }
}
