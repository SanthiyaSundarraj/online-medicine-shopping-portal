﻿Imports System.Data.OleDb
Public Class mainformad
    Private Sub SIGNINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIGNINToolStripMenuItem.Click
        signin.Show()
    End Sub

    Private Sub SIGNUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIGNUPToolStripMenuItem.Click
        signup.Show()
    End Sub

    Private Sub ADMINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem.Click
        admin.Show()
    End Sub

    Private Sub OFFERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OFFERSToolStripMenuItem.Click
        offer.Show()
    End Sub

    Private Sub DELIVERYLOCATIONSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELIVERYLOCATIONSToolStripMenuItem.Click
        delivery.Show()
    End Sub

    Private Sub VIEWFEEDBACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWFEEDBACKToolStripMenuItem.Click
        viewfeedback.Show()
    End Sub

    Private Sub CONTACTUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTACTUSToolStripMenuItem.Click
        contact.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        home.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        viewmed.show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        updatemed.show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        viewfeedback.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        modoff.show()
    End Sub
End Class