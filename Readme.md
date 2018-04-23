# How to create a chart to visualize data in a Snap report


This example demonstrates how to use the <strong>Snap Chart API</strong> to add a chart to a report document programmatically.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-chart-to-visualize-data-in-a-snap-report-t569171/17.2.3+/media/1416eeaf-8a9c-4d2d-a312-b25d3414283f.png"><br><br>Use the <strong>SnapDocument.CreateSnChart</strong> method to insert a chart into a document. This method returns the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.SnapChart.class">SnapChart </a>object, which represents the newly created chart and provides properties used to populate the chart with data and fine-tune its layout and appearance settings.  <br>Use the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.SnapChart.DataSource.property">SnapChart.DataSource</a> property to bind the chart to data.<br>To provide data to the chart series, assign the data field containing series names to the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.SnapChart.SeriesDataMember.property">SnapChart.SeriesDataMember</a> property and specify the argument and value data members of the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.class">SeriesBase </a>object returned by the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.SnapChart.SeriesTemplate.property">SnapChart.SeriesTemplate</a> property.

<br/>


