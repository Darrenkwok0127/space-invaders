using UnityEngine;

public class invaders : MonoBehaviour
{
    public int rows = 4;
    public int cols = 4;
    public float step = 1.5f;
    public invader[] prefabs;

    private Vector3 _direction = Vector3.left;
    public float speed = 1f;

    private void Awake()
    {
        for (int row = 0; row < rows; row++)
        {
            float positionY = row * 1.5f;
            for (int col = 0; col < cols; col++)
            {
                float positionX = col * 1.5f;
                Vector3 position = new Vector3(positionX, positionY);
                invader invader = Instantiate(prefabs[row % prefabs.Length], this.transform);
                invader.transform.position = position;
                
            }
           
        }
        float X = cols * 1.5f / 2;
        this.transform.position = new Vector3(- X + step /2, this.transform.position.y);
    }
    private void Update()
    {
        this.transform.position += _direction * speed * Time.deltaTime;
        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);

        foreach(Transform invader in this.transform)
        {
            if (_direction == Vector3.right && invader.position.x >= rightEdge.x - 1f)
            {
                _direction = Vector3.left;
            }   
            else if (_direction == Vector3.left && invader.position.x <= leftEdge.x + 1f)
            {
                _direction = Vector3.right;
            }

        }
    }
}
