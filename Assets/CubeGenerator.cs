using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
	public GameObject prefab;
	public GameManager gm;

	void Start()
	{
		StartCoroutine(Create());
	}
	IEnumerator Create()
	{
		float delta = 1.5f;
		while (true)
		{
			GameObject obj = Instantiate(
				prefab,
				new Vector3(Random.Range(-12.0f, 12.0f), Random.Range(8.0f, 12.0f), Random.Range(-3.0f, 3.0f)),
				Quaternion.identity

			);
			obj.GetComponent<CubeController>().SetGameManager(gm);
			yield return new WaitForSeconds(delta);
			if (delta > 0.5f)
			{
				delta -= 0.05f;
			}
		}
	}
}