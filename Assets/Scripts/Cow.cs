using UnityEngine;

public class Cow
{
    private string name;
    private int hunger;
    private int happiness;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknow Cow"; }
            else name = value;
        }
    }

    public int Hunger
    {
        get { return hunger; }
        set
        {
            if (value < 0) hunger = 0;
            else if (value > 50) hunger = 50;
            else hunger = value;
        }
    }

    public int Happiness
    {
        get { return happiness; }
        set
        {
            if (value < 0) happiness = 0;
            else if (value > 50) happiness = 50;
            else happiness = value;
        }
    }

    public int Milk { get; private set; }

    public Cow(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Milk = 0;
    }

    public void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} moaning Mooorrr");
    }

    public void Feed(string food)
    {
        AdjustHunger(-15);
        AdjustHappiness(10);
        Debug.Log($"{Name} enjoyed the {food}.");
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} -- Hunger: {Hunger} | Happiness: {Happiness} | Total Milk: {Milk}");
    }

    public void Moo()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} very happy and gives a loud MooMoo!");
    }
}
