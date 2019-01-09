using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移扱う

public class GameClearSceneManager : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	//Titleボタン押した時に呼ばれる関数
	public void TitleButton()
	{
		SceneManager.LoadScene("Title");
	}
}
