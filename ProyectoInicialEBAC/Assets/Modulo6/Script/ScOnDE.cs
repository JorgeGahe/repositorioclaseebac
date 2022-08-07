using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScOnDE : MonoBehaviour
{
    public GameObject Prefabcubo;
    public List<GameObject> listaDeCubos;
    public int numCubos = 0;
    // Start is called before the first frame update
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(Prefabcubo);
        tempGameObject.name = "CuboNumero" + numCubos;
    }

    private void OnDisable()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(Prefabcubo);
        tempGameObject.name = "CuboNumero" + numCubos;
    }
}
