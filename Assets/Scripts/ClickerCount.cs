using UnityEngine;

public class ClickerCount : MonoBehaviour
{
    int clickedTimes = 0;
    int wuWus = 0;
    public float jumpForce = 10f;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(clickedTimes);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            clickedTimes = clickedTimes + 1;
            Debug.Log(clickedTimes);
            if (clickedTimes == 10)
            {
                wuWus++;
                Debug.Log("WuWuuus = " + wuWus);
            }
        }

        if (clickedTimes == 10)
        {
            clickedTimes = -1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        wuWus++;
        Debug.Log("wuWu Bounces = " + wuWus);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Chocó");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("ChocandooOOooOOooOOOoOoOOoOoOOO laaaAAAaaa poooOOliiiIIzzziiaaAAAaaaaaaA");
    }
}

