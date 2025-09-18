using UnityEngine;

public class Chicken : Animals
{
    private int eggs;
    public int Eggs { get; private set; }

    public override void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
        Eggs = 0;
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} crows Pok! Pok!");
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} -- Hunger: {Hunger} | Happiness: {Happiness} | Total Eggs: {Eggs}");
    }

    public void Sleep()
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{Name} just slept and feels a little hungry, but very happy!");
    }
}
