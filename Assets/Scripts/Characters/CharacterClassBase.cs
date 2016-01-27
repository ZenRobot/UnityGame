using UnityEngine;
using System.Collections;

public class CharacterClassBase : MonoBehaviour {

    private string _characterClassName;
    private string _characterClassDescription;

    private int _baseHealth;
    private int _basePower;
    private int _baseStr;
    private int _baseDex;
    private int _baseInt;

    private int _healthLevelModifier;
    private int _powerLevelModifier;
    private int _strLevelModifier;
    private int _dexLevelModifier;
    private int _intLevelModifier;

    public string CharacterClassName {
        get { return _characterClassName; }
        set { _characterClassName = value; }
    }

    public string CharacterClassDescription {
        get { return _characterClassDescription; }
        set { _characterClassDescription = value; }
    }

    public int BaseHealth {
        get { return _baseHealth; }
        set { _baseHealth = value; }
    }

    public int BasePower {
        get { return _basePower; }
        set { _basePower = value; }
    }

    public int BaseStr {
        get { return _baseStr; }
        set { _baseStr = value; }
    }

    public int BaseDex {
        get { return _baseDex; }
        set { _baseDex = value; }
    }

    public int BaseInt {
        get { return _baseInt; }
        set { _baseInt = value; }
    }

    public int HealthLevelMod { get { return _healthLevelModifier; } }
    public int PowerLevelMod { get { return _powerLevelModifier; } }
    public int StrLevelMod { get { return _strLevelModifier; } }
    public int DexLevelMod { get { return _dexLevelModifier; } }
    public int IntLevelMod { get { return _intLevelModifier; } }
}
