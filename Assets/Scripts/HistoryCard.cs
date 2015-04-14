using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HistoryCard : MonoBehaviour {
    public Transform inCard;
    public Transform outCard;
    public Transform card1;
    public Transform card2;

    private List<GameObject> card_List = new List<GameObject>();

    public GameObject card_Prefab;


    private float yOffset;


    void Start() {
        yOffset = card2.position.y - card1.position.y;
    }

    void Update() { 
        if(Input.GetKeyDown(KeyCode.LeftControl)){
            StartCoroutine(AddCard()); 
        }
    }


   public IEnumerator  AddCard() {
       GameObject Go= GameObject.Instantiate(card_Prefab,inCard.position,Quaternion.identity) as GameObject;
        yield return 0;
        Go.transform.position = inCard.position;
        iTween.MoveTo(Go,card1.position,1f);

        card_List.Add(Go);
        if(card_List.Count>7){
            iTween.MoveTo(card_List[0],outCard.position,1f);
            Destroy(card_List[0],2f);
            card_List.RemoveAt(0);
           }

        for (int i = 0; i < card_List.Count-1;i++ )
        {
            iTween.MoveTo(card_List[i],card_List[i].transform.position+new Vector3(0,yOffset,0),0.5f);
          
        }
    }
	
}
