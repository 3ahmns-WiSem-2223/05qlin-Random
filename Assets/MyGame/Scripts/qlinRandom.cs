using UnityEngine;
using UnityEngine.UI;


public class qlinRandom : MonoBehaviour
{
    private System.Random rnd = new System.Random();
    [SerializeField] private float rndFloat;
    [SerializeField] private Vector2 returnVector;
    [SerializeField] private Image color;
    [SerializeField] private GameObject newPosition;


    // Start is called before the first frame update
    void Start()
    {
        RandomValue();
        RandomColor();
        RandomPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void RandomNumber()
    {
        int numberRandom = rnd.Next(1, 20);
        Debug.Log(numberRandom);
    }

    private void RandomColor()
    {
        color.color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    private void RandomValue()
    {
        rndFloat = UnityEngine.Random.value;
        Debug.Log(rndFloat);
    }

    private void RandomPoint()
    {
        returnVector = UnityEngine.Random.insideUnitCircle;
        newPosition.transform.position = returnVector;
        Debug.Log(returnVector);
    }
}
