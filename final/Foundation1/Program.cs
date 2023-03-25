class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Hello", "Adele", 240);
        video1.AddComment("Mauricio", "Amazing song!!!");
        video1.AddComment("Samantha", "I am in love with your voice!!!");
        
        Video video2 = new Video("Learning C#", "Prof Guanabara", 6800);
        video2.AddComment("Davi", "Very helpful, thanks!");
        video2.AddComment("Lorenzo", "I'll be waiting for more tutorials.");
        video2.AddComment("Maria", "I learned a lot from this video, thanks!");

        Video video3 = new Video("The semester is Over, what now?", "Kefera", 300);
        video3.AddComment("Cleusa", "I am soo excited for the end of the semester!!!");
        video3.AddComment("Julio", "I am failing in all my classes, Help me!.");
        video3.AddComment("Marcos", "I am already done with my finals...");

        Video video4 = new Video("Hunt for Profit MS 500+", "Tibia Emprego", 1040);
        video4.AddComment("Otavio", "I wanna learn this hunt!!!");
        video4.AddComment("David", "I died in this same hunt respawn...");

        // Create list of videos and add the videos and comments above in it.
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            List<Comment> comments = video.GetComments();
            foreach (Comment comment in comments)
            {
                Console.WriteLine("- " + comment.GetCommenterName() + ": " + comment.GetCommentText());
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}