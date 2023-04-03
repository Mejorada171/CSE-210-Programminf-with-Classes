class Program
{
    static void Main(string[] args)
    {
        // create some sample videos with comments
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1.Title = "Football Club Barcelona";
        video1.Author = "Barcelona FC";
        video1.LengthInSeconds = 60;
        video1.AddComment("Mike Miller", "This video made my day!");
        video1.AddComment("Jason Wafer", "I love Barcelona!");
        video1.AddComment("Kate Anderson", "You watched that?, Messi's goal was insane.");
        videos.Add(video1);

        Video video2 = new Video();
        video2.Title = "Learning Python";
        video2.Author = "Bro Code";
        video2.LengthInSeconds = 120;
        video2.AddComment("Gary Lee", "It's very interesting the way you explain the content.");
        video2.AddComment("Bryant Boss", "Fascinating, this video would help me to finish my homework.");
        video2.AddComment("Phillip Kingston", "You make Python easy, what a great way to explain it!");
        videos.Add(video2);

        Video video3 = new Video();
        video3.Title = "Cooking Tutorial";
        video3.Author = "MasterChef";
        video3.LengthInSeconds = 180;
        video3.AddComment("Celia Mayer", "I can't wait to try this recipe, it looks delicious!");
        video3.AddComment("Diana Collins", "This recipe is too high in fat and calories, not good for you.");
        video3.AddComment("John Johnson", "I have a tip to make this recipe even better, add some spices!");
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            video.Print();
        }
    }
}
