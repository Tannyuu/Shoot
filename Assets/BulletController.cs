using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour //継承
{
    void OnBecameInvisible()//カメラのレンダリング範囲から消えたら消える
    {
    Destroy(gameObject);
  }

}
