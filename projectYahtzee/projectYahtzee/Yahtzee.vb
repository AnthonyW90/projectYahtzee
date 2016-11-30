'=======================================================
' Project:        Lab 2
' Title:          projectYahtzee
' File Name:      Yahtzee.vb
' Date Completed: Not Available
'
' Authors:        Albert A. Shymanskyy - Programmer
'                 Anthony T. Wallace - Programmer
'                 Karolina A. Shymanska - Documentation
'                 Alexander P. Easter - Designer
' Class:          CS 115 Section B
'
' Description:    Not Available
'=======================================================

Option Explicit On
Option Strict On

Public Class frmYahtzee
    Dim cintDie(4) As Integer
    Dim cintPlayerCount As Integer

    Private Sub frmYahtzeeStartLoad_Load(sender As Object, e As EventArgs) Handles Me.Load

        '--------------------------------------------------------------------------------
        ' Description: Load all necessary data. Align all objects in pnlStartMenuTitle.
        '--------------------------------------------------------------------------------

        Dim intSpace As Integer = 10
        'btnConfirm.Visible = False
        'pnlChoosePlayers.Visible = False

        'If data is null Then
        'lblHighScore.Text = "Highscore: " + "0"
        'End If

        lblStartMenuTitle.Left = CInt((pnlStartLoad.Width / 2) -
            (lblStartMenuTitle.Width / 2))
        lblStartMenuTitle.Top = intSpace

        btnLoad.Left = CInt((pnlStartLoad.Width / 2) - btnLoad.Width -
            (intSpace / 2))
        btnLoad.Top = CInt((pnlStartLoad.Height / 4))

        btnNewGame.Left = btnLoad.Left + btnLoad.Width + intSpace
        btnNewGame.Top = btnLoad.Top

        btnExit.Left = CInt(btnLoad.Left + (btnLoad.Width / 2) + (intSpace / 2))
        btnExit.Top = btnLoad.Top + btnLoad.Height + intSpace

        pnlChoosePlayers.Left = CInt((pnlStartLoad.Width / 2) -
            (pnlChoosePlayers.Width / 2))
        pnlChoosePlayers.Top = CInt(pnlStartLoad.Height * (3 / 4) -
            pnlChoosePlayers.Height / 2)

        lblHighScore.Left = btnLoad.Left
        lblHighScore.Top = btnExit.Top + btnExit.Height + intSpace

        lblChoosePlayers.Left = CInt((pnlChoosePlayers.Width / 2) -
            (lblChoosePlayers.Width / 2))
        lblChoosePlayers.Top = intSpace

        rad1P.Width = CInt(pnlChoosePlayers.Width / 7)
        rad2P.Size = rad1P.Size
        rad3P.Size = rad1P.Size
        rad4P.Size = rad1P.Size
        rad5P.Size = rad1P.Size
        rad6P.Size = rad1P.Size
        rad7P.Size = rad1P.Size

        rad1P.Left = CInt(intSpace / 4)
        rad2P.Left = rad1P.Left + rad1P.Width * 1
        rad3P.Left = rad1P.Left + rad1P.Width * 2
        rad4P.Left = rad1P.Left + rad1P.Width * 3
        rad5P.Left = rad1P.Left + rad1P.Width * 4
        rad6P.Left = rad1P.Left + rad1P.Width * 5
        rad7P.Left = rad1P.Left + rad1P.Width * 6
        rad1P.Top = CInt(pnlChoosePlayers.Height / 2 - rad1P.Height / 2)
        rad2P.Top = rad1P.Top
        rad3P.Top = rad1P.Top
        rad4P.Top = rad1P.Top
        rad5P.Top = rad1P.Top
        rad6P.Top = rad1P.Top
        rad7P.Top = rad1P.Top

        btnConfirm.Left = CInt((pnlChoosePlayers.Width / 2) -
            (btnConfirm.Width / 2))
        btnConfirm.Top = CInt(pnlChoosePlayers.Height * (3 / 4) - (btnConfirm.Height / 2))
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        '--------------------------------------
        ' Description: Program exits on click.
        '--------------------------------------

        Me.Close()
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click

        '--------------------------------------------------------
        ' Description: Open window asking for number of players.
        '--------------------------------------------------------

        If pnlChoosePlayers.Visible = False Then
            pnlChoosePlayers.Visible = True
        End If
    End Sub

    Private Sub rad1P_CheckedChanged(sender As Object, e As EventArgs) Handles rad1P.CheckedChanged

        '------------------------------------------------------------------------------------------------------------------
        ' Description: When rad is checked, set btnConfirm visible. Also set cintPlayerCount value to corresponding value.
        '------------------------------------------------------------------------------------------------------------------

        btnConfirm.Visible = True
        cintPlayerCount = 1
    End Sub

    Private Sub rad2P_CheckedChanged(sender As Object, e As EventArgs) Handles rad2P.CheckedChanged

        '-----------------------------------------------------------------------------------------------------------------
        ' Description: When rad is checked, set btnConfirm visible. Also set sngPlayerCount value to corresponding value.
        '-----------------------------------------------------------------------------------------------------------------

        btnConfirm.Visible = True
        cintPlayerCount = 2
    End Sub

    Private Sub rad3P_CheckedChanged(sender As Object, e As EventArgs) Handles rad3P.CheckedChanged

        '-----------------------------------------------------------------------------------------------------------------
        ' Description: When rad is checked, set btnConfirm visible. Also set sngPlayerCount value to corresponding value.
        '-----------------------------------------------------------------------------------------------------------------

        btnConfirm.Visible = True
        cintPlayerCount = 3
    End Sub

    Private Sub rad4P_CheckedChanged(sender As Object, e As EventArgs) Handles rad4P.CheckedChanged

        '-----------------------------------------------------------------------------------------------------------------
        ' Description: When rad is checked, set btnConfirm visible. Also set sngPlayerCount value to corresponding value.
        '-----------------------------------------------------------------------------------------------------------------

        btnConfirm.Visible = True
        cintPlayerCount = 4
    End Sub

    Private Sub rad5P_CheckedChanged(sender As Object, e As EventArgs) Handles rad5P.CheckedChanged

        '-----------------------------------------------------------------------------------------------------------------
        ' Description: When rad is checked, set btnConfirm visible. Also set sngPlayerCount value to corresponding value.
        '-----------------------------------------------------------------------------------------------------------------

        btnConfirm.Visible = True
        cintPlayerCount = 5
    End Sub

    Private Sub rad6P_CheckedChanged(sender As Object, e As EventArgs) Handles rad6P.CheckedChanged

        '-----------------------------------------------------------------------------------------------------------------
        ' Description: When rad is checked, set btnConfirm visible. Also set sngPlayerCount value to corresponding value.
        '-----------------------------------------------------------------------------------------------------------------

        btnConfirm.Visible = True
        cintPlayerCount = 6
    End Sub

    Private Sub rad7P_CheckedChanged(sender As Object, e As EventArgs) Handles rad7P.CheckedChanged

        '-----------------------------------------------------------------------------------------------------------------
        ' Description: When rad is checked, set btnConfirm visible. Also set sngPlayerCount value to corresponding value.
        '-----------------------------------------------------------------------------------------------------------------

        btnConfirm.Visible = True
        cintPlayerCount = 7
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim intDieIndex As Integer
        Dim strDieFileName(4) As String
        Randomize()

        For intDieIndex = 0 To 4
            cintDie(intDieIndex) = CInt(Int(Rnd() * 6) + 1)
            strDieFileName(intDieIndex) = "..\Images\DIE" & CStr(cintDie(intDieIndex)) & ".PNG"
        Next intDieIndex

        picDie1.BackgroundImage = Image.FromFile(strDieFileName(0))
        picDie2.BackgroundImage = Image.FromFile(strDieFileName(1))
        picDie3.BackgroundImage = Image.FromFile(strDieFileName(2))
        picDie4.BackgroundImage = Image.FromFile(strDieFileName(3))
        picDie5.BackgroundImage = Image.FromFile(strDieFileName(4))
    End Sub
End Class