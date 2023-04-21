# To Do List:

## get movement in unity
fuck around and find out
 - update: we fucked around and found out. Joe now moves.

## Change Joe's hitbox
brother stops half a mile before the fence what the fuck is up with bro's hitbox

## create custom tile palette 
no idea
 - update: we now have a custom tile palette 
 - + perfect software to make tile palettes, this is no longer an issue :)

## implement either a tracking camera that follows Joe or room based camera
research blud idk that one video archie found. danyerl fix it.

## fart sound button
gonna be hilarious you'll be rolling on the floor crying

code for it here:
 public class CollisionSounds : MonoBehaviour {
 
    public AudioSource[] collisionSounds;
 
    public AudioSource collision1;
    public AudioSource collision2;
    public AudioSource collision3;
    public AudioSource collision4;
 
 
   void Start () {
 
        collisionSounds = GetComponents<AudioSource>();
        collision1 = collisionSounds[0];
        collision2 = collisionSounds[1];
        collision3 = collisionSounds[2];
        collision4 = collisionSounds[3];
 
    public void PlayRandomSound()
    {
     
 
    }
}
