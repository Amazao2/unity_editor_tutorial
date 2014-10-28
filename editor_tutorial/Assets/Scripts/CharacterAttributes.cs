using UnityEngine;
using System.Collections;

public enum CharacterClass { Thief, Wizard, Warrior }

public class CharacterAttributes : MonoBehaviour {

    // character type
    public CharacterClass characterClass;

    // character level is based on exp
    public int experience;
    public int level
    {
        get { return experience / 750; }
    }

    // main attributes
    public int stamina;
    public int agility;
    public int intelligence;

    // attributes based on main attributes
    public int maxHealth
    {
        get { return stamina * 5;  }
    }
    public int maxMana
    {
        get { return intelligence * 10; }
    }
    public int maxEnergy
    {
        get { return agility * 15; }
    }

}
