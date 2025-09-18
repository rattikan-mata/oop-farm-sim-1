using UnityEngine;

public class Animals : MonoBehaviour
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

    public virtual void Init(string newName, int newHunger, int newHappiness)
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

    public void Feed(string food)
    {
        AdjustHunger(-15);
        AdjustHappiness(10);
        Debug.Log($"{Name} enjoyed the {food}.");
    }
}
