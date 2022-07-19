using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

using unityImage = UnityEngine.UI.Image;
public class Bottone : MonoBehaviour
{
    public unityImage image;
    public Sprite[] mySprite;
    public VirtualButtonBehaviour Vb;
    public VirtualButtonBehaviour Vb2;

   private int count = 0 ;
    // Start is called before the first frame update
    void Start()
    {
       
    }



    public void ChangeImageForward() {

        count++;
        image.sprite = mySprite[count];
         
        
        

    }

    public void ChangeImageBackward()
    {
        count--;
        image.sprite = mySprite[count]; 
        
    }



}
