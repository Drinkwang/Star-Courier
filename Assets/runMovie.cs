using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
[ExecuteInEditMode]
public class runMovie : MonoBehaviour
{ 
    public bool isPlayMovie ;
    public int frame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VideoPlayer tempVideo= this.GetComponent<VideoPlayer>();
        tempVideo.Play();
        if (isPlayMovie == true)
        {



        }
        else
        {

            if (tempVideo.frame != (int)frame)
            {
                tempVideo.frame = (int)frame;
                Debug.Log("is ruing");
            }


        }


    }
}
