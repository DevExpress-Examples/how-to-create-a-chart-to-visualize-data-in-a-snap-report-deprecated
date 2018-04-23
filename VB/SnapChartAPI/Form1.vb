Imports System
Imports System.Data
Imports DevExpress.XtraCharts
Imports DevExpress.Snap.Core.API

Namespace SnapChartAPI
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
'            #Region "#CreateChart"
            Dim document As SnapDocument = snapControl.Document
            ' Insert a chart into the document.
            Dim chart As SnapChart = document.CreateSnChart(document.Range.Start)
            chart.BeginUpdate()
            ' Create a data table and bind the chart to it.
            chart.DataSource = CreateChartData()

            ' Populate chart series with data.
            chart.SeriesDataMember = "Year"
            chart.SeriesTemplate.ArgumentDataMember = "Region"
            chart.SeriesTemplate.ValueDataMembers.AddRange(New String() { "Sales" })

            ' Specify the series view options.
            chart.SeriesTemplate.ChangeView(ViewType.Bar)
            chart.SeriesNameTemplate.BeginText = "Year: "

            ' Add the chart title.
            Dim chartTitle As New ChartTitle()
            chartTitle.Text = "DevAV Sales by Regions"
            chartTitle.Alignment = System.Drawing.StringAlignment.Center
            chartTitle.Dock = ChartTitleDockStyle.Top
            chart.Titles.Add(chartTitle)

            ' Add the value axis title.
            Dim diagram As XYDiagram = CType(chart.Diagram, XYDiagram)
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
            diagram.AxisY.Title.Alignment = System.Drawing.StringAlignment.Center
            diagram.AxisY.Title.Text = "Millions of Dollars"

            ' Set the chart size.
            chart.Size = New System.Drawing.Size(640, 425)
            chart.UseExplicitSize = True

            ' Change the chart palette.
            chart.PaletteName = "Slipstream"
            chart.EndUpdate()

            document.Fields.Update()
'            #End Region ' #CreateChart
        End Sub

        #Region "#CreateDataSource"
        Private Function CreateChartData() As DataView
            Dim prevYear As Integer = Date.Now.Year - 1

            ' Create a data table.
            Dim table As New DataTable("ChartData")

            ' Add three columns to the table.
            table.Columns.Add("Year", GetType(Integer))
            table.Columns.Add("Region", GetType(String))
            table.Columns.Add("Sales", GetType(Decimal))

            ' Add data rows to the table.
            table.Rows.Add(prevYear - 2, "Asia", 4.2372R)
            table.Rows.Add(prevYear - 2, "Australia", 1.7871R)
            table.Rows.Add(prevYear - 2, "Europe", 3.0884R)
            table.Rows.Add(prevYear - 2, "North America", 3.4855R)
            table.Rows.Add(prevYear - 2, "South America", 1.6027R)

            table.Rows.Add(prevYear - 1, "Asia", 4.7685R)
            table.Rows.Add(prevYear - 1, "Australia", 1.9576R)
            table.Rows.Add(prevYear - 1, "Europe", 3.3579R)
            table.Rows.Add(prevYear - 1, "North America", 3.7477R)
            table.Rows.Add(prevYear - 1, "South America", 1.8237R)

            table.Rows.Add(prevYear, "Asia", 5.2890R)
            table.Rows.Add(prevYear, "Australia", 2.2727R)
            table.Rows.Add(prevYear, "Europe", 3.7257R)
            table.Rows.Add(prevYear, "North America", 4.1825R)
            table.Rows.Add(prevYear, "South America", 2.1172R)

            Return New DataView(table)
        End Function
        #End Region ' #CreateDataSource
    End Class
End Namespace
