using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShip: MonoBehaviour
{
    [SerializeField] Image spaseShip;
    [SerializeField] int whichSprite = 0;
    [SerializeField] Sprite[] spaceShipSprite;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void SwitchingSprites()
    {
        if (whichSprite == 0)
        {
            whichSprite = 1;
            spaseShip.sprite = spaceShipSprite[whichSprite];
        }
        else if (whichSprite == 1)
        {
            whichSprite = 2;
            spaseShip.sprite = spaceShipSprite[whichSprite];
        }
        else
        {
            whichSprite = 0;
            spaseShip.sprite = spaceShipSprite[whichSprite];
        }
    }
}
