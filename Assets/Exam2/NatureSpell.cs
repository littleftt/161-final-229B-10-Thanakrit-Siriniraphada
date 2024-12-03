using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("Nymph");
        Cast("Nymph", 25);
        Cast("Teammate", 30f);
    }
    public override void Cast()
    {
        Debug.Log($"Casting Nature Spirit! Become Ranger!!!");
    }
    public void Cast(string target, float heal)
    {
        Debug.Log($"Casting Spell on {target}. Heal amount {heal}");
    }
}
