using UnityEngine;
using System.Collections;

public class VS_Show : MonoBehaviour {

    public static VS_Show _instance;
    public TweenScale vsTween;
    public TweenPosition hero1Tween;
    public TweenPosition hero2Tween;

    void Awake() {
        _instance = this;
        this.gameObject.SetActive(false);
    }

    void Start() {
        //Show("hero1", "hero4");
    }

    public void Show( string hero1Name,string hero2Name) {
       // Black_Mask._instance.Show();
        //储存传入的两个英雄的prefab 在其它的场景中可以取其值
        PlayerPrefs.SetString("hero1",hero1Name);
        PlayerPrefs.SetString("hero2",hero2Name);

        this.gameObject.SetActive(true);
        hero1Tween.GetComponent<UISprite>().spriteName=hero1Name;
        hero2Tween.GetComponent<UISprite>().spriteName = hero2Name;

        vsTween.PlayForward();
        hero1Tween.PlayForward();
        hero2Tween.PlayForward();
    }
    
   
	
}
