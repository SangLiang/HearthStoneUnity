using UnityEngine;
using System.Collections;

public class SelectHero : MonoBehaviour
{
    private string[] heroNames ={
                               "吉安娜",
                               "雷克萨",
                               "乌瑟尔",
                               "加尔炉石",
                               "玛法里奥",
                               "古尔丹",
                               "萨尔",
                               "安度因",
                               "瓦里纳"                           
                               };
    private UISprite selectImg;
    private UILabel selectHeroName;


    void Awake() {
        //selectImg = this.transform.Find("heroShow").GetComponent<UISprite>();
         selectImg = this.transform.parent.Find("heroShow").GetComponent<UISprite>();
        selectHeroName=this.transform.parent.Find("ChoiseHeroName_Label").GetComponent<UILabel>();
    }



    void OnClick()
    {
        string heroName = this.gameObject.name;
        selectImg.spriteName = heroName;
        char heroIndexChar = heroName[heroName.Length-1];
        int heroIndex = heroIndexChar - '0';

        selectHeroName.text = heroNames[heroIndex-1];

    }

}
