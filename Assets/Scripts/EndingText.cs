using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class EndingText : MonoBehaviour
{
    [SerializeField] private Text endingText;
    
    private int[] bornTimes;
    private string[] galaxyNames;
    private string[] planetNames;
    private string[] raceNouns;
    private string[] raceAdjs;
    private string[] raceHabits;
    private string[] raceHobbies;

    private void Start()
    {
        bornTimes = new []
        {
            20000,
            568,
            9465,
            688,
            200 ,
            12333,
            4983,
            10,
            1,
            16661
        };

        galaxyNames = new[]
        {
            "Alpha Throne",
            "Fanta Way",
            "Retrowave Flow",
            "SHITMON 7460 (Southern Hole In The Middle Of Nowhere)",
            "Stable Stable",
            "Glorious Sphere",
            "WITH 23 (What Is This, Holy…)",
            "OK Place 34",
            "NSFW 7 (Not So Far, Whatever)",
            "NIL (Name It Later)"
        };

        planetNames = new[]
        {
            "Projecto",
            "Uno",
            "Leon",
            "Guerra",
            "Pooups",
            "Sever",
            "Planet",
            "Tenalp",
            "Esorg",
            "Forent"
        };

        raceAdjs = new[]
        {
            "Majestic",
            "Incredible",
            "Poor",
            "Pathetic",
            "Legendary",
            "Cheerful",
            "Proud",
            "Unsatisfied",
            "Little",
            "Modest",
            "Sparcling"
        };

        raceNouns = new[]
        {
            "Normies",
            "Homies",
            "Protochads",
            "Chads",
            "Dwarves",
            "Bandits",
            "Cowboys",
            "Astroboys",
            "Amazons",
            "Ponies"
        };

        raceHabits = new[]
        {
            "chill",
            "dance",
            "work hard",
            "sell ships to fish",
            "fight against common sense",
            "clean windows",
            "fry potatoes",
            "struggle", 
            "build nests",
            "hunt bats"
        };

        raceHobbies = new[]
        {
            "surf introverts",
            "eat lemons",
            "chill",
            "try something new",
            "make up calendars", 
            "listen to fluid bands",
            "ride motorbikes",
            "improve their knowledge of curse words",
            "write poems about galaxies",
            "fight crime"
        };
        
        int bornTime = bornTimes[Random.Range(0, bornTimes.Length - 1)];
        string galaxyName = galaxyNames[Random.Range(0, galaxyNames.Length - 1)];
        string raceAdj = raceAdjs[Random.Range(0, raceAdjs.Length - 1)];
        string raceNoun = raceNouns[Random.Range(0, raceNouns.Length - 1)];
        string raceHabit = raceHabits[Random.Range(0, raceHabits.Length - 1)];
        string raceHobby = raceHobbies[Random.Range(0, raceHobbies.Length - 1)];
        string planetName = planetNames[Random.Range(0, planetNames.Length - 1)];
                
        endingText.text = $"Your galaxy was born in {bornTime}BSth. Scientists have named it {galaxyName}. " +
                          $"{raceAdj} {raceNoun} live there. They {raceHabit} and like to {raceHobby} in free time. " +
                          $"Here is their planet {planetName}.";
    }
}
