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
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public FoodType PreferedFood { get; protected set; }

    public virtual void Init(string name)
    {
        Name = name;
        Hunger = 50;
        Happiness = 50;
    }

    public void AdjustHunger(int amount)
    {
        Hunger = Mathf.Clamp(Hunger + amount, 0, 100);
    }

    public void AdjustHappiness(int amount)
    {
        Happiness = Mathf.Clamp(Happiness + amount, 0, 100);
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} --> Hunger: {Hunger} | Happiness: {Happiness} | Prefered Food: {PreferedFood}");
    }

    public void Feed(int amount)
    {
        AdjustHunger(-amount);
        AdjustHappiness((amount/2));
        Debug.Log($"{Name} was fed {amount} units of generic food. Current Happiness: {Happiness} | Current Hunger: {Hunger}");
    }

    public void Feed(FoodType foodType, int amount)
    {
        if (foodType == PreferedFood)
        {
            AdjustHunger(-amount);
            AdjustHappiness(15);
            Debug.Log($"{Name} was fed {amount} units of prefered food: {PreferedFood}, Very Happy! Happiness increased 15 units | Current Happiness: {Happiness} | Current Hunger: {Hunger}");
        }
        else if (foodType == FoodType.RottenFood)
        {
            AdjustHappiness(-20);
            Debug.Log($"{Name} was fed with rotten food: RottenMeat, Unhappy! Happiness decreased 20 units | Current Happiness: {Happiness} | Current Hunger: {Hunger}");
        }
        else
        {
            Feed(amount);
        }
    }

    public abstract void MakeSound();
    public abstract string Produce();


}
