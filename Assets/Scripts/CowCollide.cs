using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<RockCollide>() != null)
        {
            Destroy(gameObject);
            return;
        }
        if (other.gameObject.name != "Player")
        {
            return;
        }
        Debug.Log("accessing TheCow-file");
        GameManager.inst.ScoreOutPut();
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
