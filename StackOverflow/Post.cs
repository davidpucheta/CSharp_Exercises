using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow
{
    class Post
    {
        private int _votes;
        private readonly DateTime _creationDateTime;
        public string Title { get; set; }
        public string Description { get; set; }


        public Post()
        {
            _votes = 0;
            _creationDateTime = DateTime.Now;
        }

        public void UpVote()
        {
            _votes += 1;

        }

        public void DownVote()
        {
            _votes -= 1;
        }

        public int CurrentVotes()
        {
            return _votes;
        }

        public void PostInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Votes: {CurrentVotes()}");
            Console.WriteLine($"Date of creation: {_creationDateTime}");
        }

    }
}
