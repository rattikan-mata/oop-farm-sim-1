using UnityEngine;

public class Cow : Animals
{
    private int milk;
    public int Milk { get; private set; }

    public override void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
        Milk = 0;
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} moaning Mooorrr");
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
