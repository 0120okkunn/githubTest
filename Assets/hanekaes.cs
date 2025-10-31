using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x < 33)
                this.transform.position += Vector3.left * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (this.transform.position.x > 43)
                    this.transform.position += Vector3.right * speed * Time.deltaTime;
            }

        }















    }
}
    

