using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeroSelectHelper : MonoBehaviour
{
    public Dropdown hero_one;
    public Dropdown hero_two;
    public Dropdown hero_three;
    public Dropdown hero_four;
    public Text helpertext;
    bool uniqueHeroes;
    bool hero1ok;
    bool hero2ok;
    bool hero3ok;
    bool hero4ok;
    
    public void CheckHeroes()
    {
        if (hero_one.value != hero_two.value && hero_one.value != hero_three.value && hero_one.value != hero_four.value)
        {
            Debug.Log("Hero one approved");
            hero1ok = true;
        }
        if (hero_two.value != hero_one.value && hero_two.value != hero_three.value && hero_two.value != hero_four.value)
        {
            Debug.Log("Hero two approved");
            hero2ok = true;
        }
        if (hero_three.value != hero_one.value && hero_three.value != hero_two.value && hero_three.value != hero_four.value)
        {
            Debug.Log("Hero three removed");
            hero3ok = true;
        }
        if (hero_four.value != hero_one.value && hero_four.value != hero_two.value && hero_four.value != hero_three.value)
        {
            Debug.Log("Hero four approved");
            hero4ok = true;
        }

        if (hero1ok == true && hero2ok == true && hero3ok == true && hero4ok == true)
        {
            uniqueHeroes = true;
            helpertext.text = "Click submit to confirm your Heroes";
        }

        if (uniqueHeroes != true)
        {
            helpertext.text = "Choose four different Heroes";
        }

    }


}
