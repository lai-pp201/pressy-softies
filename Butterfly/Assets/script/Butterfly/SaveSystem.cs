using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
	//��J�n�x�s��SaveData
	public virtual void Save(object save)
	{
		// �]�w�ɮצW��
		string fileName = string.Format("GameData_{0}{1}{2}_{3}{4}{5}", DateTime.Now.Year, DateTime.Now.Month.ToString("00"), DateTime.Now.Day.ToString("00"), DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"), DateTime.Now.Second.ToString("00"));
		// �N��ƧǦC�Ƭ� JSON �榡
		string savingString = JsonUtility.ToJson(save);
		// �ˬd��Ƨ��O�_�s�b�A���s�b�h�Ы�
		if (System.IO.Directory.Exists(Application.dataPath + "/StreamingAssets/GameData/") == false)
		{
			System.IO.Directory.CreateDirectory(Application.dataPath + "/StreamingAssets/GameData/");
		}
		// �N��Ƽg�J����w���|�� JSON �ɮפ�
		System.IO.File.WriteAllText(Application.dataPath + "/StreamingAssets/GameData/" + fileName, savingString);
	}
}
