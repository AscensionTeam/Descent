using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeroInfo : MonoBehaviour {

    int heroOneID;
    int heroTwoID;
    int heroThreeID;
    int heroFourID;

    public Dropdown hero1;
    public Dropdown hero2;
    public Dropdown hero3;
    public Dropdown hero4;

	
	public void SetIDs()
    {


        heroOneID = hero1.value;
        heroTwoID = hero2.value;
        heroThreeID = hero3.value;
        heroFourID = hero4.value;

        PlayerPrefs.SetInt("HeroID1", heroOneID);
        PlayerPrefs.SetInt("HeroID2", heroTwoID);
        PlayerPrefs.SetInt("HeroID3", heroThreeID);
        PlayerPrefs.SetInt("HeroID4", heroFourID);

        Debug.Log("set ids happened");

	}
}
