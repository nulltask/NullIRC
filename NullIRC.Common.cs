using System;
using System.Windows.Forms;
using NullTask.NullIRC.UI;

namespace NullTask.NullIRC.Common
{
	/// <summary>
	/// NullIRC の概要の説明です。
	/// </summary>
	public class Apploader
	{
		public Apploader()
		{
		}

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
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
