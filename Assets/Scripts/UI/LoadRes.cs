using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadRes : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Loading());
	}
      IEnumerator  Loading()
    {
        GameObject go = Resources.Load("Prefab/Panel") as GameObject;
        Instantiate(go,this.gameObject.transform);
        yield return new WaitForSeconds(1f);
        GameObject.Find("Panel").AddComponent<LoginUI>();
    }
}
