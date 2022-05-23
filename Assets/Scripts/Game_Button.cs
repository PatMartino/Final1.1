using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Button : MonoBehaviour
{
    public GameObject soldier;
    public GameObject player1_cikisNoktasi;
   public void firstSoldier()
    {
        Instantiate(soldier, player1_cikisNoktasi.transform.position, player1_cikisNoktasi.transform.rotation);
        
    }
}
