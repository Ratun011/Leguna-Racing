using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour
{
    public GameObject TheMarker;
    
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;

    public int MarkTracker;
    
    void Update()
    {
        if (MarkTracker == 0)
        {
            TheMarker.transform.position = Mark01.transform.position;
            TheMarker.transform.rotation = Mark01.transform.rotation;
        }
        if (MarkTracker == 1)
        {
            TheMarker.transform.position = Mark02.transform.position;
            TheMarker.transform.rotation = Mark02.transform.rotation;
        }
        if (MarkTracker == 2)
        {
            TheMarker.transform.position = Mark03.transform.position;
            TheMarker.transform.rotation = Mark03.transform.rotation;
        }
        if (MarkTracker == 3)
        {
            TheMarker.transform.position = Mark04.transform.position;
            TheMarker.transform.rotation = Mark04.transform.rotation;
        }
        if (MarkTracker == 4)
        {
            TheMarker.transform.position = Mark05.transform.position;
            TheMarker.transform.rotation = Mark05.transform.rotation;
        }
        if (MarkTracker == 5)
        {
            TheMarker.transform.position = Mark06.transform.position;
            TheMarker.transform.rotation = Mark06.transform.rotation;
        }
        if (MarkTracker == 6)
        {
            TheMarker.transform.position = Mark07.transform.position;
            TheMarker.transform.rotation = Mark07.transform.rotation;
        }
        if (MarkTracker == 7)
        {
            TheMarker.transform.position = Mark08.transform.position;
            TheMarker.transform.rotation = Mark08.transform.rotation;
        }
        if (MarkTracker == 8)
        {
            TheMarker.transform.position = Mark09.transform.position;
            TheMarker.transform.rotation = Mark09.transform.rotation;
        }
        if (MarkTracker == 9)
        {
            TheMarker.transform.position = Mark10.transform.position;
            TheMarker.transform.rotation = Mark10.transform.rotation;
        }
        if (MarkTracker == 10)
        {
            TheMarker.transform.position = Mark11.transform.position;
            TheMarker.transform.rotation = Mark11.transform.rotation;
        }
        if (MarkTracker == 11)
        {
            TheMarker.transform.position = Mark12.transform.position;
            TheMarker.transform.rotation = Mark12.transform.rotation;
        }
        if (MarkTracker == 12)
        {
            TheMarker.transform.position = Mark13.transform.position;
            TheMarker.transform.rotation = Mark13.transform.rotation;
        }
        if (MarkTracker == 13)
        {
            TheMarker.transform.position = Mark14.transform.position;
            TheMarker.transform.rotation = Mark14.transform.rotation;
        }
        if (MarkTracker == 14)
        {
            TheMarker.transform.position = Mark15.transform.position;
            TheMarker.transform.rotation = Mark15.transform.rotation;
        }
        if (MarkTracker == 15)
        {
            TheMarker.transform.position = Mark16.transform.position;
            TheMarker.transform.rotation = Mark16.transform.rotation;
        }
        if (MarkTracker == 16)
        {
            TheMarker.transform.position = Mark17.transform.position;
            TheMarker.transform.rotation = Mark17.transform.rotation;
        }
        if (MarkTracker == 17)
        {
            TheMarker.transform.position = Mark18.transform.position;
            TheMarker.transform.rotation = Mark18.transform.rotation;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DreamCar01")
        {
            this.GetComponent<Collider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 18)
            {
                
            }
        }

        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
