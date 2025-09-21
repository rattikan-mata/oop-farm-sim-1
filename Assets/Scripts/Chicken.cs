using UnityEngine;

public class Chicken : Animal
{
    private int eggs;
    public int Eggs { get; private set; }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Pok! Pok!");
    }

    public void Sleep()
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{Name} just slept and feels a little hungry, but very happy!");
    }
}
