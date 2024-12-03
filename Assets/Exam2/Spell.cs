using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    private void Start()
    {
        Cast();
    }
    public virtual void Cast()
    {
        Debug.Log($"Spell Simulation Start");
    }

    public void Cast(string enemy)
    {
        Debug.Log($"Spell target on {enemy}");
    }
    public void Cast(string enemy, int damage)
    {
        Debug.Log($"Casting Spell on {enemy}. Deal damage {damage}"); 
    }
}
