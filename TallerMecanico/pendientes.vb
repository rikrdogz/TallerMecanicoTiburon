Public Class pendientes

    Private Sub pendientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub pendientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub pendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellContentClick

    End Sub

    Private Sub tabla_KeyDown(sender As Object, e As KeyEventArgs) Handles tabla.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tabla.Rows.Count > 0 Then
                btnAbrir.PerformClick()

            End If
        End If
       
    End Sub

    Private Sub tabla_SelectionChanged(sender As Object, e As EventArgs) Handles tabla.SelectionChanged
        If tabla.SelectedCells.Count > 0 Then
            Dim i As Integer = tabla.CurrentRow.Index
            With tabla.Rows(i)
                lblServicio.Text = .Cells("serv").Value
                lbldesc.Text = .Cells("desc").Value
            End With
        End If
    End Sub

    Private Sub lblServicio_Click(sender As Object, e As EventArgs) Handles lblServicio.Click

    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        frmServicio_Editar.Dispose()
        Dim continuar As Boolean = True

        If tabla.SelectedCells.Count > 0 Then
            Dim i As Integer = tabla.CurrentRow.Index

            With tabla.Rows(i)
                'ABRIR SERVICIO

                If IsNumeric(.Cells("OC").Value) Then


                Else
                   

                    If .Cells("cot").Value > 0 Then
                        If .Cells("OC").Value.ToString.Length = 0 Then
                            If MessageBox.Show("Este servicio tiene la orden de compra VACIA ¿Desea continuar?", "OC", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then

                                continuar = False

                            End If
                        Else
                            If MessageBox.Show("Este servicio tiene como orden de compra: " & .Cells("oc").Value & " ¿Desea continuar?", "OC", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then

                                continuar = False
                            End If
                        End If

                    End If


                End If
                If continuar Then
                    frmServicio_Editar.MdiParent = MDIPrincipal
                    frmServicio_Editar.NFolio.Value = tabla.Rows(i).Cells("serv").Value
                    frmServicio_Editar.Width = ventana_ancho
                    frmServicio_Editar.Height = ventana_alto

                    frmAutos.Hide()

                    frmServicio_Editar.Show()
                    Me.Dispose()
                End If

               
            End With
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmAutos.Hide()

        Me.Dispose()

        frmAutos.agregar_servicio()
    End Sub
End Class