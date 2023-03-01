Public Class frmPayroll

    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblFedTaxTotal.Text = ""
        lblFicaTotal.Text = ""
        lblStateTaxTotal.Text = ""
        lblNetIncomeTotal.Text = ""
        txtGrossPay.Clear()
        txtGrossPay.Focus()
    End Sub
    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        Const cdecFica As Decimal = 0.0765D
        Const cdecFed As Decimal = 0.22D
        Const cdecState As Decimal = 0.04D

        If IsNumeric(txtGrossPay.Text) Then
            decIncome = CDec(txtGrossPay.Text)
            If decIncome > 0 Then
                decFica = decIncome * cdecFica
                lblFicaTotal.Text = decFica.ToString("C")
                decFederal = decIncome * cdecFed
                lblFedTaxTotal.Text = decFederal.ToString("C")
                decState = decIncome * cdecState
                lblStateTaxTotal.Text = decState.ToString("C")

                decNet = decIncome - (decFica + decFederal + decState)
                lblNetIncomeTotal.Text = decNet.ToString("C")
            Else
                MsgBox("Please enter a number greater than 0", , "Invalid Number Entry")
            End If
        Else
                MsgBox("Please enter a positive number", , "Invalid Entry Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFedTaxTotal.Text = ""
        lblFicaTotal.Text = ""
        lblStateTaxTotal.Text = ""
        lblNetIncomeTotal.Text = ""
        txtGrossPay.Clear()
        txtGrossPay.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
