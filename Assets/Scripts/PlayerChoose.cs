using UnityEngine;

public class PlayerChoose
{
// 0 is rock, 1 is paper, 2 is scissors

    //list of sprites that we want to choose (rock paper scissors)
    public Sprite[] spritesToChooseFrom;

//all the buttons
    public Button rockButton;
    public Button paperButton;
    public Button scissorsButton;

//this will be the rock paper scissors that the player has chosen, -1 so its not equal to anything when you start the game
    public int playerChoose = -1;

//text that shows what the player has chosen
    public TextMeshProUGUI playerChooseText;

//if the rockbutton has been clicked, and disables all the buttons when its been clicked
    public void RockButton()
    {

    playerChoose = 0;
    playerChooseText.text = "You chose Rock";
    rockButton.gameObject.SetActive(false);
    paperButton.gameObject.SetActive(false);
    scissorsButton.gameObject.SetActive(false);

    }

    public void PaperButton()
    {

    playerChoose = 1;
    playerChooseText.text = "You chose Paper";
    rockButton.gameObject.SetActive(false);
    paperButton.gameObject.SetActive(false);
    scissorsButton.gameObject.SetActive(false);

    }

    public void ScissorsButton()
    {

    playerChoose = 2;
    playerChooseText.text = "You chose Scissors";
    rockButton.gameObject.SetActive(false);
    paperButton.gameObject.SetActive(false);
    scissorsButton.gameObject.SetActive(false);

    }

}
