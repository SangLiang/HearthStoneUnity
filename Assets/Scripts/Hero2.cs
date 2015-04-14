using UnityEngine;
using System.Collections;

public class Hero2 : MonoBehaviour {
    private UISprite hero1;

    void Awake()
    {
        hero1 = this.GetComponent<UISprite>();
        string name = PlayerPrefs.GetString("hero2");
        hero1.spriteName = name;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
