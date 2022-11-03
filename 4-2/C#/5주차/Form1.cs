namespace FirstFormApplication
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      int width = 100;
      int heigh = 30;
      int margin = 10;

      for (int i = 0; i < 5; i++) 
      {
        Button button = new Button();
        Controls.Add(button);
        button.Location = new Point(margin, (height + margin) * (i + 1) + margin);
        button.Text = "동적 생성 " + i + "번째"; button.Width = width;
        button.Height = height;
      }
    }
  }
}