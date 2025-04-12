private void InitializeComponent()
{
    // ... другие элементы инициализации
    
    var openFormButton = new Button 
    { 
        Text = "Открыть форму с элементами",
        Location = new Point(20, 20),
        Size = new Size(200, 30)
    };
    
    openFormButton.Click += (sender, e) => 
    {
        var controlsForm = new ControlsForm();
        controlsForm.Show();
    };
    
    this.Controls.Add(openFormButton);
}