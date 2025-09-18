using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;

public class GameManager : MonoBehaviour
{
    private string chickName;
    private string cowName;

    public List<Chicken> chickenPrefabs;
    public List<Chicken> chickens = new List<Chicken>();
    public Chicken currentChicken;

    public List<Cow> cowPrefabs;
    public List<Cow> cows = new List<Cow>();
    public Cow currentCow;

    void Start()
    {
        /*Chicken chicken = new Chicken("Clucky", 20, 20);
        chickName = chicken.Name;

        Cow cow = new Cow("Milky", 20, 20);
        cowName = cow.Name;*/

        GameStart();

        /*chicken.GetStatus();
        chicken.MakeSound();
        chicken.Feed("corn");
        chicken.GetStatus();
        chicken.Sleep();
        chicken.GetStatus();

        cow.GetStatus();
        cow.MakeSound();
        cow.Feed("grass");
        cow.GetStatus();
        cow.Moo();
        cow.GetStatus();*/

    }

    private void GameStart()
    {
        Debug.Log("*** WELCOME to FARM SIM ***");
        Debug.Log($"{chickName} and {cowName} are living in the farm.");
    }
}
