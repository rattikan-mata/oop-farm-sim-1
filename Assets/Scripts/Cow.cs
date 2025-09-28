using UnityEngine;

public class Cow : Animal
{
    private int milk;
    public int Milk { get; private set; }

    public void Moo()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} very happy and gives a loud MooMooMoo!");
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Mor! Mor!");
    }

    public override string Produce()
    {
        throw new System.NotImplementedException();
    }
}
