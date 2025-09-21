using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string name;
    private int hunger;
    private int happiness;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknow Name"; }
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

    public void Init(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
    }

    public void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
    }

    public virtual void MakeSound()
    {
        Debug.Log("Animal makes sound.");
    }

    public void Feed(int amount)
    {
        AdjustHunger(-amount);
        AdjustHappiness((amount/2));
        Debug.Log($"{Name} was fed {amount} units of food.");
    }

    public void Feed(string food, int amount)
    {
        AdjustHunger(-amount);
        AdjustHappiness((amount/2));
        Debug.Log($"{Name} was fed {amount} of {food}.");
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} -- Hunger: {Hunger} | Happiness: {Happiness}");
    }
}
