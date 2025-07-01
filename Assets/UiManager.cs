using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    public GameObject tank, fuel;
    public TextMeshProUGUI tankPosition, fuelPositionText;
    public ObjectManager fuelPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tankPosition.text = tank.transform.position + "";
        fuelPosition = fuel.GetComponent<ObjectManager>();
        fuelPositionText.text = fuelPosition + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
