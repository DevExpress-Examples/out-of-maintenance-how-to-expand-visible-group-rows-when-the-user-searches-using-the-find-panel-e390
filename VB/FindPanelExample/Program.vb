Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports System.Collections.Generic

Namespace FindPanelExample
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			BonusSkins.Register()
			UserLookAndFeel.Default.SkinName = "Seven"
			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace