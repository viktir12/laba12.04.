private void AddDataEntryButton()
{
    var dataEntryButton = new Button 
    { 
        Text = "Ввести данные",
        Location = new Point(20, 60),
        Size = new Size(200, 30)
    };
    
    dataEntryButton.Click += async (sender, e) => 
    {
        using (var form = new DataEntryForm())
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Вы ввели: {form.EnteredData}", "Данные получены");
            }
        }
    };
    
    this.Controls.Add(dataEntryButton);
}