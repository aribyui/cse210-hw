using System.IO;
public class GoalManager
{
    private List<Goals> _goals;
    private int _score;  

    // test
    private SimpleGoal simpleGoal;
    private EternalGoal eternalGoal;
    private ChecklistGoal checklistGoal;  

    // constructor
    public GoalManager()
    {
        _goals = new List<Goals>();
        _score = 0;
    }

    // methods
    public void Start()
    {
        int option = 0;

        while (option != 6)
        {
            Console.WriteLine($"\nYour have {_score} points\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                CreateGoal();
            }
            else if (option == 2)
            {   
                ListGoalnames();
            }
            else if (option == 3)
            {
                
                SaveGoals();
            }
            else if (option == 4)
            {
                LoadGoals();             
            }
            else if (option == 5)
            {
                RecordEvent();
            }
            else
            {
                Console.WriteLine("\nThanks for using the Eternal Quest Program.\n");
            }  
        }
    }
    
    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalnames()
    {
        int i = 0;

        foreach (Goals g in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {g.GetDetailString()}");
            
        }
    }

    public void ListGoalDetails()
    {
        
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int number = int.Parse(Console.ReadLine());
        
        string name;
        string description;
        int points;
        int target;
        int bonus;

        switch (number)
        {            
            case 1:
                Console.Write("What is your name of your goal? ");
                name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine()); 

                simpleGoal = new SimpleGoal(name, description, points);

                _goals.Add(simpleGoal);

                break;

            case 2:
                Console.Write("What is your name of your goal? ");
                name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine()); 

                eternalGoal = new EternalGoal(name, description, points);

                _goals.Add(eternalGoal);

                break;

            case 3:
                Console.Write("What is your name of your goal? ");
                name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine()); 

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                bonus = int.Parse(Console.ReadLine());

                checklistGoal = new ChecklistGoal(name, description, points, target, bonus);

                 _goals.Add(checklistGoal);

                break;

            default:
                Console.WriteLine("Try again.");

                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");

        int number = 0;

        foreach (Goals g in _goals)
        {
            number++;
            Console.WriteLine($"{number}. {g.GetName()}"); 
            /* 
            output: 
            1. Give a talk
            2. Study the scriptures
            3. Attend the temple
            */
        }

        Console.Write("Which goal did you accomplish? ");
        int option = int.Parse(Console.ReadLine());

        if (option >= 1 && option <= number)
        {   
            // si el usuario selecciona 1, option - 1 se traducirá a 0, lo que significa que se accederá al primer elemento en la lista. 
            // si el usuario selecciona 2, option - 1 se traducirá a 1, lo que significa que se accederá al segundo elemento, y así sucesivamente.
            Goals goalType = _goals[option - 1]; 

            goalType.RecordEvent(); // Registra el evento en el objetivo

            _score += goalType.GetPoints(); // Actualiza el puntaje

            Console.WriteLine($"Congratulations! You have earned {_score} points!");
        }
        else
        {
            Console.WriteLine("Invalid option. Please select a valid goal number.");
        }        
   }



    public void SaveGoals()
    {
        Console.Write("What is the file name of the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            outputFile.WriteLine(_score);

            foreach (Goals g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name of the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);        

        foreach (string line in lines)
        {
            /* 
            Verifica si el archivo contiene la cantidad de puntos y si tiene al menos una línea

            En esta línea se está realizando una comprobación para asegurarse de que el arreglo 
            lines contiene al menos una línea de texto. Se verifica que la propiedad Length del arreglo 
            lines sea mayor que cero, lo que indica que el archivo tiene contenido.
            */
            if (lines.Length > 0)
            {
                // Se crea la variable loadedScore para almacenar la cantidad de puntos que se va a cargar desde el archivo
                int loadedScore;

                // Se utiliza int.TryParse() para intentar convertir el primer elemento del arreglo lines 
                // (que debería contener la cantidad de puntos) en un número entero. 
                //  Si la conversión es exitosa, se asigna el valor convertido a loadedScore.
                if (int.TryParse(lines[0], out loadedScore))
                {
                    _score = loadedScore;  // Asigna la cantidad de puntos leída a _score
                }
            }

            string[] parts = line.Split(":");

            // string typeGoal = parts[0];

            // Console.WriteLine(goal);
            /*
            output:
            SimpleGoal
            EternalGoal
            ChecklistGoal
            */

            for (int i = 1; i < parts.Length; i++)           
            {
                string goalData = parts[i];

                // Console.WriteLine(goalData);
                /*
                output:
                Give a talk,Speak in Sacrament meeting when asked,100,False
                Study the scriptures,Study the scriptures for at least 10 minutes,50
                Attend the temple,Attend and perform any ordinance,50,500,3,0
                */

                string[] splitDataByCommas = goalData.Split(",");
                /*
                output:
                Give a talk,
                Speak in Sacrament meeting when asked,
                100,
                False
                */

                int length = splitDataByCommas.Length;
                // Console.WriteLine(length);
                /*
                output:
                4
                3
                6
                */

                string name;
                string description;
                int points;
                bool isComplete;
                int bonus;
                int target;
                int amount;

                if  (length == 4)              
                {
                    name = splitDataByCommas[0];
                    description = splitDataByCommas[1];
                    points = int.Parse(splitDataByCommas[2]);
                    isComplete = bool.Parse(splitDataByCommas[3]);

                    // Console.WriteLine($"{name} ({description})");
                    // output: Give a talk (Speak in Sacrament meeting when asked)

                    simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                }
                else if (length == 3)
                {
                    name = splitDataByCommas[0];
                    description = splitDataByCommas[1];
                    points = int.Parse(splitDataByCommas[2]);

                    // Console.WriteLine($"{name} ({description})");
                    // output: Study the scriptures (Study the scriptures for at least 10 minutes)

                    eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                else // if length == 6
                {
                    name = splitDataByCommas[0];
                    description = splitDataByCommas[1];
                    points = int.Parse(splitDataByCommas[2]);
                    bonus = int.Parse(splitDataByCommas[3]);
                    target = int.Parse(splitDataByCommas[4]);
                    amount = int.Parse(splitDataByCommas[5]);

                    // Console.WriteLine($"{name} ({description}) -- Currently completed: {amount}/{target}");
                    // output: Attend the temple (Attend and perform any ordinance) -- Currently completed: 0/3

                    checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);
                }

            }
        }
    }


}