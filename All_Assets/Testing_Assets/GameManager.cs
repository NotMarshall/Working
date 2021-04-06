using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public GameObject PlayerPreFab;
   public GameObject GameCanvas;
   public GameObject SceneCamera;



        public void Awake()
        {
            GameCanvas.SetActive(true);
        }

   public void SpawnPlayer()

   {
       float randomvalue = Random.Range(-1f, 1f);
       PhotonNetwork.Instantiate(PlayerPreFab.name, new Vector2(this.transform.position.x * randomvalue, this.transform.position.y), Quaternion.identity, 0);
       GameCanvas.SetActive(false);
       SceneCamera.SetActive(false);
   }
}
