using UnityEngine;
using System.Collections;

public class CharacterClassFireMage : CharacterClassBase {

    public CharacterClassFireMage()
    {
        this.CharacterClassName = "Fire Mage";
        this.CharacterClassDescription = "A magic user that controls fire and heat";
        this.BaseDex = 2;
        this.BaseHealth = 30;
        this.BasePower = 50;
        this.BaseStr = 2;
        this.BaseInt = 10;
    }
}
