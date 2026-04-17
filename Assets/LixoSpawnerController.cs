using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LixoSpawnerController : MonoBehaviour
{
    public float maximoX;
    public float fixoY;
    public float fixoZ;
    public float timer;
    public GameObject Lixo;
    public int maxPonto;
    public int pontos = 0;
    public TMP_Text textoDoPonto;
    public TMP_Text textoDeVitoria;
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
        textoDeVitoria.gameObject.SetActive(true);
    }
    
    public void AddToPoints (int value)
    {
        pontos += value;
        textoDoPonto.text = "Pontos: "+pontos.ToString();
    }

    void Start()
    {
        StartCoroutine(SpawnRoutine());
        textoDeVitoria.gameObject.SetActive(false);
        textoDoPonto.text="Pontos: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
