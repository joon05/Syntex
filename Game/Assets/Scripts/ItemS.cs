using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemS : MonoBehaviour
{
    public int itemcode;
    public GameObject mainC;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))

        {
            mainC.transform.GetComponent<MainControl>().items.Add(itemcode);
            Destroy(this.gameObject);

        }
    }
}
