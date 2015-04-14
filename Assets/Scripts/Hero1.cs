using UnityEngine;
using System.Collections;

public class Hero1 : MonoBehaviour {
    private UISprite hero1;

    void Awake() { 
        hero1=this.GetComponent<UISprite>();
        string name = PlayerPrefs.GetString("hero1");
        hero1.spriteName = name;
    }
	
}
