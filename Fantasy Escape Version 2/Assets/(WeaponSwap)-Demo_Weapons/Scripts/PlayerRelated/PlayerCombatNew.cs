using UnityEngine;

public class PlayerCombatNew : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 40;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    public int attackMode = 1;
    bool SwaptoOrb;

    public Transform RangeAttackPoint;
    public Transform ArrowPrefab;
    public Transform OrbPrefab;

    // Update is called once per frame
    void Update()
    {
        if (attackMode == 1)
        {
            if (Time.time >= nextAttackTime)
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    Attack1();
                    nextAttackTime = Time.time + 2f / attackRate;
                }
            }
        }

        if (attackMode == 2)
        {
            if (Time.time >= nextAttackTime)
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    BowAttack2();
                    nextAttackTime = Time.time + 2f / attackRate;
                }
            }
        }

        if (attackMode == 3)
        {
            if (Time.time >= nextAttackTime)
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    OrbAttack3();
                    nextAttackTime = Time.time + 2f / attackRate;
                }
            }
        }
    }

    void Attack1()
    {
        // play Attack animation.
        animator.SetTrigger("Attack_Sword");
        // Detect enemies in range of attack.
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        // Damage enemies.
         foreach(Collider2D enemy in hitEnemies)
          { 
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
          }
    }

    void BowAttack2()
    {
        // play Attack animation.
        animator.SetTrigger("Attack_Bow");
        // Spawn the Arrow prefab.
        Instantiate(ArrowPrefab, RangeAttackPoint.position, RangeAttackPoint.rotation);
    }
    void OrbAttack3()
    {
        // play Attack animation.
        animator.SetTrigger("Attack_Orb");
        // Spawn the Orb projectile prefab.
        Instantiate(OrbPrefab, RangeAttackPoint.position, RangeAttackPoint.rotation);
    }
    private void OnDrawGizmos()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
