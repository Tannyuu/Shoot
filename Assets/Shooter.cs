using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//入力はinput  0は通常クリック　逆は1
        {
            GameObject obj = Instantiate(prefab);//Instantiateでゲームシーンに登場する
            obj.transform.parent = transform;//親を設定する　(カメラ) 子はobj(弾丸)
            obj.transform.localPosition = Vector3.zero;//カメラとのポジションのズレがゼロ
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//カメラからクリックしたところに向けての光線　光線が弾丸の起動になる
            Vector3 dir = ray.direction.normalized;//.directionでベクトルを取り出してる normalizedで飛ぶ距離を1にする
            obj.GetComponent<Rigidbody>().velocity = dir * 100.0f;//obj.GetComponent<Rigidbody>().でRigidbodyにアクセスできる　 velocityは速度 秒速100m　自動
            //フィールドはプロパティ プロパティは代入して使う
            //obj.GetComponent<Rigidbody>().AddForce(dir * 100.0f); 力を加える 他動
        }
    }
}
