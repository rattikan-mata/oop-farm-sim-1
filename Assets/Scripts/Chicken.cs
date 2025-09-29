using UnityEngine;

public class Chicken : Animal
{
    public int Eggs { get; private set; }

    public override void Init(string name)
    {
        base.Init(name);
        PreferedFood = FoodType.Grain;
        Eggs = 0;
    }

    public void Sleep()
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{Name} just slept and feels a little hungry, but very happy! | Current Happiness: {Happiness} | Current Hunger: {Hunger}");
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Cluck! Cluck!");
    }

    public override string Produce()
    {
        if (Happiness >= 80)
        {
            Eggs += 3;
            Debug.Log($"{Name} produced 3 eggs, Total Eggs: {Eggs} eggs");
        }
        else if (Happiness > 50 && Happiness < 80)
        {
            Eggs += 2;
            Debug.Log($"{Name} produced 2 eggs, Total Eggs: {Eggs} eggs");
        }
        else
        {
            Debug.Log($"{Name} produced 0 eggs, Total Eggs: {Eggs} eggs");
        }
        return $"Total Eggs: {Eggs} eggs";
    }
}
