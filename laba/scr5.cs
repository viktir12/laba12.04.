public partial class AdvancedControlsForm : Form
{
    public AdvancedControlsForm()
    {
        InitializeComponent();
        this.Size = new Size(400, 400);
        
        // ComboBox
        var comboBox = new ComboBox 
        { 
            Location = new Point(20, 20),
            Width = 200,
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        comboBox.Items.AddRange(new[] { "Вариант 1", "Вариант 2", "Вариант 3" });
        
        // CheckBox
        var checkBox = new CheckBox 
        { 
            Text = "Активировать функцию",
            Location = new Point(20, 60)
        };
        
        // RadioButtons
        var radio1 = new RadioButton { Text = "Опция A", Location = new Point(20, 100) };
        var radio2 = new RadioButton { Text = "Опция B", Location = new Point(20, 130) };
        
        // ListBox
        var listBox = new ListBox 
        { 
            Location = new Point(20, 160),
            Size = new Size(200, 100)
        };
        listBox.Items.AddRange(new[] { "Элемент 1", "Элемент 2", "Элемент 3" });
        
        // Добавляем все элементы на форму
        this.Controls.Add(comboBox);
        this.Controls.Add(checkBox);
        this.Controls.Add(radio1);
        this.Controls.Add(radio2);
        this.Controls.Add(listBox);
    }
}