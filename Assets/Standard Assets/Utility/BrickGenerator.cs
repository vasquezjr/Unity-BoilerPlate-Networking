using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = Resources.Load("Brick") as GameObject;
    for(int i =0; i<10; i++)
        {
            for(int height=0; height<10; height++)
            {
                GameObject brick = Instantiate(prefab) as GameObject;
                brick.transform.position = new Vector3(transform.position.x + (i),
                                                        transform.position.y + (height) +0.5f,
                                                        transform.position.z);
            }
        }


    }

}
