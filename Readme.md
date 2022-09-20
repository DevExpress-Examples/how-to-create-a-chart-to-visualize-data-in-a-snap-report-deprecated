<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608593/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T569171)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/SnapChartAPI/Form1.cs) (VB: [Form1.vb](./VB/SnapChartAPI/Form1.vb))
<!-- default file list end -->
# How to create a chart to visualize data in a Snap report

> **Note**
>
> As you may already know, the [WinForms Snap control](https://docs.devexpress.com/WindowsForms/11373/controls-and-libraries/snap) and [Snap Report API](https://docs.devexpress.com/OfficeFileAPI/15188/snap-report-api) are now in maintenance support mode. No new features or capabilities are incorporated into these products. We recommend that you use [DevExpress Reporting](https://docs.devexpress.com/XtraReports/2162/reporting) tool to generate, edit, print, and export your business reports/documents.

This example demonstrates how to use the **Snap Chart API** to add a chart to a report document programmatically.  
![](https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-chart-to-visualize-data-in-a-snap-report-t569171/17.2.3+/media/1416eeaf-8a9c-4d2d-a312-b25d3414283f.png)  

Use the **SnapDocument.CreateSnChart** method to insert a chart into a document. This method returns the [SnapChart](https://docs.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.SnapChart?v=21.2) object, which represents the newly created chart and provides properties used to populate the chart with data and fine-tune its layout and appearance settings. 
Use the [SnapChart.DataSource](https://docs.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.SnapChart.DataSource?v=21.2) property to bind the chart to data.  
To provide data to the chart series, assign the data field containing series names to the [SnapChart.SeriesDataMember](https://docs.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.SnapChart.SeriesDataMember?v=21.2) property and specify the argument and value data members of the [SeriesBase](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase) object returned by the [SnapChart.SeriesTemplate](https://docs.devexpress.com/WindowsForms/DevExpress.Snap.Core.API.SnapChart.SeriesTemplate?v=21.2) property.
