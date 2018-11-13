using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model
{
    static class Generate
    {
        static Random rand = new Random((int)DateTime.Now.Ticks);

        static string[] firstNames = { "Abner", "Adam", "Adelbert",
                                  "Alexander ", "Andrew ", "Benjamin",
                                  "Bruce", "Christian", "Christopher",
                                  "David", "Dennis","Edgar",
                                  "Felix","Garrett","Herman",
                                  "Homer","Jeffrey","Kevin",
                                  "Adolfo","Alvin","Alex",
                                  "Arthur","Barry","Brian",
                                  "Ben","Boris","Brendon",
                                  "Billy","Chester","Carlos",
                                  "Clayton","Curt","Cedric",
                                  "Damian","Dominique","Dorian",
                                  "Drew","Dillon","Daron",
                                  "Eddy","Erick","Erasmo",
                                  "Emilio","Fletcher","Federico",
                                  "Freddy","Fernando","Gerald",
                                  "Gabriel","Gordon","Giuseppe",
                                  "Henry","Hugo","Jack",
                                  "Jimmy","Mason","Maxwell"
        };

        static string[] lastNames = { "Wayne", "Smith","Guerrero",
                                 "Ernesto","Xiao","Hungary",
                                 "Johson","Williams","Miller",
                                 "Davis","Clark","Walker",
                                 "Allen","Scott","Evans",
                                 "Baker","Harris","Lee",
                                 "Kline","Russell","George",
                                 "Bradley","Woodward","Bailey",
                                 "Underwood","Hale","Marsh",
                                 "Mcclain","Lutz","Stanton",
                                 "Kelly","Green","Schroeder",
                                 "Abbott","Snyder","Mathis",
                                 "Walls","Patrick","Hodges",
                                 "Gentry","Ritter","Mahoney"
        };

        static string[] middleNames = { "Dawn", "Fawn","Aryn",
                                 "Jacklyn","Jae","Jaidyn",
                                 "Kathryn","Krystan","Lee",
                                 "Ice Cube", "Snoop Dogg", "Ice-T",
                                 "Lynn", "Hawk", "Mae",
                                 "Kraken","Sue","Cobra",
                                 "Diablo","Doom","Zero",
                                 "Blair","Blaise","Blake",
                                 "Manticore","Mothman","Furor",
                                 "Fury","Ire","Mania",
                                 "Manic","Atilla","Terminator",
                                 "Napoleon","Hannibal","Leonidas",
                                 "Agrippa","Suleiman","Blanche",
                                 "Love","Bleed","Skeleton",
                                 "Footslam","Tooth",
                                 "Kneecap","Taye","Rylie",
                                 "Destroyer","Hitter","Exterminator"
        };

        static string[] citizenships = {"Afghanistan", "Albania", "Argentina",
                                     "Armenia", "Australia", "Bulgaria	",
                                     "Canada", "China", "Colombia",
                                     "Congo","Cuba","Egypt",
                                     "Germany","India","Israel",
                                     "Italy","Japan","Kenya",
                                     "Latvia","Luxembourg","Maldives",
                                     "Malta","Mexico","Monaco",
                                     "Nigeria","Panama","Poland",
                                     "Portugal","Romania","Serbia",
                                     "Slovakia","Singapore","Spain",
                                     "Thailand","Tunisia","Uganda",
                                     "Uruguay","Yemen","Zambia",
                                     "Zimbabwe","Uzbekistan","United States",
                                     "Ukraine","Turkmenistan","Tunisia",
                                     "Togo","Timor-Leste","Switzerland" };

        static string[] knowledgeOfLanguages = {"English",  "Spanish, English", "Arabic, English",
                                             "German","Arabic, German","German, English",
                                             "Polish, German","German, Russian","Russian, English",
                                             "Ukraine, Polish","Polish, English","Polish, Russian",
                                             "English, Ukraine","Ukraine, Russian, English","German, Russian",
                                             "France, Ukraine","English, France","Spanish",
                                             "France, Russian","English, Spanish","France, Russian, Ukraine" };

        static (string p1, string p2)[] photos =
        {
            (@"..\..\..\photo\1ф.jpg", @"..\..\..\photo\1п.jpg"),
            (@"..\..\..\photo\2ф.jpg", @"..\..\..\photo\2п.jpg"),
            (@"..\..\..\photo\3ф.jpg", @"..\..\..\photo\3п.jpg"),
            (@"..\..\..\photo\4ф.jpg", @"..\..\..\photo\4п.jpg"),
            (@"..\..\..\photo\5ф.jpg", @"..\..\..\photo\5п.jpg"),
            (@"..\..\..\photo\6ф.jpg", @"..\..\..\photo\6п.jpg"),
            (@"..\..\..\photo\7ф.jpg", @"..\..\..\photo\7п.jpg"),
            (@"..\..\..\photo\8ф.jpg", @"..\..\..\photo\8п.jpg"),
            (@"..\..\..\photo\9ф.jpg", @"..\..\..\photo\9п.jpg"),
            (@"..\..\..\photo\10ф.jpg", @"..\..\..\photo\10п.jpg"),
            (@"..\..\..\photo\11ф.jpg", @"..\..\..\photo\11п.jpg"),
            (@"..\..\..\photo\12ф.jpg", @"..\..\..\photo\12п.jpg"),
            (@"..\..\..\photo\13ф.jpg", @"..\..\..\photo\13п.jpg"),
            (@"..\..\..\photo\14ф.jpg", @"..\..\..\photo\14п.jpg"),
            (@"..\..\..\photo\15ф.jpg", @"..\..\..\photo\15п.jpg")
        };

        static public (string p1, string p2) GetPhotos()
        {
            return photos[rand.Next(0, photos.Length - 1)];
        }

        static public string GetFirstNameTextBox()
        {
            return firstNames[rand.Next(0, firstNames.Length - 1)];
        }

        static public string GetLastNameTextBox()
        {
            return lastNames[rand.Next(0, lastNames.Length - 1)];
        }

        static public string GetMiddleNameTextBox()
        {
            return middleNames[rand.Next(0, middleNames.Length - 1)];
        }

        static public string GetCitizenshipTextBox()
        {
            return citizenships[rand.Next(0, citizenships.Length - 1)];
        }

        static public string GetKnowledgeOfLanguageTextBox()
        {
            return knowledgeOfLanguages[rand.Next(0, knowledgeOfLanguages.Length - 1)];
        }
        static public string GetDateOfBirth()
        {
            return $"{rand.Next(1,31)}.{rand.Next(1,12)}.{rand.Next(1960, 2018)}";
        }
    }
}
