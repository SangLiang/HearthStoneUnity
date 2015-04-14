using UnityEngine;
using System.Collections;

public class hero1CryStal : MonoBehaviour
{
    public int usableNumber = 1;
    public int totolNumber = 1;
    public int maxNumber;

    public UISprite[] cryStals;
    public UILabel Number_label;



    

    void Awake()
    {
        maxNumber = cryStals.Length;
        Number_label = this.gameObject.GetComponent<UILabel>();
    }

    void UpdateShow()
    {
        //影藏多余水晶
        for (int i = totolNumber; i < maxNumber; i++)
        {
            cryStals[i].gameObject.SetActive(false);
        }
        //显示从第一个水晶，到目前可用的总数水晶
        for (int i = 0; i < totolNumber; i++)
        {
            cryStals[i].gameObject.SetActive(true);
        }
        //显示不可用水晶图片
        for (int i =usableNumber; i < totolNumber; i++)
        {
            cryStals[i].spriteName = "TextInlineImages_normal";
            //print("1");
            //print(cryStals[i].spriteName);
        }


        //显示可用水晶的图片
        for (int i = 0; i < usableNumber; i++)
        {
            if (i == 9)
            {
                cryStals[i].spriteName = "TextInlineImages_" + (i + 1);
                
            }
            else {
                cryStals[i].spriteName = "TextInlineImages_0" + (i + 1);
            }
            

        }

        Number_label.text = usableNumber + "/" + totolNumber;


    }

    void Update()
    {
        UpdateShow();
    }

}
