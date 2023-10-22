using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Video 1
        Video video1 = new Video("Esto No Es una Elegía", "Silvio Rodríguez", 180);
        
        Comment comment1 = new Comment("@gaeluliseschavez4129", "Realmente al escuchar a Silvio mi mente se alimenta.");
        Comment comment2 = new Comment("@aidamoreno3942", "Profundo, sublime, hermoso y claro, y poético, revolucionario, consecuente como todo lo de Silvio.");

        video1.AddComment(comment1);
        video1.AddComment(comment2);

        // Video 2
        Video video2 = new Video("Al Principio Del Final (Lyric Video)", "Reyno Banda", 255.6);

        Comment comment4 = new Comment("@alexiahuerta1118", "Una noche lluviosa y esa canción si te lleva a otro mundo");
        Comment comment5 = new Comment("@urielbeetdrawn3773", "La pura verdad! Reyno me ha acompañado a traves de un proceso de sanación! Gracias!");
        Comment comment6 = new Comment("@hugoabelrodriguezrivas7198", "Me encanta esta banda, me recuerda mucho a la magia que Gustavo Cerati le daba a sus canciones!");
        
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        // Video 3
        Video video3 = new Video("Tu Vida Mi Vida (Official Video)", "Fito Paez", 249.6);

        Comment comment7 = new Comment("@HectorFarago", "Si el mundo escuchara mas esta poesía, seria mejor!!");
        Comment comment8 = new Comment("@ricardoforero7843", "Fito: Cada vez que el amor explota en tu corazón, tu música hace brotar flores en nuestros oídos.");
        Comment comment9 = new Comment("@nathanbrandao9770", "Mestre da música mundial! Continue emocionando o mundo! Bravo Bravo!");
        Comment comment10 = new Comment("@deboramorochogonzalez7811", "Bien dicen que el amor nos lleva al origen de uno mismo. Grande Fito, no paro de escuchar este adictivo y hermoso tema.");

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);

        List<Video> _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video v in _videos)
        {
            v.Display();
        }    

        Console.WriteLine(); // line break
    }
}