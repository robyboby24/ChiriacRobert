using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarrior : BaseClass
{
    public BaseWarrior()
    {
        ClassName = "Warrior";
        Health = 10;
        Strength = 5;
        Intelligent = 2;
        Agillity = 3;
        Damage = Strength * 5;
        Shoot = false;
    }
}
