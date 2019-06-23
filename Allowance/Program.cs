using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allowance
{

	static class Global
	{
		private static int _money = 100;

		public static int Money
		{
			get { return _money; }
			set { _money = value; }
		}

        private static string _building = "";

		public static string Building
		{
			get { return _building; }
			set { _building = value; }
		}

        private static string _tasks = "";

        public static string Tasks
        {
            get { return _tasks; }
            set { _tasks = value; }
        }
    }

	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
