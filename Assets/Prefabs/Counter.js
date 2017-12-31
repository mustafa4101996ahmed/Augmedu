

function OnTriggerEnter (info : Collider)
{
ScoreCount.gscore +=1;
Destroy(gameObject);
}