namespace test_app_1
{
    public partial class Nota
    {
        private class Title
        {
            StreamWriter text = new StreamWriter(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");
            text.WriteLine()
          
        }
    }
}
