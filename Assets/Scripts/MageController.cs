using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageController : MonoBehaviour
{
        //public float horizontalLast = 0;
        //public float verticalLast = 0;  


    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal"); //horizontal: -0.98...0.98 vasemmalta oikealle
        //float vertical = Input.GetAxis("Vertical");     //vertical: -0.98...0.98 alhaalta ylös
       
        Vector2 position = transform.position;

        transform.position = position;

        float hor = 0, ver = 0;
        if(Input.GetKeyDown(KeyCode.W)){ver = 1;}
        if(Input.GetKeyDown(KeyCode.A)){hor = -1;}
        if(Input.GetKeyDown(KeyCode.S)){ver = -1;}
        if(Input.GetKeyDown(KeyCode.D)){hor = 1;}

        position.x = position.x + 50.0f * hor*Time.deltaTime;
        position.y = position.y + 50.0f * ver*Time.deltaTime;
        transform.position = position;

        //Debug.Log(horizontal);

    }
}
