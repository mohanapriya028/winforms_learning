using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Telerik.WinControls.UI.RichTextEditorRibbonUI;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Student_Management_System
{




    public partial class ACC_DASH : Form
    {


        public ACC_DASH()
        {
            InitializeComponent();
            //InitializeTopPanelLabels();

        }

        private void ACC_DASH_Load(object sender, EventArgs e)
        {
            LoadManualData();
        }

        private void LoadManualData()
        {
            // 1️⃣ Manual month data
            List<DashboardMonthData> allMonthsData = new List<DashboardMonthData>
    {
        new DashboardMonthData{ Month="Jan", BOM=50, Memo=40, PO=30 },
        new DashboardMonthData{ Month="Feb", BOM=60, Memo=50, PO=40 },
        new DashboardMonthData{ Month="Mar", BOM=70, Memo=60, PO=50 },
        new DashboardMonthData{ Month="Apr", BOM=80, Memo=70, PO=60 },
        new DashboardMonthData{ Month="May", BOM=90, Memo=80, PO=70 },
        new DashboardMonthData{ Month="Jun", BOM=100, Memo=90, PO=80 },
        new DashboardMonthData{ Month="Jul", BOM=110, Memo=100, PO=90 },
        new DashboardMonthData{ Month="Aug", BOM=120, Memo=110, PO=100 },
        new DashboardMonthData{ Month="Sep", BOM=130, Memo=120, PO=110 },
        new DashboardMonthData{ Month="Oct", BOM=140, Memo=130, PO=120 },
        new DashboardMonthData{ Month="Nov", BOM=150, Memo=140, PO=130 },
        new DashboardMonthData{ Month="Dec", BOM=160, Memo=150, PO=140 }
    };

            // 2️⃣ Map month strings to numbers for filtering
            Dictionary<string, int> monthMap = new Dictionary<string, int>
    {
        {"Jan",1}, {"Feb",2}, {"Mar",3}, {"Apr",4}, {"May",5},
        {"Jun",6}, {"Jul",7}, {"Aug",8}, {"Sep",9}, {"Oct",10}, {"Nov",11}, {"Dec",12}
    };

            // 3️⃣ Get user-selected From/To month
            int fromMonth = dtpfrom.Value.Month; // 1=Jan, 2=Feb...
            int toMonth = 10;

            // 4️⃣ Filter months
            var filteredMonths = allMonthsData
                .Where(m => monthMap[m.Month] >= fromMonth && monthMap[m.Month] <= toMonth)
                .ToList();

            // 5️⃣ Calculate top panel counts
            int totalBOM = filteredMonths.Sum(m => m.BOM);
            int totalMemo = filteredMonths.Sum(m => m.Memo);
            int totalPO = filteredMonths.Sum(m => m.PO);
            int totalAccessories = totalBOM + totalMemo + totalPO; // Example calculation

            IblTotal.Text = $"Total Accessories\n{totalAccessories}";
            IblBom.Text = $"BOM\n{totalBOM}";
            IblMemo.Text = $"Memo\n{totalMemo}";
            IblPO.Text = $"Purchase Order\n{totalPO}";

            // 6️⃣ BOM vs Memo vs PO Chart
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            Series sBOM = new Series("BOM Count") { ChartType = SeriesChartType.Column, Color = Color.MediumPurple };
            Series sMemo = new Series("Memo Issued") { ChartType = SeriesChartType.Line, Color = Color.Orange, BorderWidth = 3 };
            Series sPO = new Series("PO Received") { ChartType = SeriesChartType.Line, Color = Color.Green, BorderWidth = 3 };

            foreach (var m in filteredMonths)
            {
                sBOM.Points.AddXY(m.Month, m.BOM);
                sMemo.Points.AddXY(m.Month, m.Memo);
                sPO.Points.AddXY(m.Month, m.PO);
            }

            chart1.Series.Add(sBOM);
            chart1.Series.Add(sMemo);
            chart1.Series.Add(sPO);

            chart1.Legends.Clear();
            chart1.Legends.Add(new Legend());

            // 7️⃣ BOM vs Memo Approved Chart (for simplicity, use 50% of BOM/Memo as approved)
            //chart2.Series.Clear();
            //chart2.ChartAreas.Clear();
            //chart2.ChartAreas.Add(new ChartArea());

            //Series sBOMApprove = new Series("BOM Approved") { ChartType = SeriesChartType.Bar, Color = Color.MediumPurple };
            //Series sMemoApprove = new Series("Memo Approved") { ChartType = SeriesChartType.Bar, Color = Color.Orange };

            //foreach (var m in filteredMonths)
            //{
            //    sBOMApprove.Points.AddXY(m.Month, m.BOM / 2);
            //    sMemoApprove.Points.AddXY(m.Month, m.Memo / 2);
            //}

            //chart2.Series.Add(sBOMApprove);
            //chart2.Series.Add(sMemoApprove);
            //chart2.Legends.Clear();
            //chart2.Legends.Add(new Legend());

            // Assuming you have a List<DashboardData> called allData
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.ChartAreas.Add(new ChartArea());

            Series sBOMApprove = new Series("BOM Approved")
            {
                ChartType = SeriesChartType.Bar,
                Color = Color.MediumPurple
            };

            Series sMemoApprove = new Series("Memo Approved")
            {
                ChartType = SeriesChartType.Bar,
                Color = Color.Orange
            };

            foreach (var m in filteredMonths)
            {
                // IMPORTANT: Month FIRST, value SECOND
                sBOMApprove.Points.AddXY(m.Month, m.BOM / 2);
                sMemoApprove.Points.AddXY(m.Month, m.Memo / 2);
            }

            chart2.Series.Add(sBOMApprove);
            chart2.Series.Add(sMemoApprove);

            // Axis settings
            ChartArea area = chart2.ChartAreas[0];

            // Enable scrollbar on Y axis (months)
            area.AxisY.ScrollBar.Enabled = true;
            area.AxisY.ScrollBar.IsPositionedInside = true;
            area.AxisY.ScrollBar.Size = 15;

            // IMPORTANT: tell chart how many months to show at once
            area.AxisY.ScaleView.Zoomable = true;
            area.AxisY.ScaleView.Size = 4;   // 👈 show 4 months at a time

            // Prevent auto fitting from killing labels
            area.AxisY.IsLabelAutoFit = false;
            area.AxisY.Interval = 1;

            // Clean look
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            chart2.Legends.Clear();
            chart2.Legends.Add(new Legend());




            // 8️⃣ PO Status Pie Chart (Approved/Pending/Rejected)
            chart3.Series.Clear();
            chart3.ChartAreas.Clear();
            chart3.ChartAreas.Add(new ChartArea());

            int poApproved = filteredMonths.Sum(m => m.PO * 70 / 100); // 70% approved
            int poPending = filteredMonths.Sum(m => m.PO * 20 / 100);  // 20% pending
            int poRejected = filteredMonths.Sum(m => m.PO * 10 / 100); // 10% rejected

            Series sPOStatus = new Series("PO Status") { ChartType = SeriesChartType.Pie };
            sPOStatus.Points.AddXY("Approved", poApproved);
            sPOStatus.Points.AddXY("Pending", poPending);
            sPOStatus.Points.AddXY("Rejected", poRejected);

            foreach (DataPoint dp in sPOStatus.Points)
            {
                dp.Label = $"{dp.YValues[0]}";
            }

            chart3.Series.Add(sPOStatus);
            chart3.Legends.Clear();
            chart3.Legends.Add(new Legend());
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            LoadManualData();
            // Dummy
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }


    public partial class DashboardMonthData
    {
        public string Month { get; set; }
        public int BOM { get; set; }
        public int Memo { get; set; }
        public int PO { get; set; }
    }
}



  
    





