using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Videos
    {
        // Private fields
        private string title;
        private string author;
        private int length; // Video length in seconds
        private List<Comment> messages; // List to store comments/messages

        // Constructor
        public Videos(string title, string author, int length)
        {
            this.title = title;
            this.author = author;
            this.length = length;
            this.messages = new List<Comment>(); // Initialize the list of comments
        }

        // Properties
        public string Title => title;
        public string Author => author;
        public int Length => length;

        // Method to add a comment
        public void AddComment(Comment comment)
        {
            messages.Add(comment);
        }

        // Method to get the number of comments
        public int GetNumberOfComments()
        {
            return messages.Count;
        }

        // Method to get all comments
        public List<Comment> GetMessages()
        {
            return messages;
        }
    }
}
