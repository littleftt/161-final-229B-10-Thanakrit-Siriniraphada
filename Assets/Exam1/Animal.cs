using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public void Init(string name)
    {
        animalName = name;
    }
    public abstract float CalculateFoodRequirement();
    public virtual void MakeSound()
    {
        Debug.Log($"{animalName} make sound like this.");
    }
    public void DisplayName()
    {
        Debug.Log($"It is {animalName}");
    }
}
