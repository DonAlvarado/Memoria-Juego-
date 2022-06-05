Public Class Memoria

    Dim seg As Integer
    Dim min As Integer
    Dim hrs As Integer
    Dim pts As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnend.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        random1.Visible = True
        random2.Visible = True
        random3.Visible = True
        random4.Visible = True
        random5.Visible = True
        random6.Visible = True
        random7.Visible = True
        random8.Visible = True
        random9.Visible = True
        random10.Visible = True
        random11.Visible = True
        random12.Visible = True


        segundos.Enabled = False
        minutos.Enabled = False
        horas.Enabled = False

        segundos.Stop()
        minutos.Stop()
        horas.Stop()

        lblseg.Text = 0
        lblmins.Text = 0
        lblhrs.Text = 0

        seg = 0
        min = 0
        hrs = 0


    End Sub

    Private Sub pera2_Click(sender As Object, e As EventArgs) Handles pera2.Click
        random1.Visible = True




    End Sub

    Private Sub random2_Click(sender As Object, e As EventArgs) Handles random2.Click
        random2.Visible = False
    End Sub

    Private Sub kiwi1_Click(sender As Object, e As EventArgs) Handles kiwi1.Click
        random2.Visible = True
    End Sub

    Private Sub random3_Click(sender As Object, e As EventArgs) Handles random3.Click
        random3.Visible = False
    End Sub

    Private Sub manzana2_Click(sender As Object, e As EventArgs) Handles manzana2.Click
        random3.Visible = True
    End Sub

    Private Sub random4_Click(sender As Object, e As EventArgs) Handles random4.Click
        random4.Visible = False
    End Sub

    Private Sub pera1_Click(sender As Object, e As EventArgs) Handles pera1.Click
        random4.Visible = True
    End Sub

    Private Sub random5_Click(sender As Object, e As EventArgs) Handles random5.Click
        random5.Visible = False
    End Sub

    Private Sub manzana1_Click(sender As Object, e As EventArgs) Handles manzana1.Click
        random5.Visible = True
    End Sub

    Private Sub random6_Click(sender As Object, e As EventArgs) Handles random6.Click
        random6.Visible = False

    End Sub

    Private Sub mango2_Click(sender As Object, e As EventArgs) Handles mango2.Click
        random6.Visible = True
    End Sub

    Private Sub random7_Click(sender As Object, e As EventArgs) Handles random7.Click
        random7.Visible = False
    End Sub

    Private Sub uva2_Click(sender As Object, e As EventArgs) Handles uva2.Click
        random7.Visible = True
    End Sub

    Private Sub random8_Click(sender As Object, e As EventArgs) Handles random8.Click
        random8.Visible = False
    End Sub

    Private Sub coco2_Click(sender As Object, e As EventArgs) Handles coco2.Click
        random8.Visible = True
    End Sub

    Private Sub random9_Click(sender As Object, e As EventArgs) Handles random9.Click
        random9.Visible = False
    End Sub

    Private Sub uva1_Click(sender As Object, e As EventArgs) Handles uva1.Click
        random9.Visible = True
    End Sub

    Private Sub random11_Click(sender As Object, e As EventArgs) Handles random11.Click
        random11.Visible = False
    End Sub

    Private Sub kiwi2_Click(sender As Object, e As EventArgs) Handles kiwi2.Click
        random11.Visible = True
    End Sub

    Private Sub random12_Click(sender As Object, e As EventArgs) Handles random12.Click
        random12.Visible = False
    End Sub

    Private Sub mango1_Click(sender As Object, e As EventArgs) Handles mango1.Click
        random12.Visible = True
    End Sub

    Private Sub coco1_Click(sender As Object, e As EventArgs) Handles coco1.Click
        random10.Visible = True
    End Sub

    Private Sub random10_Click(sender As Object, e As EventArgs) Handles random10.Click
        random10.Visible = False
    End Sub

    Private Sub random1_Click(sender As Object, e As EventArgs) Handles random1.Click
        random1.Visible = False
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click



        lblseg.Text = seg
        segundos.Enabled = True
        segundos.Interval = 1000

        lblmins.Text = min
        minutos.Enabled = True
        minutos.Interval = 10000

        lblhrs.Text = hrs
        horas.Enabled = True
        horas.Interval = 100000


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles segundos.Tick

        seg = seg + 1


        lblmins.Text = min
        lblseg.Text = seg
        lblhrs.Text = hrs



        If seg = 60 Then min = min + 1
        If seg = 60 Then seg = 0

        If min = 60 Then hrs = hrs + 1
        If min = 60 Then min = 0



    End Sub
End Class
