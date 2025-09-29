using UnityEngine;

public class Pig : Animal
{
    public int Pork { get; private set; }

    public override void Init(string name)
    {
        base.Init(name);
        PreferedFood = FoodType.Cereal;
        Pork = 0;
    }
    public override void MakeSound()
    {
        Debug.Log($"{Name} says Oink! Oink!");
    }

    public override string Produce()
    {
        if (Happiness >= 80)
        {
            Pork += 3;
            Debug.Log($"{Name} produced 3 pieces of Pork, Total Pork: {Pork} pieces");
        }
        else if (Happiness >= 60 && Happiness < 80)
        {
            Pork += 2;
            Debug.Log($"{Name} produced 2 pieces of Pork, Total Pork: {Pork} pieces");
        }
        else if (Happiness > 40 && Happiness < 60)
        {
            Pork += 1;
            Debug.Log($"{Name} produced 1 pieces of Pork, Total Pork: {Pork} pieces");
        }
        else
        {
            Debug.Log($"{Name} produced 0 pieces of Pork, Total Pork: {Pork} pieces");
        }
        return $"Total Pork: {Pork} pieces";
    }
}