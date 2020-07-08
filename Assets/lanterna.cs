using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanterna : MonoBehaviour
{
    public Light luz;
	private bool teclaF = false;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey("f"))
            {
                Debug.Log("GetKey");
                if(teclaF == false)
                {
                    if(luz.intensity == 0)
                    {
                        luz.intensity = 3;
                    }
                    else{
                        luz.intensity = 0;
                    }
                }
                teclaF = true;
            }
            else 
            {
                teclaF = false;
            }
    }
}
