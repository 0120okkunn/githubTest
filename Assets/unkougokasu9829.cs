using UnityEngine;
using UnityEngine.Tilemaps;

public class unkougokasu9829 : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("‚¤‚ñ‚±“Ë“ü’†!!!");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y>=0)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            Debug.Log("‚¤‚ñ‚±‚ªˆø‚«•Ô‚·");
        }
        if (transform.position.x >= 30)
        {
            transform.Translate(Vector3.down*speed*Time.deltaTime);
        }
        transform.Translate(Vector3.down*speed*Time.deltaTime);//‚¤‚ñ‚±‚ª“®‚­
    }
}
   
