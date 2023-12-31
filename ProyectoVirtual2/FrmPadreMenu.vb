Imports System.Windows.Forms

Public Class FrmPadreMenu

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuCascada.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuOrganizar.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Me.Close()
        FrmUsuario.Close()
    End Sub

    Private Sub CrearMostrarMuestrasPotable(sender As Object, e As EventArgs) Handles mnuMuestrasPotable.Click
        Dim Objhijo As New FrmMuestrasPotable
        Objhijo.MdiParent = Me
        Objhijo.Show()
    End Sub

    Private Sub CrearMostrarResultadosPotable(sender As Object, e As EventArgs) Handles mnuResultadosPotable.Click
        Dim Objhijo As New FrmResultadosPotable
        Objhijo.MdiParent = Me
        Objhijo.Show()
    End Sub

    Private Sub FrmPadreMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmUsuario.Hide()
        ToolStripStatusLabel1.Text = DateTime.Now.ToLocalTime()
    End Sub

    Private Sub FrmPadreMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmUsuario.Close()
    End Sub

End Class
