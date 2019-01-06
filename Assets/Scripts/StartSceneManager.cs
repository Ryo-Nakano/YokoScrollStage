using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移扱う

public class StartSceneManager : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

    //Startボタンを押した時に呼ばれる関数
	public void StratButton()
	{
		SceneManager.LoadScene("StageSelect");//Menuシーンに移動
	}
}
