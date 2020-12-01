using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
   public GameObject a;
   public GameObject b;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="x")
        {
            SceneManager.LoadScene("game over");
        }
        if (collision.collider.tag=="y")
        {
            Destroy(a);
            
        }
        if (collision.collider.tag == "z")
        {
            Destroy(b);

        }
        if (collision.collider.tag == "w")
        {
            SceneManager.LoadScene("win");
        }
    }
   
}
