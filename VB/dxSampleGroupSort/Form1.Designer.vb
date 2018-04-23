Namespace dxSampleGroupSort
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis"
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.simpleButton1.Appearance.Options.UseFont = True
            Me.simpleButton1.Location = New System.Drawing.Point(115, 82)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(165, 63)
            Me.simpleButton1.TabIndex = 4
            Me.simpleButton1.Text = "Show Preview"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(399, 221)
            Me.Controls.Add(Me.simpleButton1)
            Me.Name = "Form1"
            Me.Text = "Form1"

            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private formAssistant1 As DevExpress.XtraBars.FormAssistant
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

