using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vibcode : MonoBehaviour , IVirtualButtonEventHandler
{
    public GameObject linkedin;
    public GameObject maps;
    public GameObject call;
    public GameObject mail;
    // Start is called before the first frame update
    void Start()
    {


        
        linkedin = GameObject.Find("linkedin");
linkedin.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

maps = GameObject.Find("maps");
maps.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

call = GameObject.Find("call");
call.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

mail = GameObject.Find("mail");
mail.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("pressed...........");

        if (vb.VirtualButtonName == "linkedin")
        {
            Application.OpenURL("https://www.linkedin.com/in/bibhu-biswal-b1b363180/?lipi=urn%3Ali%3Apage%3Ad_flagship3_search_srp_top%3BrTaTkKJVTYS%2BvWKJSi43eQ%3D%3D&licu=urn%3Ali%3Acontrol%3Ad_flagship3_search_srp_top-search_srp_result&lici=Ej66VhpFQnGLPr21RDb3Jg%3D%3D");
            Debug.Log("LINKEDIN TRIGERRED");
        }
        else if (vb.VirtualButtonName == "maps")
        {
            Application.OpenURL("https://goo.gl/maps/rXbf9w22E2YLqhG37");
            Debug.Log("maps link triggered");
        }
        else if (vb.VirtualButtonName == "call")
        {
            Application.OpenURL("<a href='tel:+917011765309'></a>");
            Debug.Log("call triggered");
        }
        else if (vb.VirtualButtonName == "mail")
        {
            Application.OpenURL("<a href='mailto:midhapulkit28@gmail.com'></a>");
            Debug.Log("mail triggered");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
    // Update is called once per frame
    void Update()
    {


    }
}
