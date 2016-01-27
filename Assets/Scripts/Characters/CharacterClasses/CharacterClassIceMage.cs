using UnityEngine;
using System.Collections;

public class CharacterClassIceMage : CharacterClassBase {

    public CharacterClassIceMage()
    {
        this.CharacterClassName = "Ice Mage";
        this.CharacterClassDescription = "A magic user that controls cold and ice";
        this.BaseDex = 2;
        this.BaseHealth = 30;
        this.BasePower = 50;
        this.BaseStr = 2;
        this.BaseInt = 10;
    }
}
