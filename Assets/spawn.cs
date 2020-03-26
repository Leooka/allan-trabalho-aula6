using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    float tiltAngle = 60.0f; 
    public GameObject prefab;
    public float tempo = 0;
	public float novaRotation;

    // private Transform target;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        tempo += Time.deltaTime;

        if(tempo > 5)
		{
            prefab.transform.position = new Vector3(Random.Range(-5,5),Random.Range(-5,5), 0);
            prefab.transform.rotation = Quaternion.Euler(0, 0, Random.Range(-180, 180));
            Instantiate(prefab);
            
            tempo = 0;
        }
    }
}
