class Program
{
    static void Main(string[] args)
    {
        // create some sample videos with comments
        List<Video> _videos = new List<Video>();

        Video _video1 = new Video();
        _video1._title = "Football Club Barcelona";
        _video1._author = "Barcelona FC";
        _video1._lengthInSeconds = 60;
        _video1.AddComment("Mike Miller", "This video made my day!");
        _video1.AddComment("Jason Wafer", "I love Barcelona!");
        _video1.AddComment("Kate Anderson", "You watched that?, Messi's goal was insane.");
        _videos.Add(_video1);

        Video _video2 = new Video();
        _video2._title = "Learning Python";
        _video2._author = "Bro Code";
        _video2._lengthInSeconds = 120;
        _video2.AddComment("Gary Lee", "It's very interesting the way you explain the content.");
        _video2.AddComment("Bryant Boss", "Fascinating, this video would help me to finish my homework.");
        _video2.AddComment("Phillip Kingston", "You make Python easy, what a great way to explain it!");
        _videos.Add(_video2);

        Video _video3 = new Video();
        _video3._title = "Cooking Tutorial";
        _video3._author = "MasterChef";
        _video3._lengthInSeconds = 180;
        _video3.AddComment("Celia Mayer", "I can't wait to try this recipe, it looks delicious!");
        _video3.AddComment("Diana Collins", "This recipe is too high in fat and calories, not good for you.");
        _video3.AddComment("John Johnson", "I have a tip to make this recipe even better, add some spices!");
        _videos.Add(_video3);
        
        foreach (Video video in _videos)
        {
            video.Print();
        }
    }
}
