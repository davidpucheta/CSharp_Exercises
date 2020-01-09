using System;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post
            {
                Title = "Post title",
                Description = "Body of post..."
            };

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.DownVote();
            post.DownVote();

            post.PostInfo();
        }
    }
}
