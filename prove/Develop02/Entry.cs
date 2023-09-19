using System.Collections;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _userInput;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_userInput}");
    }

    public override string ToString()
    {
        /*
        Procedimiento para invalidar el método ToString (Guía de programación de C#)
        link: https://bit.ly/3t4ndsg

        Cada clase o struct de C# hereda implícitamente la clase Object. 
        Por consiguiente, cada objeto de C# obtiene el método ToString, 
        que devuelve una representación de cadena de ese objeto.

        Para reemplazar el método ToString en una clase o struct:
        1. Declare un método ToString con los modificadores y el tipo de valor devuelto siguientes:

        public override string ToString(){}

        Implemente el método para que devuelva una cadena.

        En el ejemplo siguiente, se devuelve el nombre de la clase, además 
        de los datos específicos de una instancia concreta de la clase.

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return "Person: " + Name + " " + Age;
            }
        }
        */
        return $"{_date},{_prompt},{_userInput}";   
    }   
}