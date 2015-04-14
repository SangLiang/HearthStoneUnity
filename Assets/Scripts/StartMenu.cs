using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {
    public TweenScale logoTweenScale;
    public TweenPosition selectHeroSceneTween;

    //主角选择的英雄
    public UISprite hero1;
    //
    public int enemyRandom;
    public MovieTexture beginMovie;
    public bool isDrawMovie = true;
    public bool isShowMessage = false;


  


    //是否可以显示角色选择页面
    private bool isCanShowSelectPage = false;


	// Use this for initialization
	void Start () {
        beginMovie.loop = false;
        beginMovie.Play();
        logoTweenScale.AddOnFinished(this.OnLogoTweenFinish);//事件委托？在事件结束后调用括号内的代码
	}
	
	// Update is called once per frame
	void Update () {
	    if(isDrawMovie){
            if(Input.GetMouseButtonDown(0)&&isShowMessage==false){
                isShowMessage = true;
            }
            else if (Input.GetMouseButtonDown(0) && isShowMessage == true)
            {
                StopMovie();
            }
        }

        if(isDrawMovie!=beginMovie.isPlaying){
            StopMovie();
        }
        if(isCanShowSelectPage&&Input.GetMouseButtonDown(0)){
            //显示角色选择界面
            isCanShowSelectPage = false;
            selectHeroSceneTween.PlayForward();

        }

	}

    void OnGUI() {
        if(isDrawMovie){
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), beginMovie);
            if(isShowMessage){
                GUI.Label(new Rect(Screen.width/2-125,Screen.height/2,250,40),"再点击一次屏幕退出动画播放");
            }
        }        
    }
    private void StopMovie() {
        beginMovie.Stop();
        isDrawMovie = false;
        //
        logoTweenScale.PlayForward();
    }
    private void OnLogoTweenFinish() {
        isCanShowSelectPage = true;
    }

    public void OnPlayButtonClick()
    {
        enemyRandom = (int)Random.Range(1, 10);
        Black_Mask._instance.Show();
        VS_Show._instance.Show(hero1.spriteName, "hero" + enemyRandom);
        StartCoroutine(GoNextScene());
    }


    IEnumerator GoNextScene()
    {
        yield return new WaitForSeconds(2.0f);
        Application.LoadLevel(1);
    }

}
