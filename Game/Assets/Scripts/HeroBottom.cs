using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBottom : MonoBehaviour
{
    public GameObject hero;
    
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Wall")) 
        {
           // Debug.Log("ÂîÂîÈÆÀº ÃµÀç´Ù");
            hero.transform.GetComponent<MainHero>().jump =true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == ("Wall"))
        {
           // Debug.Log("ÂîÂîÈÆÀº ÃµÀç´Ù");
            hero.transform.GetComponent<MainHero>().jump = true;
        }
    }


}
