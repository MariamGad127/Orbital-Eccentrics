using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plasmaGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenClicked()
    {
        SceneManager.LoadScene("Catching plasma");
        Debug.Log("Plasma loaded");
    }
}
