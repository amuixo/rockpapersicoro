using UnityEngine;
using UnityEngine.UI;

public class AiChoose : MonoBehaviour
{
    public Sprite[] sprites;

//just so it doesnt mess up 
    public int aiChoose = -1;

    public Image aiImage;

    public PlayerChoose playerChoose;

    public TextMeshProUGUI winText;

    public Button resetButton;

    public void PlayButton()
    {
        aiImage.gameObject.SetActive(true);
        aiChoose = Random.Range(0, sprites.Length);

        //changes a sprite on the image component
        aiImage.sprite = sprites[aiChoose];

        if(aiChoose == playerChoose.playerChoose) 
        {
            winText.text = "You tied! :( )";
            
        }

        if(aiChoose == 0 && playerChoose.playerChoose == 2 || aiChoose == 1 && playerChoose.playerChoose == 0 || aiChoose == 2 && playerChoose.playerChoose == 1)
        {
            winText.text = "You LOST NOOB";
        }

        if(playerChoose.playerChoose == 0 && aiChoose == 2 || playerChoose.playerChoose == 1 && aiChoose == 0 || playerChoose.playerChoose == 2 && aiChoose == 1)
        {
            winText.text = "You win >:)";
        }
         resetButton.gameObject.SetActive(true);
    }
    
    //resets everything so you can play again
        public void ResetButton(){

            aiChoose = -1;
            playerChoose.playerChoose = -1;
            playerChoose.rockButton.gameObject.SetActive(true);
            playerChoose.paperButton.gameObject.SetActive(true);
            playerChoose.scissorsButton.gameObject.SetActive(true);
            winText.text = "";
            playerChoose.playerChooseText.text = "";
            resetButton.gameObject.SetActive(false);

        }
    
}
