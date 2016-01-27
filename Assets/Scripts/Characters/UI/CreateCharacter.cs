using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateCharacter : MonoBehaviour {

    private CharacterBase newCharacter;
    private int SelectedClass = 0;
    private List<CharacterClassBase> classList;
    private string[] classNames;

    // Use this for initialization
    void Start () {
        newCharacter = new CharacterBase();
        classList = new List<CharacterClassBase>();
        classList.Add(new CharacterClassThief());
        classList.Add(new CharacterClassIceMage());
        classList.Add(new CharacterClassFireMage());

        classNames = new string[classList.Count];
        for(int i = 0; i < classList.Count; i++)
        {
            classNames[i] = classList[i].CharacterClassName;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUILayout.BeginVertical("Box");
        SelectedClass = GUILayout.SelectionGrid(SelectedClass, classNames, 1);
        if (GUILayout.Button("Select Class"))
            Debug.Log("You chose " + classList[SelectedClass].CharacterClassName);
        GUILayout.EndVertical();
    }
}
