using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logoloader : MonoBehaviour {
	void Start ()
	{
		StartCoroutine ("Countdown");
	}
	private IEnumerator Countdown()
	{
		yield return new WaitForSeconds(4f);
		Application.LoadLevel(1);
	}

    public void hcyönlendirme()
    {
        Application.LoadLevel(1);
    }
}  