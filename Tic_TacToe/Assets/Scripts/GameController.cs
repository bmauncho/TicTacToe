using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool IsGameStarted = false;
    public bool IsGameEnded = false;
    public bool IsGameTied = false;
     public bool IsGameWon = false;
    
    int BoxCounter = 0;
    [Space]
    public bool isPlayer;
    [Space]
    public List<BoxController> _boxController = new List<BoxController>();
    [Space]
    public  List<BoxController> AiMoves = new List<BoxController>();
    [Space]
    public  List<BoxController> PlayerMoves = new List<BoxController>();
    // Start is called before the first frame update
    void Start()
    {
        isPlayer = true;
    }

    // Update is called once per frame
    void Update()
    {  

        if(CodeManager.Instance._playerController.iSPlayerPlaying == true)
        {
            isPlayer = true;
            if(isPlayer){
                CodeManager.Instance._playerController.Rotation =1;
            }  
        }
        
        if(CodeManager.Instance._playerController.iSPlayerPlaying == false && !isPlayer)
        {
            CodeManager.Instance._playerController.Rotation =2;
        }
         
    }

    public void AiController()
    {
        isPlayer = false;
        
        
    }
}
