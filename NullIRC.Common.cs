using System;
using System.Windows.Forms;
using NullTask.NullIRC.UI;

namespace NullTask.NullIRC.Common
{
	/// <summary>
	/// NullIRC �̊T�v�̐����ł��B
	/// </summary>
	public class Apploader
	{
		public Apploader()
		{
		}

		/// <summary>
		/// �A�v���P�[�V�����̃��C�� �G���g�� �|�C���g�ł��B
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormMain());
		}
	}

	public class Config
	{
		public Config()
		{
		}

		public void Load()
		{
		}
		
		public void Save()
		{
		}
	}
}
