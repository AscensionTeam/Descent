using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DICE_SCRIPT : MonoBehaviour {

    private int attack_number;
    private int attack;
    private int surgePoints;
    private int range;

    public Text statusText;
    public Text rangeText;
    public Text surgeText;
    public Text attackText;
    
    public void AttackDice ()
    {
        attack_number = Random.Range(1, 6);

        if (attack_number == 1)
        {
            statusText.text = "Attack Missed";
            attack = 0;
            range = 0;
            surgePoints = 0;

            attackText.text = "Attack: " + attack.ToString();
            surgeText.text = "Surge: " + surgePoints.ToString();
            rangeText.text = "Range: " + range.ToString();
        }
        if (attack_number == 2)
        {
            statusText.text = "Attack Hit";
            attack = 2;
            surgePoints = 1;
            range = 2;

            attackText.text = "Attack: " + attack.ToString();
            surgeText.text = "Surge: " + surgePoints.ToString();
            rangeText.text = "Range: " + range.ToString();

        }
        if (attack_number == 3)
        {
            statusText.text = "Attack Hit";
            attack = 2;
            range = 4;
            surgePoints = 0;

            attackText.text = "Attack: " + attack.ToString();
            surgeText.text = "Surge: " + surgePoints.ToString();
            rangeText.text = "Range: " + range.ToString();

        }
        if (attack_number == 4)
        {
            statusText.text = "Attack Hit";
            attack = 1;
            surgePoints = 1;
            range = 6;

            attackText.text = "Attack: " + attack.ToString();
            surgeText.text = "Surge: " + surgePoints.ToString();
            rangeText.text = "Range: " + range.ToString();
        }
        if (attack_number == 5)
        {
            statusText.text = "Attack Hit";
            attack = 2;
            range = 3;
            surgePoints = 0;

            attackText.text = "Attack: " + attack.ToString();
            surgeText.text = "Surge: " + surgePoints.ToString();
            rangeText.text = "Range: " + range.ToString();

        }
        if (attack_number == 6)
        {
            statusText.text = "Attack Hit";
            attack = 1;
            range = 5;
            surgePoints = 0;

            attackText.text = "Attack: " + attack.ToString();
            surgeText.text = "Surge: " + surgePoints.ToString();
            rangeText.text = "Range: " + range.ToString();

        }

    }

    
}
