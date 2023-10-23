using System;

class Program
{
    static void Main(string[] args)
    {   
        // Lecture Event
        Console.Clear(); 

        Address address1 = new Address("Av. Fundidora No. 501", "Monterrey", "Nuevo León", "México");
        
        Lectures lecture = new Lectures("Lectures", "The gift of Anger: And other lessons from my grandfather, Mahatma Gandhi.", "Arun Gandhi was only twelve years old when his parents left him in the care of his grandfather. For Arun, the man was just another family member, but the time he spent with Gandhi was one of self-discovery and timeless teachings about identity, anger, unity, and peace. The gift of Anger relates the daily life of the most famous and most beloved Indian philosopher through the eyes of a child.", "October 14th, 2023", "5:00 pm", address1, "Arun Gandhi", 200);
        Console.WriteLine(lecture.StandardDetailsMessage());

        Console.ReadLine(); // pause, press enter to continue

        Console.Clear();
        Console.WriteLine(lecture.GetLectureFullDetailsMessage());
        
        Console.ReadLine(); // pause, press enter to continue

        Console.Clear();
        Console.WriteLine(lecture.ShortDescriptionMessage());

        Console.ReadLine(); // pause, press enter to continue


        // Reception Event
        Console.Clear();

        Address address2 = new Address("Carretera Nacional 2700 Col. Valle De Cristal", "Monterrey", "Nuevo León", "México");

        Receptions reception = new Receptions("Receptions", "Wedding", "It is my pleasure to invite you to our wedding. We would be profoundly delighted with your presence. Receptions after service.", "December 15th, 2023", "5:00 pm", address2, "johndoe@unknown.com");
        Console.WriteLine(reception.StandardDetailsMessage());
        
        Console.ReadLine(); // pause, press enter to continue

        Console.Clear();
        Console.WriteLine(reception.GetReceptionsFullDetailsMessage());

        Console.ReadLine(); // pause, press enter to continue

        Console.Clear();
        Console.WriteLine(reception.ShortDescriptionMessage());

        Console.ReadLine(); // pause, press enter to continue


        // Outdoor Event
        Console.Clear();

        Address address3 = new Address("Av Eloy Cavazos, Jardines de La Pastora, 67140", "Guadalupe", "Nuevo León", "México");

        Outdoors outdoor = new Outdoors("Outdoors", "Festival del antojo", "The event's mission is to bring together, over a weekend, the best food trucks, restaurants, desserts, and snacks in each city.", "October 15th, 2023", "12:00 pm", address3, "Sunny");
        Console.WriteLine(outdoor.StandardDetailsMessage());

        Console.ReadLine(); // pause, press enter to continue

        Console.Clear();
        Console.WriteLine(outdoor.GetOutdoorsFullMessage());

        Console.ReadLine(); // pause, press enter to continue

        Console.Clear();
        Console.WriteLine(outdoor.ShortDescriptionMessage());

        Console.ReadLine(); // pause, press enter to continue
    }
}