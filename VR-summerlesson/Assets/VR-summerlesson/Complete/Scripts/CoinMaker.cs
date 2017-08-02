using System.Collections;
using UnityEngine;

namespace VRStudies { namespace SummerLesson {

	public class CoinMaker : MonoBehaviour {


		void Start() {

			// 初回のコインを生成する
			GenerateCoins ( 200 );
		}

		public void GenerateCoins( int num ) {

			//コインを大量複製して空から降らす
			for( int i = 0; i < num; i++ ){

				//ランダムな初期位置へ移動
				var coin = transform.Find("Coin").gameObject;
				GameObject copy = Object.Instantiate( coin ) as GameObject;
				copy.name = "Coin";
				copy.transform.parent = this.transform;
				copy.transform.position = new Vector3( Random.Range( -150, 150 ), Random.Range( 30, 300 ), Random.Range( -150, 150 ) );
			}
		}
	}

}}
