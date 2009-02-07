using System;
using System.Collections;
using System.Threading;
using System.Drawing;
using System.Net.Sockets;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Text;
using NullTask.NullIRC.UI;
using NullTask.NullIRC.Tokenizer;

namespace NullTask.NullIRC.Connection
{
	public class IrcConnectionManager
	{
		public IrcConnectionManager(FormMain form)
		{
			_form = form;
		}

		private Thread tGet = null;
		private TcpClient tcpClient = null;
		private NetworkStream netStream = null;
		private bool isConnect = false;
		public Hashtable htServer = new Hashtable();
		public Hashtable htChannel = new Hashtable();
		public IrcCommander ircCommander = null;
		private IrcTokenizer ircTokenizer = null;
		private FormMain _form = null;
		public IrcChannel chTemp = null;
		private string _message = string.Empty;

		public void ConnectionStart(string server, int port, string nick, string name)
		{
			_form.TurnOffButtonEnabled();
			ircTokenizer = new IrcTokenizer(_form, this);

			AddChannel(server, 0);

			try
			{
				tcpClient = new TcpClient(server, port);
				netStream = tcpClient.GetStream();
				isConnect = true;
			}
			catch
			{
			}

			htServer[server] = new IrcServer(server, port, nick, name);
			htChannel[server] = new IrcChannel(server);

			ircCommander = new IrcCommander(netStream);

			ircCommander.Nick(nick);
			Get();

			if(isConnect)
			{
				ircCommander.User(name, 0);
				Get();

				tGet = new Thread(new ThreadStart(GetLoop));
				tGet.IsBackground = true;
				tGet.Start();

				foreach(string channel in _form.tboxAutoJoin.Lines)
				{
					ircCommander.Join(channel);
				}
			}
		}

		public void AddChannel(string channelname, int users)
		{
			if(htChannel[channelname] == null)
			{
				chTemp = new IrcChannel(channelname);
				chTemp.Message = "You have joined " + channelname;
				htChannel[channelname] = chTemp;
				ListViewItem items = new ListViewItem(channelname);
				items.SubItems.Add(users.ToString());
				_form.lvwChannel.Items.Add(items);
			}
		}

		private void GetChannelFromHashtable(string key, string line)
		{
			chTemp = (IrcChannel)htChannel[key];
			chTemp.Message = line;
		}

		public void ConnectionClose()
		{
			isConnect = false;

			_form.TurnOnButtonEnabled();

			tcpClient.Close();

			if(tGet != null)
			{
				if(tGet.ThreadState == ThreadState.Running)
				{
					tGet.Abort();
				}
			}

			foreach(ListViewItem items in _form.lvwChannel.Items)
			{
				items.ForeColor = Color.Gray;
			}
		}

		private void Get()
		{
			try
			{
				do				
				{
					if(!isConnect) return;
					byte[] buff = new byte[0x1000];
					int size = netStream.Read(buff, 0, buff.Length);
					ircTokenizer.Analyze(Encoding.GetEncoding("iso-2022-jp").GetString(buff, 0, buff.Length));
					
				}
				while(netStream.DataAvailable);
			}
			catch
			{
			}
		}

		private void GetLoop()
		{
			while(true)
			{
				Get();
			}
		}

		public bool IsConnect
		{
			get
			{
				return isConnect;
			}
		}

		public string Message
		{
			get
			{
				return _message;
			}
			set
			{
				_message += value + "\n";
			}
		}
	}

	public class IrcCommander
	{
		public IrcCommander(NetworkStream nstream)
		{
			netStream = nstream;
		}

		NetworkStream netStream = null;

		private void Send(string Message)
		{
			Message = Message + "\r\n";
			byte[] bb = new byte[0x1000];

			try
			{
				bb = Encoding.GetEncoding("iso-2022-jp").GetBytes(Message);
				netStream.Write(bb, 0, bb.Length);
				netStream.Flush();
			}
			catch
			{
			}
		}

		public enum ChannelMode
		{
			Anonymous,
			Invite,
		}

		public enum UserMode
		{
			a,
			i,
			w,
			r,
			o,
			O,
			s
		}

		public void Command(string command)
		{
			Send(command);
		}

		public void Admin(string servername)
		{
			Send("ADMIN " + servername);
		}

		public void Away(string awaymessage)
		{
			Send("AWAY :" + awaymessage);
		}

		public void Help()
		{
			Send("HELP");
		}

		public void Info()
		{
			Send("INFO");
		}

		public void Join(string channel)
		{
			Send("JOIN " + channel);
		}

		public void Join(string channel, string password)
		{
			Send("JOIN " + channel + " " + password);
		}

		public void Join()
		{
			Send("JOIN 0");
		}

		public void Part(string channel)
		{
			Send("PART " + channel);
		}

		public void Part(string channel, string message)
		{
			Send("PART " + channel + " :" + message);
		}

