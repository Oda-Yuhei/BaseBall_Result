Partial Class PlayerManagementDataSet
    Partial Public Class vw_PitcherResultDataTable
        Private Sub vw_PitcherResultDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
        End Sub

    End Class

    Partial Public Class vw_BatterResultDataTable
        Private Sub vw_BatterResultDataTable_vw_BatterResultRowChanging(sender As Object, e As vw_BatterResultRowChangeEvent) Handles Me.vw_BatterResultRowChanging

        End Sub

    End Class
End Class

Namespace PlayerManagementDataSetTableAdapters

    Partial Public Class vw_PlayerlistTableAdapter
    End Class
End Namespace
