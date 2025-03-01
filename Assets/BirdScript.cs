using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource soundSFX;
      public AudioClip fly; 
    public AudioClip hit;

  
    

    

   
    
    void Start()
    {
         logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
       if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive){

        myRigidbody.linearVelocity = Vector2.up * flapStrength;
        soundSFX.clip = fly;
        soundSFX.Play();
        
       }

       if(transform.position.y <-16 || transform.position.y>16){
            soundSFX.clip = hit;
            soundSFX.Play();
            logic.gameOver();
           
            
          
       }
       
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        birdIsAlive = false;
        soundSFX.clip = hit;
        soundSFX.Play();

    }

    
}
