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
    public void PlayButton()
    {
        aiImage.gameObject.SetActive(true);
        aiChoose = Random.Range(0, sprites.Length);

        //changes a sprite on the image component
        aiImage.sprite = sprites[aiChoose];

        if(aiChoose == playerChoose.playerChoose) 
        {
            winText.text = "You tied!";
            
        }

        if(aiChoose == 0 && playerChoose.playerChoose == 2 || aiChoose == 1 && playerChoose.playerChoose == 0 || aiChoose == 2 && playerChoose.playerChoose == 1)
        {
            winText.text = "You LOST NOOB";
        }

        if(playerChoose.playerChoose == 0 && aiChoose == 2 || playerChoose.playerChoose == 1 && aiChoose == 0 || playerChoose.playerChoose == 2 && aiChoose == 1)
        {
            winText.text = "You win >:)";
        }
    }
}
