using UnityEngine;

public class UsingFactory : MonoBehaviour
{
    EnemyFactory enemyFactory = new EnemyFactory();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("애니미 팩토리");
        Enemy enemy = enemyFactory.Create(EnemyFactory.ENEMYTYPE.Gobline);
        enemy.Action();
        Enemy enemy2 = enemyFactory.Create(EnemyFactory.ENEMYTYPE.Slime);
        enemy.Action();
        Enemy enemy3 = enemyFactory.Create(EnemyFactory.ENEMYTYPE.Wolf);
        enemy.Action();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
