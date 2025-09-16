using UnityEngine;
using UnityEngine.UI;

public class AiChoose : MonoBehaviour
{
    public Sprite[] sprites;

//just so it doesnt mess up 
    public int aiChoose = -1;

    public Image aiImage;

    public void PlayButton()
    {
        aiImage.gameObject.SetActive(true);
        aiChoose = Random.Range(0, sprites.Length);
        
        //changes a sprite on the image component
        aiImage.sprite = sprites[aiChoose];

    }
}
