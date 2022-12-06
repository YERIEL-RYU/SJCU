public partial class Form1 : Form1
{
  public Form1()
  {
    InitializeComponent();

    Button button = new Button();
    button.Text = "버튼";
    button.Width = 100;
    button.Height = 23;

    button.Click += delegate(object sender, EvetArgs args)
    {
      MessageBox.Show("무명 델리게이트 사용 이벤트 연결");
    }

    button.Click += (sender, args) => 
    {
      MessageBox.Show("람다 사용 이벤트 연결");
    }

    Controls.Add(button);
  }
}