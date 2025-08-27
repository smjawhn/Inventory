using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name { get; private set; }
    public int MaxHP { get; private set; }
    public int RequireExp { get; private set; }
    public int Exp { get; private set; }
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Cri { get; private set; }
    public int Gold { get; private set; }
    public int Level { get; private set; }

    public Character (string name, int level, int requireExp, int exp, int attack, int maxhp, int defense, int critical, int gold)
    {
        Name = name;
        Level = level;
        RequireExp = requireExp;
        Exp = exp;
        Atk = attack;
        MaxHP = maxhp;
        Def = defense;
        Cri = critical;
        Gold = gold;
    }
}
