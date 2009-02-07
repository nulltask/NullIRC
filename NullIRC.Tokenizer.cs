using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections;
using NullTask.NullIRC.UI;
using NullTask.NullIRC.Connection;

namespace NullTask.NullIRC.Tokenizer
{
	public class IrcTokenizer
	{
		public IrcTokenizer(FormMain form, IrcConnectionManager ircConnectionManager)
		{
			_form = form;
			_manager = ircConnectionManager;
			sv = _manager.htServer;
		}

		FormMain _form = null;
		IrcConnectionManager _manager = null;
		IrcChannel chTemp = null;
		Hashtable sv = null;

		public void Analyze(string message)
		{
			message = message.Replace("\0", string.Empty);
			string[] line = message.Split(new char[] { '\n' });

			foreach(string s in line)
			{
				//s = s.Replace("\r", string.Empty);
				if(s == string.Empty) continue;
				string[] token = s.Split(new char[] { ' ' });
				_manager.Message = _form.ApdBackMessage(s);

				if(s.StartsWith(":" + _manager.htChannel["irc.huie.hokudai.ac.jp"]))
				{
					// サーバーからのメッセージ
					//IrcChannel chTemp = _manager.htChannel[ircConnection.Server] as IrcChannel;
					chTemp = _manager.htChannel["irc.huie.hokudai.ac.jp"] as IrcChannel;
					chTemp.Message = s;

					/* :SERVERNAME CODE NAME :MESSAGE */
					/* [0]         [1]  [2]  [3]      */

					switch(token[1])
					{
						case "001":
						{
							/* サーバログイン */
							/* :irc.huie.hokudai.ac.jp 001 NullIRC :Welcome to the Internet Relay Network NullIRC!~NullIRC@ZQ084096.ppp.dion.ne.jp */
							// AddRoom(ircConnection.Server, 0);
							break;
						}
						case "332":
							/* トピック */
							/* :irc.huie.hokudai.ac.jp 332 NullIRC #japan :Welcome to #japan / English or Japanese only, please | 'asl' xiuxing for a chat */
							_manager.AddChannel(token[3], 0);
							chTemp = _manager.htChannel[token[3]] as IrcChannel;
							chTemp.Topic = s.Substring(s.IndexOf(":", 1));
							chTemp.Message = token[3] + " topic:" + chTemp.Topic; // System Message
							break;
						case "353":
						{
							/* メンバリスト */
							/* :irc.huie.hokudai.ac.jp 353 NullIRC @ #IRC談話室 :dirby works siba Gon-zeeN_ Last__ kanara_ yaguti cruiser65 ikuta_aoc Recie_Die Veguna sibikku */
							string chname = string.Empty;
							foreach(string str in token)
							{
								if(str.StartsWith("#") || str.StartsWith("&"))
								{
									chname = str.Trim();
									break;
								}
							}
							_manager.AddChannel(chname, 0);
							chTemp = _manager.htChannel[token[4]] as IrcChannel;
							for(int i = 5; i < token.Length; i++)
							{
								chTemp.AddChannelMember(token[i]);
							}
							break;
						}
					}
				}
				else if(s.StartsWith("PING"))
				{
					/* PING-PONG! */
					
				}
				else if(s.StartsWith("ERROR"))
				{
					/* エラーのばやい */
					_manager.ConnectionClose();
					return;
				}
				else
				{
					/* そのた */
					/* :se-ya!~se-ya@ZQ085076.ppp.dion.ne.jp PRIVMSG #maxXx65535 :test */
					/* :NICKNAME!~HOSTNAME COMMAND CHHANNEL :MESSAGE */
					/* [0]                 [1]     [2]      [3]      */
							
					Regex regex = new Regex(@"");
					Match m = regex.Match(s);

					string print = string.Empty;

					switch(token[1])
					{
						case "PRIVMSG":
							chTemp = _manager.htChannel[token[2]] as IrcChannel;
							print = chTemp.Message
								= "(" + token[0] + ") " + s.Substring(s.LastIndexOf(":"));
							goto default;
						case "NOTICE":
							chTemp = _manager.htChannel[token[2]] as IrcChannel;
							print = chTemp.Message
								= "(" + token[0] + ":Notice) " + s.Substring(s.LastIndexOf(":"));
							goto default;
						default:
							/*if(token[2] == GetActiveChannel())
								//AppendTextMessage(print);*/
							break;
					}
				}
			}
		}
	}
}