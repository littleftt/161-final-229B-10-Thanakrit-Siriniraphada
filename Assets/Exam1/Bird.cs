using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = 0.3f;
    private float weight = 0.7f;

    private void Start()
    {
        Init("Bird");
        DisplayName();
        MakeSound();
        CalculateFoodRequirement();
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} make sound: Chip! Chip!");
    }
    public override float CalculateFoodRequirement()
    {
        float foodRequirement = (dailyFoodConsumption * weight * 7);
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg per day and weight {weight} kg.");
        Debug.Log($"{animalName} eats {dailyFoodConsumption} weekly food requirement is {foodRequirement} kg.");
        return foodRequirement;
    }
}
