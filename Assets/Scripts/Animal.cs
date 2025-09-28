using UnityEngine;

public enum FoodType
{
    Grain,
    Hay,
    Cereal,
    RottenFood,
    AnimalFood
}

public abstract class Animal : MonoBehaviour
{
    private string name;

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknow Name"; }
            else name = value;
        }
    }

    public int Hunger { get; private set; }

    public int Happiness { get; private set; }

    public FoodType PreferedFood { get; private set; }

    public void Init(string newName)
    {
        Name = newName;
        Hunger = Mathf.Clamp(50, 0, 100);
        Happiness = Mathf.Clamp(50, 0, 100);
    }

    public void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} -- Hunger: {Hunger} | Happiness: {Happiness}");
    }

    public void Feed(int amount)
    {
        AdjustHunger(-amount);
        AdjustHappiness((amount/2));
        Debug.Log($"{Name} was fed {amount} units of food. | Current Happiness: {Happiness} | Current Hunger: {Hunger}");
    }

    public void Feed(FoodType foodType, int amount)
    {
        AdjustHunger(-amount);
        AdjustHappiness((amount/2));
        Debug.Log($"{Name} was fed {amount} of {foodType}.");
    }

    public abstract void MakeSound();

    public abstract string Produce();


}
