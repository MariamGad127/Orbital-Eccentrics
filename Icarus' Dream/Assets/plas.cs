using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plas : MonoBehaviour
{
    public GameObject plasma;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        Debug.Log("MOOOOO");
        if (plasma.activeInHierarchy == true)
            plasma.SetActive(false);
        else
            plasma.SetActive(true);
    }
}
