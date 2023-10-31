Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt")
    End Sub

    Private Sub clearToppingsBtn_Click(sender As Object, e As EventArgs) Handles clearToppingsBtn.Click
        clearToppings()
    End Sub

    Private Sub clearToppings()
        For Each xObject As Object In gbToppings.Controls
            If TypeOf xObject Is CheckBox Then
                xObject.Checked = False
            End If
        Next
    End Sub

    Private Sub ClearAll()
        clearToppings()

        ' Uncheck the radio buttons
        rbSmall.Checked = False
        rbMedium.Checked = False
        rbLarge.Checked = False
        rbThin.Checked = False
        rbThick.Checked = False
        rbDineIn.Checked = False
        rbTakeOut.Checked = False

        totalTbox.Text = 0
        receiptBox.Text = "            Order Receipt:" & vbCrLf & "---------------------------------------------" & vbCrLf & vbCrLf &
                 "Size: " & vbCrLf & vbCrLf &
                 "Crust Type: " & vbCrLf & vbCrLf &
                 "Order Type: " & vbCrLf & vbCrLf &
                 "Extra Toppings: " & vbCrLf & vbCrLf &
                 "Total: "

        total = 0
    End Sub


    Private Sub clearAllBtn_Click(sender As Object, e As EventArgs) Handles clearAllBtn.Click
        ClearAll()
    End Sub

    Dim size, crust, order As String

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If rbSmall.Checked = False And rbMedium.Checked = False And rbLarge.Checked = False Then
            MsgBox("Please complete the order", MsgBoxStyle.Exclamation)
        ElseIf rbThick.Checked = False And rbThin.Checked = False Then
            MsgBox("Please complete the order", MsgBoxStyle.Exclamation)
        ElseIf rbDineIn.Checked = False And rbTakeOut.Checked = False Then
            MsgBox("Please complete the order", MsgBoxStyle.Exclamation)
        Else
            sql = "INSERT INTO orderTable ([size], [Crust Type], [Order Type], [Extra Cheese], [Mushrooms], [Black Olives], [Onions], [Green Peppers], [Tomatoes], [Date Today], [Time Today], [Total Cost]) " &
          "VALUES (@size, @crust, @order, @extraCheese, @mushrooms, @blackOlives, @onions, @greenPeppers, @tomatoes, @dateToday, @timeToday, @totalCost)"

            cmd = New OleDbCommand(sql, cn)

            With cmd
                .Parameters.AddWithValue("@size", size)
                .Parameters.AddWithValue("@crust", crust)
                .Parameters.AddWithValue("@order", order)
                .Parameters.AddWithValue("@extraCheese", CheckBox1.Checked)
                .Parameters.AddWithValue("@mushrooms", CheckBox2.Checked)
                .Parameters.AddWithValue("@blackOlives", CheckBox3.Checked)
                .Parameters.AddWithValue("@onions", CheckBox4.Checked)
                .Parameters.AddWithValue("@greenPeppers", CheckBox5.Checked)  ' Updated parameter name
                .Parameters.AddWithValue("@tomatoes", CheckBox6.Checked)      ' Updated parameter name
                .Parameters.AddWithValue("@dateToday", DateTime.Now.ToShortDateString())
                .Parameters.AddWithValue("@timeToday", DateTime.Now.ToShortTimeString())
                .Parameters.AddWithValue("@totalCost", total)
            End With

            cmd.ExecuteNonQuery()
            MsgBox("Order saved successfully!", MsgBoxStyle.Information)
            ClearAll()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Call Connection()
    End Sub

    Dim total As Integer

    Private Sub computeBtn_Click(sender As Object, e As EventArgs) Handles computeBtn.Click
        If rbSmall.Checked = False And rbMedium.Checked = False And rbLarge.Checked = False Then
            MsgBox("Please complete the order", MsgBoxStyle.Exclamation)
        ElseIf rbThick.Checked = False And rbThin.Checked = False Then
            MsgBox("Please complete the order", MsgBoxStyle.Exclamation)
        ElseIf rbDineIn.Checked = False And rbTakeOut.Checked = False Then
            MsgBox("Please complete the order", MsgBoxStyle.Exclamation)
        Else

            total = 0

            If rbSmall.Checked Then
                size = "Small"
                total += 80
            ElseIf rbMedium.Checked Then
                size = "Medium"
                total += 100
            Else
                size = "Large"
                total += 120
            End If

            If rbThin.Checked Then
                crust = "Thin Crust"
            ElseIf rbThick.Checked Then
                crust = "Thick Crust"

            End If

            If rbDineIn.Checked Then
                order = "Dine In"
            ElseIf rbTakeOut.Checked Then
                order = "Take Out"
            End If

            Dim extraToppings As New List(Of String)

            If CheckBox1.Checked Then
                extraToppings.Add("Extra Cheese")
                total += 15
            End If
            If CheckBox2.Checked Then
                extraToppings.Add("Mushrooms")
                total += 15
            End If
            If CheckBox3.Checked Then
                extraToppings.Add("Black Olives")
                total += 15
            End If
            If CheckBox4.Checked Then
                extraToppings.Add("Onions")
                total += 15
            End If
            If CheckBox5.Checked Then
                extraToppings.Add("Green Peppers")
                total += 15
            End If
            If CheckBox6.Checked Then
                extraToppings.Add("Tomatoes")
                total += 15
            End If

            Dim extraToppingsText As String = String.Join(", ", extraToppings)

            totalTbox.Text = total
            receiptBox.Text = "            Order Receipt:" & vbCrLf & "---------------------------------------------" & vbCrLf & vbCrLf &
                     "Size: " & size & vbCrLf & vbCrLf &
                     "Crust Type: " & crust & vbCrLf & vbCrLf &
                     "Order Type: " & order & vbCrLf & vbCrLf &
                     "Extra Toppings: " & vbCrLf & extraToppingsText & vbCrLf & vbCrLf &
                     "Total: " & total & "₱"

        End If
    End Sub
End Class
