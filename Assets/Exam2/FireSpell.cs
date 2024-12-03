using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("Orc");
        Cast("Orc", 20);
    }
    public override void Cast()
    {
        Debug.Log($"Casting Fireball! Burn baby burn!!!");
    }

}
