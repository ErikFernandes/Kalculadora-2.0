<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kalculadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kalculadora))
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Nome = New System.Windows.Forms.Label()
        Me.BotaoSoma = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Valor2 = New System.Windows.Forms.TextBox()
        Me.BotaoSub = New System.Windows.Forms.RadioButton()
        Me.BotaoMulti = New System.Windows.Forms.RadioButton()
        Me.BotaoDivi = New System.Windows.Forms.RadioButton()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Valor1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Calcular
        '
        resources.ApplyResources(Me.Calcular, "Calcular")
        Me.Calcular.Name = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Nome
        '
        resources.ApplyResources(Me.Nome, "Nome")
        Me.Nome.Name = "Nome"
        '
        'BotaoSoma
        '
        resources.ApplyResources(Me.BotaoSoma, "BotaoSoma")
        Me.BotaoSoma.Name = "BotaoSoma"
        Me.BotaoSoma.TabStop = True
        Me.BotaoSoma.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Valor2
        '
        Me.Valor2.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.Valor2, "Valor2")
        Me.Valor2.Name = "Valor2"
        '
        'BotaoSub
        '
        resources.ApplyResources(Me.BotaoSub, "BotaoSub")
        Me.BotaoSub.Name = "BotaoSub"
        Me.BotaoSub.TabStop = True
        Me.BotaoSub.UseVisualStyleBackColor = True
        '
        'BotaoMulti
        '
        resources.ApplyResources(Me.BotaoMulti, "BotaoMulti")
        Me.BotaoMulti.Name = "BotaoMulti"
        Me.BotaoMulti.TabStop = True
        Me.BotaoMulti.UseVisualStyleBackColor = True
        '
        'BotaoDivi
        '
        resources.ApplyResources(Me.BotaoDivi, "BotaoDivi")
        Me.BotaoDivi.Name = "BotaoDivi"
        Me.BotaoDivi.TabStop = True
        Me.BotaoDivi.UseVisualStyleBackColor = True
        '
        'Resultado
        '
        Me.Resultado.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.Resultado, "Resultado")
        Me.Resultado.Name = "Resultado"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BotaoSoma)
        Me.GroupBox1.Controls.Add(Me.BotaoSub)
        Me.GroupBox1.Controls.Add(Me.BotaoMulti)
        Me.GroupBox1.Controls.Add(Me.BotaoDivi)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Valor1
        '
        Me.Valor1.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.Valor1, "Valor1")
        Me.Valor1.Name = "Valor1"
        '
        'Kalculadora
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Valor2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Valor1)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.Calcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Kalculadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Calcular As Button
    Friend WithEvents Nome As Label
    Friend WithEvents BotaoSoma As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Valor2 As TextBox
    Friend WithEvents BotaoSub As RadioButton
    Friend WithEvents BotaoMulti As RadioButton
    Friend WithEvents BotaoDivi As RadioButton
    Friend WithEvents Resultado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Valor1 As TextBox
End Class
