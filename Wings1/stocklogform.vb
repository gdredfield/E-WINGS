Imports FontAwesome.Sharp
Public Class stocklogform

    Private currentBtn As IconButton
    Private Sub ActivateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(0, 254, 202)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(64, 64, 64)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
        End If
    End Sub

    'methods'
    Private Sub thisweekSales()
        If Date.Today.DayOfWeek.ToString() = "Sunday" Then
            For i As Integer = 1 To 7
                If i = 1 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-6).ToString("yyyy/MM/dd") & "'", "stockCon", "Monday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-6).ToString("yyyy/MM/dd") & "'", "inValue", "Monday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-6).ToString("yyyy/MM/dd") & "'", "Sales", "Monday", 0, salech)
                    Continue For
                ElseIf i = 2 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-5).ToString("yyyy/MM/dd") & "'", "stockCon", "Tuesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-5).ToString("yyyy/MM/dd") & "'", "inValue", "Tuesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-5).ToString("yyyy/MM/dd") & "'", "Sales", "Tuesday", 0, salech)
                    Continue For
                ElseIf i = 3 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-4).ToString("yyyy/MM/dd") & "'", "stockCon", "Wednesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-4).ToString("yyyy/MM/dd") & "'", "inValue", "Wednesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-4).ToString("yyyy/MM/dd") & "'", "Sales", "Wednesday", 0, salech)
                    Continue For
                ElseIf i = 4 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "stockCon", "Thursday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "inValue", "Thursday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "Sales", "Thursday", 0, salech)
                    Continue For
                ElseIf i = 5 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "stockCon", "Friday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "inValue", "Friday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "Sales", "Friday", 0, salech)
                    Continue For
                ElseIf i = 6 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "stockCon", "Saturday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "inValue", "Saturday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "Sales", "Saturday", 0, salech)
                    Continue For
                ElseIf i = 7 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "stockCon", "Sunday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "inValue", "Sunday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "Sales", "Sunday", 0, salech)
                    Continue For
                End If
            Next
        ElseIf Date.Today.DayOfWeek.ToString() = "Monday" Then
            For i As Integer = 1 To 7
                If i = 1 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "stockCon", "Monday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "inValue", "Monday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "Sales", "Monday", 0, salech)
                    Continue For
                ElseIf i = 2 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "stockCon", "Tuesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "inValue", "Tuesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "Sales", "Tuesday", 0, salech)
                    Continue For
                ElseIf i = 3 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "stockCon", "Wednesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "inValue", "Wednesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "Sales", "Wednesday", 0, salech)
                    Continue For
                ElseIf i = 4 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "stockCon", "Thursday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "inValue", "Thursday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "Sales", "Thursday", 0, salech)
                    Continue For
                ElseIf i = 5 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+4).ToString("yyyy/MM/dd") & "'", "stockCon", "Friday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+4).ToString("yyyy/MM/dd") & "'", "inValue", "Friday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+4).ToString("yyyy/MM/dd") & "'", "Sales", "Friday", 0, salech)
                    Continue For
                ElseIf i = 6 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+5).ToString("yyyy/MM/dd") & "'", "stockCon", "Saturday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+5).ToString("yyyy/MM/dd") & "'", "inValue", "Saturday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+5).ToString("yyyy/MM/dd") & "'", "Sales", "Saturday", 0, salech)
                    Continue For
                ElseIf i = 7 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+6).ToString("yyyy/MM/dd") & "'", "stockCon", "Sunday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+6).ToString("yyyy/MM/dd") & "'", "inValue", "Sunday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+6).ToString("yyyy/MM/dd") & "'", "Sales", "Sunday", 0, salech)
                    Continue For
                End If
            Next

        ElseIf Date.Today.DayOfWeek.ToString() = "Tuesday" Then
            For i As Integer = 1 To 7
                If i = 1 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "stockCon", "Monday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "inValue", "Monday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "Sales", "Monday", 0, salech)
                    Continue For
                ElseIf i = 2 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "stockCon", "Tuesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "inValue", "Tuesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "Sales", "Tuesday", 0, salech)
                    Continue For
                ElseIf i = 3 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "stockCon", "Wednesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "inValue", "Wednesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "Sales", "Wednesday", 0, salech)
                    Continue For
                ElseIf i = 4 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "stockCon", "Thursday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "inValue", "Thursday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "Sales", "Thursday", 0, salech)
                    Continue For
                ElseIf i = 5 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "stockCon", "Friday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "inValue", "Friday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "Sales", "Friday", 0, salech)
                    Continue For
                ElseIf i = 6 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+4).ToString("yyyy/MM/dd") & "'", "stockCon", "Saturday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+4).ToString("yyyy/MM/dd") & "'", "inValue", "Saturday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+4).ToString("yyyy/MM/dd") & "'", "Sales", "Saturday", 0, salech)
                    Continue For
                ElseIf i = 7 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+5).ToString("yyyy/MM/dd") & "'", "stockCon", "Sunday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+5).ToString("yyyy/MM/dd") & "'", "inValue", "Sunday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+5).ToString("yyyy/MM/dd") & "'", "Sales", "Sunday", 0, salech)
                    Continue For
                End If
            Next

        ElseIf Date.Today.DayOfWeek.ToString() = "Wednesday" Then
            For i As Integer = 1 To 7
                If i = 1 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "stockCon", "Monday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "inValue", "Monday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "Sales", "Monday", 0, salech)
                    Continue For
                ElseIf i = 2 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "stockCon", "Tuesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "inValue", "Tuesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "Sales", "Tuesday", 0, salech)
                    Continue For
                ElseIf i = 3 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "stockCon", "Wednesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "inValue", "Wednesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "Sales", "Wednesday", 0, salech)
                    Continue For
                ElseIf i = 4 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "stockCon", "Thursday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "inValue", "Thursday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "Sales", "Thursday", 0, salech)
                    Continue For
                ElseIf i = 5 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "stockCon", "Friday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "inValue", "Friday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "Sales", "Friday", 0, salech)
                    Continue For
                ElseIf i = 6 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "stockCon", "Saturday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "inValue", "Saturday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "Sales", "Saturday", 0, salech)
                    Continue For
                ElseIf i = 7 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+4).ToString("yyyy/MM/dd") & "'", "stockCon", "Sunday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+4).ToString("yyyy/MM/dd") & "'", "inValue", "Sunday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+4).ToString("yyyy/MM/dd") & "'", "Sales", "Sunday", 0, salech)
                    Continue For
                End If
            Next

        ElseIf Date.Today.DayOfWeek.ToString() = "Thursday" Then
            For i As Integer = 1 To 7
                If i = 1 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "stockCon", "Monday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "inValue", "Monday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "Sales", "Monday", 0, salech)
                    Continue For
                ElseIf i = 2 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "stockCon", "Tuesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "inValue", "Tuesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "Sales", "Tuesday", 0, salech)
                    Continue For
                ElseIf i = 3 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "stockCon", "Wednesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "inValue", "Wednesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "Sales", "Wednesday", 0, salech)
                    Continue For
                ElseIf i = 4 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "stockCon", "Thursday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "inValue", "Thursday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "Sales", "Thursday", 0, salech)
                    Continue For
                ElseIf i = 5 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "stockCon", "Friday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "inValue", "Friday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "Sales", "Friday", 0, salech)
                    Continue For
                ElseIf i = 6 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "stockCon", "Saturday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "inValue", "Saturday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "Sales", "Saturday", 0, salech)
                    Continue For
                ElseIf i = 7 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "stockCon", "Sunday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "inValue", "Sunday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+3).ToString("yyyy/MM/dd") & "'", "Sales", "Sunday", 0, salech)
                    Continue For
                End If
            Next

        ElseIf Date.Today.DayOfWeek.ToString() = "Friday" Then
            For i As Integer = 1 To 7
                If i = 1 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-4).ToString("yyyy/MM/dd") & "'", "stockCon", "Monday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-4).ToString("yyyy/MM/dd") & "'", "inValue", "Monday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-4).ToString("yyyy/MM/dd") & "'", "Sales", "Monday", 0, salech)
                    Continue For
                ElseIf i = 2 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "stockCon", "Tuesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "inValue", "Tuesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "Sales", "Tuesday", 0, salech)
                    Continue For
                ElseIf i = 3 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "stockCon", "Wednesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "inValue", "Wednesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "Sales", "Wednesday", 0, salech)
                    Continue For
                ElseIf i = 4 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "stockCon", "Thursday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "inValue", "Thursday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "Sales", "Thursday", 0, salech)
                    Continue For
                ElseIf i = 5 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "stockCon", "Friday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "inValue", "Friday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "Sales", "Friday", 0, salech)
                    Continue For
                ElseIf i = 6 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "stockCon", "Saturday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "inValue", "Saturday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "Sales", "Saturday", 0, salech)
                    Continue For
                ElseIf i = 7 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "stockCon", "Sunday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "inValue", "Sunday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+2).ToString("yyyy/MM/dd") & "'", "Sales", "Sunday", 0, salech)
                    Continue For
                End If
            Next

        ElseIf Date.Today.DayOfWeek.ToString() = "Saturday" Then
            For i As Integer = 1 To 7
                If i = 1 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-5).ToString("yyyy/MM/dd") & "'", "stockCon", "Monday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-5).ToString("yyyy/MM/dd") & "'", "inValue", "Monday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-5).ToString("yyyy/MM/dd") & "'", "Sales", "Monday", 0, salech)
                    Continue For
                ElseIf i = 2 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-4).ToString("yyyy/MM/dd") & "'", "stockCon", "Tuesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-4).ToString("yyyy/MM/dd") & "'", "inValue", "Tuesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-4).ToString("yyyy/MM/dd") & "'", "Sales", "Tuesday", 0, salech)
                    Continue For
                ElseIf i = 3 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "stockCon", "Wednesday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "inValue", "Wednesday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-3).ToString("yyyy/MM/dd") & "'", "Sales", "Wednesday", 0, salech)
                    Continue For
                ElseIf i = 4 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "stockCon", "Thursday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "inValue", "Thursday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-2).ToString("yyyy/MM/dd") & "'", "Sales", "Thursday", 0, salech)
                    Continue For
                ElseIf i = 5 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "stockCon", "Friday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "inValue", "Friday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(-1).ToString("yyyy/MM/dd") & "'", "Sales", "Friday", 0, salech)
                    Continue For
                ElseIf i = 6 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "stockCon", "Saturday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "inValue", "Saturday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.ToString("yyyy/MM/dd") & "'", "Sales", "Saturday", 0, salech)
                    Continue For
                ElseIf i = 7 Then
                    getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where stock_log.sldate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "stockCon", "Sunday", 0, salech)
                    'getchartm("select inValue from invaluetbl where invDate = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "inValue", "Sunday", 0, salech)
                    getchartm("select sum(stotal) from sales where sale_date = '" & Date.Today.AddDays(+1).ToString("yyyy/MM/dd") & "'", "Sales", "Sunday", 0, salech)
                    Continue For
                End If
            Next
        End If
    End Sub
    Private Sub thisweekServings()
        'getchart2("select ingredients.ing_name, sum(item_log.qty), ingredients.ing_rate, item_log.scdate from item_log inner join ingredients on item_log.itemid = ingredients.ing_id 
        '            WHERE  YEARWEEK(`scdate`, 1) = YEARWEEK(CURDATE(), 1) group by ingredients.ing_name", "stockqty", "servings", 0, 1, 2, salech
        getchart("select ingredients.ing_name, sum(item_log.qty), ingredients.ing_rate from item_log inner join ingredients on item_log.itemid = ingredients.ing_id 
                    WHERE  YEARWEEK(`scdate`, 1) = YEARWEEK(CURDATE(), 1) group by ingredients.ing_name", "servings", 0, 1, salech)
        ' getchart("select ingredients.ing_name, sum(stock_log.qty) from stock_log inner join ingredients on stock_log.item_id = ingredients.ing_id  
        '            WHERE  YEARWEEK(`sldate`, 1) = YEARWEEK(CURDATE(), 1) group by ingredients.ing_name", "stockqty", 0, 1, salech)
    End Sub
    Private Sub thisweekStocks()
        getchart("select ingredients.ing_name, sum(stock_log.qty), ingredients.ing_rate from stock_log inner join ingredients on stock_log.item_id = ingredients.ing_id 
                    WHERE  YEARWEEK(`sldate`, 1) = YEARWEEK(CURDATE(), 1) group by ingredients.ing_name", "stockqty", 0, 1, salech)
    End Sub
    Private Sub monthlySales()
        For i As Integer = 1 To 12
            If i = 1 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Jan", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Jan", 0, salech)
                Continue For
            ElseIf i = 2 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Feb", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Feb", 0, salech)
            ElseIf i = 3 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Mar", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Mar", 0, salech)
            ElseIf i = 4 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Apr", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Apr", 0, salech)
            ElseIf i = 5 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "May", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "May", 0, salech)
            ElseIf i = 6 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Jun", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Jun", 0, salech)
            ElseIf i = 7 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Jul", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Jul", 0, salech)
            ElseIf i = 8 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Aug", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Aug", 0, salech)
            ElseIf i = 9 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Sep", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Sep", 0, salech)
            ElseIf i = 10 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Oct", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Oct", 0, salech)
            ElseIf i = 11 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Nov", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Nov", 0, salech)
            ElseIf i = 12 Then
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate) = '" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & i & "'", "stockCon", "Dec", 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year.ToString & "' and month(sale_date) = '" & i & "'", "Sales", "Dec", 0, salech)
            End If
        Next
    End Sub
    Private Sub monthlyServings()
        getchart("select ingredients.ing_name, sum(item_log.qty), ingredients.ing_rate from item_log inner join ingredients on item_log.itemid = ingredients.ing_id 
                    WHERE year(item_log.scdate)='" & Date.Now.Year.ToString & "' and month(item_log.scdate) = '" & Date.Now.Month.ToString & "' group by ingredients.ing_name", "servings", 0, 1, salech)
    End Sub
    Private Sub monthlyStocks()
        getchart("select ingredients.ing_name, sum(stock_log.qty), ingredients.ing_rate from stock_log inner join ingredients on stock_log.item_id = ingredients.ing_id 
                    WHERE year(stock_log.sldate)='" & Date.Now.Year.ToString & "' and month(stock_log.sldate) = '" & Date.Now.Month.ToString & "' group by ingredients.ing_name", "stockqty", 0, 1, salech)
    End Sub
    Private Sub annualSales()
        For i As Integer = 1 To 5
            Dim yeeer As Integer = Date.Now.Year
            If i = 1 Then
                yeeer = yeeer - 4
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate)='" & yeeer.ToString & "'", "stockCon", yeeer.ToString, 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date)='" & yeeer.ToString & "'", "Sales", yeeer.ToString, 0, salech)
                Continue For
            ElseIf i = 2 Then
                yeeer = yeeer - 3
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate)='" & yeeer.ToString & "'", "stockCon", yeeer.ToString, 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date)='" & yeeer.ToString & "'", "Sales", yeeer.ToString, 0, salech)
                Continue For
            ElseIf i = 3 Then
                yeeer = yeeer - 2
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate)='" & yeeer.ToString & "'", "stockCon", yeeer.ToString, 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date)='" & yeeer.ToString & "'", "Sales", yeeer.ToString, 0, salech)
                Continue For
            ElseIf i = 4 Then
                yeeer = yeeer - 1
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate)='" & yeeer.ToString & "'", "stockCon", yeeer.ToString, 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date)='" & yeeer.ToString & "'", "Sales", yeeer.ToString, 0, salech)
                Continue For
            ElseIf i = 5 Then
                yeeer = Date.Now.Year
                getchartm("SELECT sum(stock_log.qty*ingredients.ing_price) stockLog FROM `stock_log` 
                    inner join ingredients on ingredients.ing_id = stock_log.item_id 
                    where year(stock_log.sldate)='" & yeeer.ToString & "'", "stockCon", yeeer.ToString, 0, salech)
                getchartm("select sum(stotal) from sales where year(sale_date)='" & yeeer.ToString & "'", "Sales", yeeer.ToString, 0, salech)
                Continue For
            End If
        Next
    End Sub
    Private Sub annualServings()
        getchart("select ingredients.ing_name, sum(item_log.qty), ingredients.ing_rate from item_log inner join ingredients on item_log.itemid = ingredients.ing_id 
                    WHERE year(item_log.scdate)='" & Date.Now.Year.ToString & "' group by ingredients.ing_name", "servings", 0, 1, salech)
    End Sub
    Private Sub annualStocks()
        getchart("select ingredients.ing_name, sum(stock_log.qty), ingredients.ing_rate from stock_log inner join ingredients on stock_log.item_id = ingredients.ing_id 
                    WHERE year(stock_log.sldate)='" & Date.Now.Year.ToString & "' group by ingredients.ing_name", "stockqty", 0, 1, salech)
    End Sub
    Private Sub clear()
        salech.Series(0).Points.Clear()
        salech.Series(1).Points.Clear()
        salech.Series(2).Points.Clear()
        salech.Series(3).Points.Clear()
        salech.Series(4).Points.Clear()
    End Sub

    Private Sub stocklogform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ActivateButton(weekBtn, Color.Black)
        thisweekSales()
        switchCb.Text = "Sales and Costs"
        salech.Series(1).IsVisibleInLegend = True
        salech.Series(2).IsVisibleInLegend = True
        salech.Series(3).IsVisibleInLegend = False
        salech.Series(4).IsVisibleInLegend = False

    End Sub

    Dim period As Integer = 1
    '1 weekly
    '2 monthly
    '3 annual
    Private Sub switchCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles switchCb.SelectionChangeCommitted
        clear()
        If switchCb.Text = "Sales and Costs" Then
            Label7.Text = "Sales and Costs Report"
            salech.Series(1).IsVisibleInLegend = True
            salech.Series(2).IsVisibleInLegend = True
            salech.Series(3).IsVisibleInLegend = False
            salech.Series(4).IsVisibleInLegend = False
            If period = 1 Then
                thisweekSales()
            ElseIf period = 2 Then
                monthlySales()
            ElseIf period = 3 Then
                annualSales()
            End If
        ElseIf switchCb.Text = "Servings Made" Then
            Label7.Text = "Servings Made"
            salech.Series(1).IsVisibleInLegend = False
            salech.Series(2).IsVisibleInLegend = False
            salech.Series(3).IsVisibleInLegend = True
            salech.Series(4).IsVisibleInLegend = False
            If period = 1 Then
                thisweekServings()
            ElseIf period = 2 Then
                monthlyServings()
            ElseIf period = 3 Then
                annualServings()
            End If
        ElseIf switchCb.Text = "Stocks Consumed" Then
            Label7.Text = "Stocks Consumption Report"
            salech.Series(1).IsVisibleInLegend = False
            salech.Series(2).IsVisibleInLegend = False
            salech.Series(3).IsVisibleInLegend = False
            salech.Series(4).IsVisibleInLegend = True
            If period = 1 Then
                thisweekStocks()
            ElseIf period = 2 Then
                monthlyStocks()
            ElseIf period = 3 Then
                annualStocks()
            End If

        End If
    End Sub

    Private Sub monthBtn_Click(sender As Object, e As EventArgs) Handles monthBtn.Click
        ActivateButton(sender, Color.Black)
        clear()
        period = 2
        If switchCb.Text = "Sales and Costs" Then
            Label7.Text = "Sales and Costs Report"
            salech.Series(1).IsVisibleInLegend = True
            salech.Series(2).IsVisibleInLegend = True
            salech.Series(3).IsVisibleInLegend = False
            salech.Series(4).IsVisibleInLegend = False
            monthlySales()
        ElseIf switchCb.Text = "Servings Made" Then
            Label7.Text = "Servings Made"
            salech.Series(1).IsVisibleInLegend = False
            salech.Series(2).IsVisibleInLegend = False
            salech.Series(3).IsVisibleInLegend = True
            salech.Series(4).IsVisibleInLegend = False
            monthlyServings()
        ElseIf switchCb.Text = "Stocks Consumed" Then
            Label7.Text = "Stocks Consumption Report"
            salech.Series(1).IsVisibleInLegend = False
            salech.Series(2).IsVisibleInLegend = False
            salech.Series(3).IsVisibleInLegend = False
            salech.Series(4).IsVisibleInLegend = True
            monthlyStocks()
        End If
    End Sub

    Private Sub weekBtn_Click(sender As Object, e As EventArgs) Handles weekBtn.Click
        ActivateButton(sender, Color.Black)
        clear()
        period = 1
        If switchCb.Text = "Sales and Costs" Then
            Label7.Text = "Sales and Costs Report"
            salech.Series(1).IsVisibleInLegend = True
            salech.Series(2).IsVisibleInLegend = True
            salech.Series(3).IsVisibleInLegend = False
            salech.Series(4).IsVisibleInLegend = False
            thisweekSales()
        ElseIf switchCb.Text = "Servings Made" Then
            Label7.Text = "Servings Made"
            salech.Series(1).IsVisibleInLegend = False
            salech.Series(2).IsVisibleInLegend = False
            salech.Series(3).IsVisibleInLegend = True
            salech.Series(4).IsVisibleInLegend = False
            thisweekServings()
        ElseIf switchCb.Text = "Stocks Consumed" Then
            Label7.Text = "Stocks Consumption Report"
            salech.Series(1).IsVisibleInLegend = False
            salech.Series(2).IsVisibleInLegend = False
            salech.Series(3).IsVisibleInLegend = False
            salech.Series(4).IsVisibleInLegend = True
            thisweekStocks()
        End If
    End Sub

    Private Sub yearBtn_Click(sender As Object, e As EventArgs) Handles yearBtn.Click
        ActivateButton(sender, Color.Black)
        clear()
        period = 3
        If switchCb.Text = "Sales and Costs" Then
            Label7.Text = "Sales and Costs Report"
            salech.Series(1).IsVisibleInLegend = True
            salech.Series(2).IsVisibleInLegend = True
            salech.Series(3).IsVisibleInLegend = False
            salech.Series(4).IsVisibleInLegend = False
            annualSales()
        ElseIf switchCb.Text = "Servings Made" Then
            Label7.Text = "Servings Made"
            salech.Series(1).IsVisibleInLegend = False
            salech.Series(2).IsVisibleInLegend = False
            salech.Series(3).IsVisibleInLegend = True
            salech.Series(4).IsVisibleInLegend = False
            annualServings()
        ElseIf switchCb.Text = "Stocks Consumed" Then
            Label7.Text = "Stocks Consumption Report"
            salech.Series(1).IsVisibleInLegend = False
            salech.Series(2).IsVisibleInLegend = False
            salech.Series(3).IsVisibleInLegend = False
            salech.Series(4).IsVisibleInLegend = True
            annualStocks()
        End If
    End Sub
End Class