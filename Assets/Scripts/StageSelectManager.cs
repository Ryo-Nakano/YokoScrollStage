using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移扱う

public class StageSelectManager : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	//Stage1ボタンを押した時に呼ばれる関数
    public void Stage1Button()
    {
        SceneManager.LoadScene("Stage1");//Stage1シーンに移動
    }
}
