using System;


namespace DarkDepths.HealthSystem
{
    /// <summary>
    /// Health Component for enemies and player.
    /// </summary>
    public class HealthComponent
    {
        public event Action OnDeath;
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; }

        public void TakeDamage(int damage)
        {
            if (CurrentHealth <= 0)
            {
                CurrentHealth = 0;
                OnDeath?.Invoke();
            }
        }
    }

    public class PlayerHealthComponent : HealthComponent, IHealable
    {
        public void Heal(int healAmount)
        {
            CurrentHealth += healAmount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
        }
    }

    /// <summary>
    /// IHealable only applicable to player.
    /// </summary>
    internal interface IHealable
    {
        public void Heal(int healAmount);
    }
}
