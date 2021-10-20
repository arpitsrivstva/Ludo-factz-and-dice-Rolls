using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public Text Score;
    public Text HighScore;

    public Transform Lever;
    public Text RFactz;

    int number;

    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void RollDice ()
    {
        number = Random.Range(1,7);
        Score.text = number.ToString();
        
        if(number > PlayerPrefs.GetInt("HighScore", 0))
        {
        PlayerPrefs.SetInt("HighScore", number);
        HighScore.text = number.ToString();
        }
        RandomFactz();
    }
    
    public void Reset() 
    {
        PlayerPrefs.DeleteKey("HighScore");
        HighScore.text = 0.ToString();
    }

    private void FixedUpdate() 
    {
        switch(number)
        {
            case 1:
            Lever.transform.position = new Vector3(530, 385, -800);
            break;

            case 2:
            Lever.transform.position = new Vector3(530, 390, -800);
            break;

            case 3:
            Lever.transform.position = new Vector3(530, 395, -800);
            break;

            case 4:
            Lever.transform.position = new Vector3(530, 400, -800);
            break;

            case 5:
            Lever.transform.position = new Vector3(530, 405, -800);
            break;

            case 6:
            Lever.transform.position = new Vector3(530, 413, -800);
            break;
        }
    }

    private void RandomFactz()
    {
        string[] factz = new string[] {"Ludo Originated in India", "It Used To Be Known As Pachisi, Online Ludo Is A Game Of Strategy, Not Luck!", "Ludo is a Latin word that means “I play”", "It is the oldest game that was played by Mughal emperors", "Earlier it was played with cowries, but later it was modified to use a cubic die with a dice cup", "England has given the rules and structure to this game in 1896", "The Mughal emperor Akbar played this game for gathering people", "Red and blue colours are taken from the flag of England", "Green colour from the flag of Ireland, and Yellow from the flag of Bale"
    , "*Each opposite side of the dice sum ups to seven*", "Ludo is played with two dices and one dice as well"};

    string randomfactz = factz[Random.Range(0, factz.Length)];
    RFactz.text = randomfactz;
    }
}