using UnityEngine;

public class Cow : Animal
{
    public float Milk { get; private set; }

    public override void Init(string name)
    {
        base.Init(name);
        PreferedFood = FoodType.Hay;
        Milk = 0;
    }

    public void Moo()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} very happy and gives a loud MooMooMoo! | Current Happiness: {Happiness} | Current Hunger: {Hunger}");
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Mor! Mor!");
    }

    public override string Produce()
    {
        if (Happiness > 70)
        {
            Milk += (Happiness/10f);
            Debug.Log($"{Name} produced {Happiness/10f} units of Milk, Total Milk: {Milk} units");
        }
        else
        {
            Debug.Log($"{Name} produced 0 units of Milk, Total Milk: {Milk} units");
        }
        return $"Total Milk: {Milk} units";
    }
}
