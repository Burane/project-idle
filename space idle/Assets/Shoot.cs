using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    private Text textCredit;
    public double credit;

    public Text TextCredit { get => textCredit; set => textCredit = value; }

    // Start is called before the first frame update
    void Start()
    {
        this.credit = 0;

    }

    // Update is called once per frame
    void Update()
    {
        this.TextCredit.text = "Credits : " + credit;
    }

    void shoot()
    {
        credit++;
    }

}
