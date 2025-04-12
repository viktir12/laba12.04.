public partial class ControlsForm : Form
{
    public ControlsForm()
    {
        InitializeComponent();
        
        // Создаем элементы управления
        var label = new Label { Text = "Пример метки", Location = new Point(20, 20) };
        var textBox = new TextBox { Location = new Point(20, 50), Width = 200 };
        var button = new Button { Text = "Нажми меня", Location = new Point(20, 80) };
        
        // Добавляем обработчик события для кнопки
        button.Click += (sender, e) => 
        {
            MessageBox.Show($"Вы ввели: {textBox.Text}", "Информация");
        };
        
        // Добавляем элементы на форму
        this.Controls.Add(label);
        this.Controls.Add(textBox);
        this.Controls.Add(button);
    }
}