public partial class DataEntryForm : Form
{
    public string EnteredData { get; private set; }
    
    public DataEntryForm()
    {
        InitializeComponent();
        
        var label = new Label { Text = "Введите данные:", Location = new Point(20, 20) };
        var textBox = new TextBox { Location = new Point(20, 50), Width = 200 };
        var okButton = new Button { Text = "OK", Location = new Point(20, 80) };
        
        okButton.Click += (sender, e) => 
        {
            EnteredData = textBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        };
        
        this.Controls.Add(label);
        this.Controls.Add(textBox);
        this.Controls.Add(okButton);
    }
}