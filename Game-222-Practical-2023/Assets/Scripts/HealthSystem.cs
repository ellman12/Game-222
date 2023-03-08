using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthSystem : MonoBehaviour
{
	[SerializeField] private bool bPlayer;
	[SerializeField] private int hp, maxHp;
	[SerializeField] private GameActionTrigger gTrigger;
	[SerializeField] private EnemyHealthBar eHealthBar;

	public static Action<float> UpdateHealthBar = delegate { };
	private bool bAlive;

	private void OnEnable()
	{
		hp = maxHp;
		bAlive = true;
	}

	public void UpdateHealth(int value)
	{
		if (!bAlive) return;

		hp += value;
		hp = Mathf.Clamp(hp, 0, maxHp);
		if (bPlayer)
			UpdateHealthBar(hp / (maxHp * 1f));
		else
			eHealthBar.UpdateHealthBar(hp / (maxHp * 1f));

		if (hp == 0)
		{
			bAlive = false;
			gTrigger.PlaySequence();
		}
	}

	public void ResetHealth()
	{
		hp = maxHp;
		if (bPlayer)
			UpdateHealthBar(1);
		else
			eHealthBar.UpdateHealthBar(1);
	}
}