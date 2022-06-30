using System;
using System.Collections.Generic;
using System.Text;

namespace PostUI
{
    class Post
    {
        public readonly string Title;
        public string Description { get; private set; }

        public readonly DateTime TimeCreated;

        public int UpVotes;

        public int DownVotes;

        public Post(string title, string description)
        {
            Title = title;
            TimeCreated = DateTime.Now;
            SetDescription(description);
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public void UpVote()
        {
            UpVotes++;
        }

        public void DownVote()
        {
            DownVotes++;
        }
    }
}
