using System.Collections;
using UnityEngine;

namespace VRStudies { namespace SummerLesson {
			
	public class Coin : MonoBehaviour {

		void OnCollisionEnter(Collision collision) {

			//プレイヤーと衝突したとき
			if( collision.gameObject.name == "Player" ){

				// ランダムな方向へ爆発させる
				var coin = this.gameObject.GetComponent<Rigidbody>();
				coin.AddForceAtPosition ( 
					new Vector3( Random.Range( -300, 300 ), 600, Random.Range( -300, 300 ) ), 
					new Vector3( Random.Range( -5, 5 ), Random.Range( -5, 5 ), Random.Range( -5, 5 ) ) 
				);

				// プレイヤーにも力を加える
				var player = collision.rigidbody;
				player.AddForce( 0, 30f, 0, ForceMode.Impulse );

				// さらにコインを生成する
				transform.parent.GetComponent<CoinMaker>().GenerateCoins( 30 );
			}
		}
	}
}}
