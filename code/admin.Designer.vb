﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIGNINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIGNUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFFERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELIVERYLOCATIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FEEDBACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWFEEDBACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTACTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cancel)
        Me.GroupBox1.Controls.Add(Me.ok)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Controls.Add(Me.Username)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(113, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 207)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(163, 136)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 10
        Me.Cancel.Text = "Clear"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(75, 136)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 9
        Me.ok.Text = "LOGIN"
        Me.ok.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SIGN IN"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(124, 93)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(160, 22)
        Me.Password.TabIndex = 7
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(124, 57)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(160, 22)
        Me.Username.TabIndex = 6
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(16, 177)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(134, 16)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot password?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.LOGINToolStripMenuItem, Me.ABOUTToolStripMenuItem, Me.FEEDBACKToolStripMenuItem, Me.CONTACTUSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(657, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem1.Text = "HOME"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SIGNINToolStripMenuItem, Me.SIGNUPToolStripMenuItem, Me.ADMINToolStripMenuItem})
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'SIGNINToolStripMenuItem
        '
        Me.SIGNINToolStripMenuItem.Name = "SIGNINToolStripMenuItem"
        Me.SIGNINToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SIGNINToolStripMenuItem.Text = "SIGN IN"
        '
        'SIGNUPToolStripMenuItem
        '
        Me.SIGNUPToolStripMenuItem.Name = "SIGNUPToolStripMenuItem"
        Me.SIGNUPToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SIGNUPToolStripMenuItem.Text = "SIGN UP"
        '
        'ADMINToolStripMenuItem
        '
        Me.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem"
        Me.ADMINToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ADMINToolStripMenuItem.Text = "ADMIN"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OFFERSToolStripMenuItem, Me.DELIVERYLOCATIONSToolStripMenuItem})
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'OFFERSToolStripMenuItem
        '
        Me.OFFERSToolStripMenuItem.Name = "OFFERSToolStripMenuItem"
        Me.OFFERSToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.OFFERSToolStripMenuItem.Text = "OFFERS"
        '
        'DELIVERYLOCATIONSToolStripMenuItem
        '
        Me.DELIVERYLOCATIONSToolStripMenuItem.Name = "DELIVERYLOCATIONSToolStripMenuItem"
        Me.DELIVERYLOCATIONSToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DELIVERYLOCATIONSToolStripMenuItem.Text = "DELIVERY LOCATIONS"
        '
        'FEEDBACKToolStripMenuItem
        '
        Me.FEEDBACKToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWFEEDBACKToolStripMenuItem})
        Me.FEEDBACKToolStripMenuItem.Name = "FEEDBACKToolStripMenuItem"
        Me.FEEDBACKToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.FEEDBACKToolStripMenuItem.Text = "FEEDBACK"
        '
        'VIEWFEEDBACKToolStripMenuItem
        '
        Me.VIEWFEEDBACKToolStripMenuItem.Name = "VIEWFEEDBACKToolStripMenuItem"
        Me.VIEWFEEDBACKToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.VIEWFEEDBACKToolStripMenuItem.Text = "VIEW FEEDBACK"
        '
        'CONTACTUSToolStripMenuItem
        '
        Me.CONTACTUSToolStripMenuItem.Name = "CONTACTUSToolStripMenuItem"
        Me.CONTACTUSToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.CONTACTUSToolStripMenuItem.Text = "CONTACT US"
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.medicine.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(657, 343)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "admin"
        Me.Text = "admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cancel As Button
    Friend WithEvents ok As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIGNINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIGNUPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFFERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELIVERYLOCATIONSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FEEDBACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWFEEDBACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTACTUSToolStripMenuItem As ToolStripMenuItem
End Class
