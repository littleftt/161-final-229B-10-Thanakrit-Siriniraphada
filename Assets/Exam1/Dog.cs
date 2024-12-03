using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal

{
    private float dailyFoodConsumption = 3f;
    private int activityLevel = 5;

    private void Start()
    {
        Init("Dog");
        DisplayName();
        MakeSound();
        CalculateFoodRequirement();
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} make sound: Woof! Woof!");
    }
    public override float CalculateFoodRequirement()
    {
        float foodRequirement = (dailyFoodConsumption * activityLevel * 7);
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg per day and weight {activityLevel} kg.");
        Debug.Log($"{animalName} eats {dailyFoodConsumption} weekly food requirement is {foodRequirement} kg.");
        return foodRequirement;
    }
}