		public void Pass(string password)
		{
			Send("PASS " + password);
		}

		public void Privmsg(string to, string message)
		{
			Send("PRIVMSG " + to + " :" + message);
		}

		public void Notice(string to, string message)
		{
			//Send();
		}

		public void Quit()
		{
			Send("QUIT");
		}
		public void Quit(string message)
		{
			Send("QUIT :" + message);
		}

		public void Mode(UserMode usermode, string nick, bool isAdd)
		{
			if(isAdd)
				Send("MODE " + nick + "+" + usermode.ToString());
			else
				Send("MODE " + nick + "-" + usermode.ToString());
		}

		public void Squit(string server, string message)
		{
			Send("SQUIT " + server + " :" + message);
		}

		public void Nick(string nickname)
		{
			Send("NICK " + nickname);
		}

		public void User(string username, int mode)
		{
			Send("USER " + username + " " + mode + " * " + username);
		}

		public void Oper(string user, string password)
		{
			Send("OPER " + user + " " + password);
		}

		public void Topic(string channel)
		{
			Send("TOPIC " + channel);
		}

		public void Topic(string channel, string topic)
		{
			Send("TOPIC " + channel + " :" + topic);
		}

		public void Names()
		{
			Send("NAMES");
		}

		public void Names(string channel)
		{
			Send("NAMES " + channel);
		}
	}

	public class IrcServer
	{
		public IrcServer(string sv, int pt, string nk, string nm)
		{
			_server = sv;
			_port = pt;
			_nick = nk;
			_name = nm;
		}

		private string _server;
		private int _port;
		private string _nick;
		private string _name;
		private string _message;

		public string Server
		{
			set
			{
				_server = value;
			}
			get
			{
				return _server;
			}
		}

		public int Port
		{
			set
			{
				_port = value;
			}
			get
			{
				return _port;
			}
		}

		public string Nick
		{
			set
			{
				_nick = value;
			}
			get
			{
				return _nick;
			}
		}

		public string Name
		{
			set
			{
				_name = value;
			}
			get
			{
				return _name;
			}
		}

		public string Message
		{
			set
			{
				_message += value + "\n";
			}
			get
			{
				return _message;
			}
		}
	}

	public class IrcChannel
	{
		public IrcChannel(string name)
		{
			_name = name;
		}

		private struct ChannelMember
		{
			public string MemberName;
			public bool isOperator;
			public bool isVoice;
			public string awayMessage;
		}

		private string _name = string.Empty;
		private string _topic = string.Empty;
		private string _message = string.Empty;
		private ChannelMember[] _channelMember = new ChannelMember[0];

		public void AddChannelMember(string member)
		{
			ChannelMember cmtemp;
			if(member.StartsWith(":")) member = member.Substring(1);

			if(member.StartsWith("@"))
			{
				cmtemp.isOperator = true;
				cmtemp.isVoice = false;
				cmtemp.awayMessage = string.Empty;
				cmtemp.MemberName = member.Substring(1);
			}
			else if(member.StartsWith("+"))
			{
				cmtemp.isOperator = false;
				cmtemp.isVoice = true;
				cmtemp.awayMessage = string.Empty;
				cmtemp.MemberName = member.Substring(1);
			}
			else if(member == "\r")
			{
				return;
			}
			else
			{
				cmtemp.isOperator = false;
				cmtemp.isVoice = false;
				cmtemp.awayMessage = string.Empty;
				cmtemp.MemberName = member;
			}
			AddChannelMemberToStruct(cmtemp);
		}

		private void AddChannelMemberToStruct(ChannelMember cmtemp)
		{
			ChannelMember[] temp = new ChannelMember[_channelMember.Length + 1];
			Array.Copy(_channelMember, temp, Math.Min(_channelMember.Length, temp.Length));
			temp[_channelMember.Length] = cmtemp;
			_channelMember = temp;
		}

		public ListViewItem[] MakeMemberListView()
		{
			ListViewItem[] items = new ListViewItem[_channelMember.Length];
			for(int i = 0; i < _channelMember.Length; i++)
			{
				items[i] = new ListViewItem();
				if(_channelMember[i].isOperator) items[i].Text = "@";
				else if(_channelMember[i].isVoice) items[i].Text = "+";
				else items[i].Text = string.Empty;
				items[i].SubItems.Add(_channelMember[i].MemberName);
			}
			return items;
		}

		public string Message
		{
			set
			{
				_message += DateTime.Now.ToString() + " " + value + "\n";
			}
			get
			{
				return _message;
			}
		}
		public string Topic
		{
			set
			{
				_topic = value;
			}
			get
			{
				return _topic;
			}
		}
		public string Name
		{
			get
			{
				return _name;
			}
		}

		public void DelChannelMember(string member)
		{
		}
	}
}
