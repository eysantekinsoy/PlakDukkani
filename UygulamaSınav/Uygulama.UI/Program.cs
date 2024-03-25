using Uygulama.BL.Models;

namespace Uygulama.UI
{
	internal static class Program
	{
		public static KullaniciModel LoginUser { get; set; }
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}