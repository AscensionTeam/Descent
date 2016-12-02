using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BEGIN_END_TURN : MonoBehaviour {

    public Image[] playerImages;
    public GameObject heroImage1;
    public GameObject heroImage2;
    public GameObject heroImage3;
    public GameObject heroImage4;
    public GameObject overlord;




    private int turnNumber;


    // Use this for initialization
    void Start ()
    {
        imageResize();
        
    }
	

    public void imageResize ()
    {
        turnNumber = turnNumber + 1;

        if (turnNumber == 1)
        {
            heroImage1.transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
        }
        if (turnNumber == 2)
        {
            heroImage2.transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
            heroImage1.transform.localScale += new Vector3(-0.1F, -0.1f, -0.1f);
        }
        if (turnNumber == 3)
        {
            heroImage3.transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
            heroImage2.transform.localScale += new Vector3(-0.1F, -0.1f, -0.1f);
        }
        if (turnNumber == 4)
        {
            heroImage4.transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
            heroImage3.transform.localScale += new Vector3(-0.1F, -0.1f, -0.1f);
        }
        if(turnNumber == 5)
        {
           
            overlord.transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
            heroImage4.transform.localScale += new Vector3(-0.1F, -0.1f, -0.1f);
        }
        if (turnNumber == 6)
        {
            turnNumber = 1;
            overlord.transform.localScale += new Vector3(-0.1F,-0.1f, -0.1f);
            heroImage1.transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
        }

    }
    

}
