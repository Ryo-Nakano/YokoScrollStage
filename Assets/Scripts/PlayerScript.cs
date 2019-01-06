using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移扱う

public class PlayerScript : MonoBehaviour {

    /// <summary>
	/// [SerializeField]は『publicとprivateの中間』みたいなイメージ！
	/// ▶︎Unity上からGameObjectをアタッチしたい
	/// ▶︎Unity上で変数の値をいじりたい
	/// 時によく使う！
    /// </summary>

	[SerializeField] float speed;//Playerの移動スピード
	[SerializeField] float jumpPower;//Playerのジャンプ力
	float jumpCount = 0;//Jumpの回数をカウントし、制限する為の変数

	Rigidbody rigidbody;//取得したRigidbodyを格納しておく為の変数

	void Start () {
		rigidbody = this.gameObject.GetComponent<Rigidbody>();//Rigidbodyを取得→変数rigidbodyに格納
	}

	void Update () {
		Move();//Playerの動き

		if(this.transform.position.y < -6.0f)//Playerのy座標(高さ)がある一定を下回ったら
		{
			//GameOverの処理
			Debug.Log("GameOver");
			SceneManager.LoadScene("GameOver");
		}
	}

    //Playerの動き
	void Move()
	{
		//右に移動
		if(Input.GetKey(KeyCode.RightArrow))//右キー押した時
		{
			this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
		}

        //左に移動
		if (Input.GetKey(KeyCode.LeftArrow))//左キー押した時
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        //Jump
		if(Input.GetKeyDown(KeyCode.Space))//spaceキー押した時
		{
			if(jumpCount < 2)
			{
				rigidbody.velocity = new Vector3(0, jumpPower, 0);
				jumpCount++;
			}
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Ground")//当たった相手が地面だった時
		{
			jumpCount = 0;//jumpCountをリセット
		}
	}

	private void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Enemy")//当たった相手がEnemyだった時
		{
			//GameOverの処理
			Debug.Log("GameOver");
			SceneManager.LoadScene("GameOver");
		}

		if(col.gameObject.tag == "Goal")//当たった相手がGoalだった時
		{
			//GameClearの処理
			Debug.Log("GameClear!");
			SceneManager.LoadScene("GameClear");
		}
	}
}
