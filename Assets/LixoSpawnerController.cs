using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixoSpawnerController : MonoBehaviour
{
    public float maximoX;
    public float fixoY;
    public float fixoZ;
    public float timer;
    public GameObject Lixo;
    public int maxPonto;
    public int pontos = 0;
    // Start is called before the first frame update
    IEnumerator SpawnRoutine() {
        while (pontos < maxPonto)
        {
            Instantiate(Lixo,
                        new Vector3(Random.Range(-maximoX, maximoX+1),
                        fixoY, 
                        fixoZ),
                    Quaternion.identity);
            yield return new WaitForSeconds(timer);
        }
    }
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
