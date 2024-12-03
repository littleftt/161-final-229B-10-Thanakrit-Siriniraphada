using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("Fire Spirit");
        Cast("Fire Spirit", 30);
    }
    public override void Cast()
    {
        Debug.Log($"Casting IceBullet! Welcome to Christmas!!!");
    }
}
