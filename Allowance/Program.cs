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

        private static int _houseCount = 0;

        public static int HouseCount
        {
            get { return _houseCount; }
            set { _houseCount = value; }
        }

        private static int _bankCount = 0;

        public static int BankCount
        {
            get { return _bankCount; }
            set { _bankCount = value; }
        }

        private static int _storeCount = 0;

        public static int StoreCount
        {
            get { return _storeCount; }
            set { _storeCount = value; }
        }

        private static string _building = "";

		public static string Building
		{
			get { return _building; }
			set { _building = value; }
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
