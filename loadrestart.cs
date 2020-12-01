using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadrestart : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Update is called once per frame
   public void reatart()
    {
        SceneManager.LoadScene("SampleScene");  
    }
}
