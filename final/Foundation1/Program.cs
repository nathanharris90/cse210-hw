using System;
using System.Collections.Generic; // You need to include this for List

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            _title = "How to eat a cake",
            _author = "Billy",
            _length = 83
        };
        video1.AddComment(new Comment { _name = "Billy", _commentText = "Great video!" });
        video1.AddComment(new Comment { _name = "Cat Lover", _commentText = "Very informative." });
        video1.AddComment(new Comment { _name = "Billy", _commentText = "Great video!" });
        video1.AddComment(new Comment { _name = "Cat Lover", _commentText = "Very informative." });

        Video video2 = new Video
        {
            _title = "Documentary",
            _author = "Professor D",
            _length = 1004
        };
        video2.AddComment(new Comment { _name = "Billy", _commentText = "Great video!" });
        video2.AddComment(new Comment { _name = "Cat Lover", _commentText = "Very informative." });
        video2.AddComment(new Comment { _name = "Billy", _commentText = "Great video!" });
        video2.AddComment(new Comment { _name = "Cat Lover", _commentText = "Very informative." });

        Video video3 = new Video
        {
            _title = "Trip to Paris",
            _author = "Miss Handle",
            _length = 12
        };
        video3.AddComment(new Comment { _name = "Billy", _commentText = "Great video!" });
        video3.AddComment(new Comment { _name = "Cat Lover", _commentText = "Very informative." });
        video3.AddComment(new Comment { _name = "Billy", _commentText = "Great video!" });
        video3.AddComment(new Comment { _name = "Cat Lover", _commentText = "Very informative." });

        Video video4 = new Video
        {
            _title = "Cat Video",
            _author = "Catman",
            _length = 112
        };
        video4.AddComment(new Comment { _name = "Billy", _commentText = "Great video!" });
        video4.AddComment(new Comment { _name = "Cat Lover", _commentText = "Very informative." });
        video4.AddComment(new Comment { _name = "Billy", _commentText = "Great video!" });
        video4.AddComment(new Comment { _name = "Cat Lover", _commentText = "Very informative." });

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}