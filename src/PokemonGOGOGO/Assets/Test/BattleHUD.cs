using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{

	public Text nameText;
	public Text levelText;
	public Slider hpSlider;

	public void SetHUD(Unit unit)
	{
		nameText.text = unit.unitName;
		levelText.text = "Lvl " + unit.unitLevel;
		hpSlider.maxValue = unit.maxHP;
		hpSlider.value = unit.currentHP;
	}

	public void SetHUD(Pokemon pokemon)
	{
		nameText.text = pokemon.Name;
		levelText.text = "Lvl " + pokemon.Level;
		hpSlider.maxValue = pokemon.maxHP;
		hpSlider.value = pokemon.curHP;
	}

	public void SetHP(int hp)
	{
		hpSlider.value = hp;
	}

}
