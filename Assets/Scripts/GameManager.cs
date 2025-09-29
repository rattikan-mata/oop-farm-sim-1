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

        currentAnimal = Chicken;
        currentAnimal.Init("Clucky");
        animals.Add(currentAnimal);

        currentAnimal = Cow;
        currentAnimal.Init("Milky");
        animals.Add(currentAnimal);

        currentAnimal = Pig;
        currentAnimal.Init("Piggy");
        animals.Add(currentAnimal);

        Debug.Log($"== There are {animals.Count} animals living in the farm ==");

        foreach (var animal in animals)
        {
            animal.GetStatus();
        }

        Chicken.MakeSound();
        Chicken.Feed(5);
        Chicken.Sleep();

        Cow.MakeSound();
        Cow.Feed(5);
        Cow.Moo();

        Pig.MakeSound();
        Pig.Feed(5);

        Chicken.Feed(FoodType.Grain, 10);
        Chicken.Produce();

        Cow.Feed(FoodType.Hay, 10);
        Cow.Produce();

        Pig.Feed(FoodType.Cereal, 10);
        Pig.Produce();

        Chicken.Feed(FoodType.AnimalFood, 10);
        Chicken.Produce();
        Chicken.Feed(FoodType.RottenFood, 10);
        Chicken.Produce();
        Chicken.Feed(FoodType.RottenFood, 10);
        Chicken.Produce();
        Chicken.Feed(150);
        Chicken.Produce();
    }
}
