using System;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post();

            post.Title = "Post title";
            post.Description = "Body of post...";

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.DownVote();
            post.DownVote();

            Console.WriteLine($"Title: {post.Title}");
            Console.WriteLine($"Description: {post.Description}");
            Console.WriteLine($"Votes: {post.CurrentVotes()}");


        }
    }
}
