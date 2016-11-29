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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        '--------------------------------------
        ' Description: Program exits on click.
        '--------------------------------------

        Me.Close()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim intDieIndex As Integer

        For intDieIndex = 0 To 4
            cintDie(intDieIndex) = CInt(Rnd() * 6) + 1
        Next intDieIndex
    End Sub
End Class