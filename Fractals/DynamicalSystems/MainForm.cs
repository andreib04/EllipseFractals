    chart.ChartAreas.Clear();
    var area = new ChartArea("main");
    area.BackColor = Color.White;
    area.AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
    area.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
    area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8);
    area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8);
    chart.ChartAreas.Add(area);
}