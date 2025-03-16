using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI.Classes
{
    public class ChatMessage
    {
		private string username = "placeholder";

		public string Username
		{
			get { return this.username; }
			set { username = value; }
		}

        private string message = "placeholder";

        public string Message
        {
            get { return this.message; }
            set { message = value; }
        }


        private string colorValue = "red";

        public string ColorValue
        {
            get { return this.colorValue; }
            set { colorValue = value; }
        }

        public ChatMessage() { }

    }
}
