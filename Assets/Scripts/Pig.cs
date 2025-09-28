using UnityEngine;

public class Pig : Animal
{
    private int pork;
    public int Pork { get; private set; }
    public override void MakeSound()
    {
        Debug.Log($"{Name} says Quack! Quack!");
    }

    public override string Produce()
    {
        throw new System.NotImplementedException();
    }
}