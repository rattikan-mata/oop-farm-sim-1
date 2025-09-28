using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;

public class GameManager : MonoBehaviour
{
    public Chicken Chicken;
    public Cow Cow;
    public Pig Pig;

    public List<Animal> animals = new List<Animal>();
    private Animal currentAnimal;

    void Start()
    {
        Debug.Log("*** WELCOME to FARM SIM ***");

        /*currentAnimal = Chicken;
        currentAnimal.Init("Clucky", 25, 25);
        animals.Add(currentAnimal);

        currentAnimal = Cow;
        currentAnimal.Init("Milky", 20, 20);
        animals.Add(currentAnimal);

        currentAnimal = Pig;
        currentAnimal.Init("Daeky", 15, 15);
        animals.Add(currentAnimal);

        Debug.Log($"== There are {animals.Count} animals living in the farm ==");

        foreach (var animal in animals)
        {
            animal.GetStatus();
        }

        animals[0].MakeSound();
        animals[0].Feed(5);

        animals[1].MakeSound();
        animals[1].Feed(5);

        animals[2].MakeSound();
        animals[2].Feed(5);

        animals[0].Feed(0, 10);
        ((Chicken)animals[0]).Sleep();
        animals[0].GetStatus();

        animals[1].Feed(1, 10);
        ((Cow)animals[1]).Moo();
        animals[1].GetStatus();

        animals[2].Feed(2, 10);
        animals[2].GetStatus();*/
    }
}
