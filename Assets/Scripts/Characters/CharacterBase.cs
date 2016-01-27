using UnityEngine;
using System.Collections;

public class CharacterBase : MonoBehaviour {

    private CharacterClassBase _characterClass;
    private int _level;
    private int _maxHealth;
    private int _maxPower;
    private int _health;
    private int _power;
    private int _str;
    private int _dex;
    private int _int;

    public CharacterClassBase CharacterClass
    {
        get { return _characterClass; }
        set
        {
            _characterClass = CharacterClass;
            _maxHealth = _characterClass.BaseHealth;
            _maxPower = _characterClass.BasePower;
            _health = _maxHealth;
            _power = _maxPower;
            _str = _characterClass.BaseStr;
            _dex = _characterClass.BaseDex;
            _int = _characterClass.BaseInt;
        }
    }

    public int Level { get { return _level; } }
    public int MaxHealth { get { return _maxHealth; } }
    public int MaxPower { get { return _maxPower; } }
    public int Health { get { return _health; } }
    public int Power { get { return _power; } }
    public int Str { get { return _str; } }
    public int Dex { get { return _dex; } }
    public int Int { get { return _int; } }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
