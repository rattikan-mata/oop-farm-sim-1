using UnityEngine;

public class Cow : Animal
{
    private int milk;
    public int Milk { get; private set; }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Mor! Mor!");
    }

    public void Moo()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} very happy and gives a loud MooMooMoo!");
    }
}
