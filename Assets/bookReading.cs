using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookReading : MonoBehaviour
{
    public GameObject book1_UI;
    public GameObject book;
    private bool temasvar;
    // Start is called before the first frame update
    void Start()
    {
        temasvar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            collect_Book();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            temasvar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            temasvar = false;
        }
    }

    public void collect_Book()
    {
        if (temasvar)
        {
            book1_UI.SetActive(true); 
            book.SetActive(false);
        }
    }
}
