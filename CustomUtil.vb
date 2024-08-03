Imports System.ComponentModel
Imports JRPS_IMS.Store

Public Class CustomUtil

    Public currentChildForm As Form

    Public Sub OpenChildForm(childForm As Form, panel As Panel)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panel.Controls.Add(childForm)
        panel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Public Sub ColorChange(ByVal btn As Double)

        Select Case btn
            Case 1.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(218, 221, 177)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(191, 178, 158)


            Case 2.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(218, 221, 177)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(191, 178, 158)

            Case 3.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(218, 221, 177)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(191, 178, 158)
            Case 4.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(218, 221, 177)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(191, 178, 158)
            Case 5.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(191, 178, 158)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(218, 221, 177)
        End Select

    End Sub



End Class
