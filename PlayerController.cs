using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody playerRigidBody;

    public UnityEngine.UI.Text litereColectate;
    private string litereleMele;

    public UnityEngine.UI.Button butonMaiJoacaOdata;
    public UnityEngine.UI.Button butonInchideAplicatie;

    private void Start()
    {
        litereColectate.text = "Ai colectat: ";
        litereleMele = "";
        butonMaiJoacaOdata.gameObject.SetActive(false);

        butonInchideAplicatie.GetComponentInChildren<Text>().text = "Iesire aplicatie";

    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        playerRigidBody.AddForce(movement * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.tag == "LiteraColectabila")
        {
            other.gameObject.SetActive(false);

            litereleMele = litereleMele + other.gameObject.GetComponent<TextMesh>().text;
            litereColectate.text = "Ai colectat: " + litereleMele;



            if (litereleMele.Equals("ETTI"))
            {
                butonMaiJoacaOdata.gameObject.SetActive(true);
                butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Felicitari - Mai joaca odata";
                Time.timeScale = 0;


            }
            else
            {
                if (litereleMele.Length > 3)
                {
                    butonMaiJoacaOdata.gameObject.SetActive(true);
                    butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Asta nu e bine - Mai joaca o data";
                    Time.timeScale = 0;
                }
                else
                {
                    butonMaiJoacaOdata.gameObject.SetActive(false);
                }
            }



        }
    }
}