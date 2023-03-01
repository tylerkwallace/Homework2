<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picPayRoll = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblSubHeader = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnTaxCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblFicaTotal = New System.Windows.Forms.Label()
        Me.lblFedTaxTotal = New System.Windows.Forms.Label()
        Me.lblFedTax = New System.Windows.Forms.Label()
        Me.lblStateTaxTotal = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        Me.lblNetIncomeTotal = New System.Windows.Forms.Label()
        CType(Me.picPayRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayRoll
        '
        Me.picPayRoll.Image = Global.Homework2.My.Resources.Resources.payroll
        Me.picPayRoll.Location = New System.Drawing.Point(0, 0)
        Me.picPayRoll.Name = "picPayRoll"
        Me.picPayRoll.Size = New System.Drawing.Size(423, 241)
        Me.picPayRoll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayRoll.TabIndex = 0
        Me.picPayRoll.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Cooper Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(486, 18)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(277, 32)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Payroll Calculator"
        '
        'lblSubHeader
        '
        Me.lblSubHeader.AutoSize = True
        Me.lblSubHeader.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.lblSubHeader.Location = New System.Drawing.Point(544, 118)
        Me.lblSubHeader.Name = "lblSubHeader"
        Me.lblSubHeader.Size = New System.Drawing.Size(154, 54)
        Me.lblSubHeader.TabIndex = 2
        Me.lblSubHeader.Text = "Paycheck" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblSubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(262, 264)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(158, 25)
        Me.lblGrossPay.TabIndex = 3
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtGrossPay.Location = New System.Drawing.Point(441, 264)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(172, 31)
        Me.txtGrossPay.TabIndex = 4
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTaxCalc.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnTaxCalc.ForeColor = System.Drawing.Color.White
        Me.btnTaxCalc.Location = New System.Drawing.Point(111, 326)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(179, 44)
        Me.btnTaxCalc.TabIndex = 5
        Me.btnTaxCalc.Text = "Compute Taxes"
        Me.btnTaxCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(324, 326)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(179, 44)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(540, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(179, 44)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFICA.Location = New System.Drawing.Point(126, 406)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(52, 22)
        Me.lblFICA.TabIndex = 8
        Me.lblFICA.Text = "FICA:"
        '
        'lblFicaTotal
        '
        Me.lblFicaTotal.AutoSize = True
        Me.lblFicaTotal.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFicaTotal.Location = New System.Drawing.Point(190, 406)
        Me.lblFicaTotal.Name = "lblFicaTotal"
        Me.lblFicaTotal.Size = New System.Drawing.Size(63, 22)
        Me.lblFicaTotal.TabIndex = 9
        Me.lblFicaTotal.Text = "Label1"
        '
        'lblFedTaxTotal
        '
        Me.lblFedTaxTotal.AutoSize = True
        Me.lblFedTaxTotal.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFedTaxTotal.Location = New System.Drawing.Point(418, 406)
        Me.lblFedTaxTotal.Name = "lblFedTaxTotal"
        Me.lblFedTaxTotal.Size = New System.Drawing.Size(63, 22)
        Me.lblFedTaxTotal.TabIndex = 11
        Me.lblFedTaxTotal.Text = "Label2"
        '
        'lblFedTax
        '
        Me.lblFedTax.AutoSize = True
        Me.lblFedTax.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblFedTax.Location = New System.Drawing.Point(300, 406)
        Me.lblFedTax.Name = "lblFedTax"
        Me.lblFedTax.Size = New System.Drawing.Size(107, 22)
        Me.lblFedTax.TabIndex = 10
        Me.lblFedTax.Text = "Federal Tax:"
        '
        'lblStateTaxTotal
        '
        Me.lblStateTaxTotal.AutoSize = True
        Me.lblStateTaxTotal.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblStateTaxTotal.Location = New System.Drawing.Point(645, 406)
        Me.lblStateTaxTotal.Name = "lblStateTaxTotal"
        Me.lblStateTaxTotal.Size = New System.Drawing.Size(63, 22)
        Me.lblStateTaxTotal.TabIndex = 13
        Me.lblStateTaxTotal.Text = "Label4"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblStateTax.Location = New System.Drawing.Point(538, 406)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(90, 22)
        Me.lblStateTax.TabIndex = 12
        Me.lblStateTax.Text = "State Tax:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNetIncome.Location = New System.Drawing.Point(191, 475)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(235, 27)
        Me.lblNetIncome.TabIndex = 15
        Me.lblNetIncome.Text = "Net Paycheck Income:"
        '
        'lblNetIncomeTotal
        '
        Me.lblNetIncomeTotal.AutoSize = True
        Me.lblNetIncomeTotal.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNetIncomeTotal.Location = New System.Drawing.Point(455, 475)
        Me.lblNetIncomeTotal.Name = "lblNetIncomeTotal"
        Me.lblNetIncomeTotal.Size = New System.Drawing.Size(235, 27)
        Me.lblNetIncomeTotal.TabIndex = 16
        Me.lblNetIncomeTotal.Text = "Net Paycheck Income:"
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 572)
        Me.Controls.Add(Me.lblNetIncomeTotal)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStateTaxTotal)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFedTaxTotal)
        Me.Controls.Add(Me.lblFedTax)
        Me.Controls.Add(Me.lblFicaTotal)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxCalc)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblSubHeader)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picPayRoll)
        Me.Name = "frmPayroll"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPayRoll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayRoll As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btnTaxCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblFicaTotal As Label
    Friend WithEvents lblFedTaxTotal As Label
    Friend WithEvents lblFedTax As Label
    Friend WithEvents lblStateTaxTotal As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNetIncome As Label
    Friend WithEvents lblNetIncomeTotal As Label
End Class
