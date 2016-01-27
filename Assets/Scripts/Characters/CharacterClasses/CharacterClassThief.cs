using UnityEngine;
using System.Collections;

public class CharacterClassThief : CharacterClassBase {

	public CharacterClassThief()
    {
        this.CharacterClassName = "Thief";
        this.CharacterClassDescription = "Masters of stealth and poison";
        this.BaseDex = 10;
        this.BaseHealth = 50;
        this.BasePower = 20;
        this.BaseStr = 2;
        this.BaseInt = 5;
    }
}
