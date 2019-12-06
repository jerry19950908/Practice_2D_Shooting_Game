using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    [Header("血量")]
    public int hp = 10;
    [Header("血量介面")]
    public Text texthp;

    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip soundhurt;
    


    private void hurt(int add = 1)
    {
        print("被擊中了~~~");

        hp -= add; // hp = hp - add;

        texthp.text = hp.ToString();

        aud.PlayOneShot(soundhurt, 2f);

        if(hp == 0)
        {
            Destroy(gameObject, 0.1f);
        }
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "子彈")
        {
            hurt();

        }
    }




}
