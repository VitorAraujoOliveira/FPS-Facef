using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


 public class ChangeScene : MonoBehaviour{
     
         void Update(){
                 if(Input.GetKeyDown(KeyCode.E))
                          UnityEngine.SceneManagement.SceneManager.LoadScene(1);

         }
 }