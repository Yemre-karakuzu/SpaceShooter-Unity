using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyunkontrol : MonoBehaviour {

    public GameObject Asteroid;
    public Vector3 randomPos;
    public float baslangıcbekeme;
    public float olusturmabekleme;
    public float dongubekleme;
    int score;
	void Start ()
    {
        score = 0;
        StartCoroutine(olustur());	
	}
    IEnumerator olustur()
    {
        yield return new WaitForSeconds(baslangıcbekeme);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(olusturmabekleme);
            }           
            yield return new WaitForSeconds(dongubekleme);    
        }
        
        
    }
    public void ScoreArttır()
    {

    }
}
