namespace PW7SPP;

public partial class ScreenshotForm : Form
{
    public ScreenshotForm() => 
        InitializeComponent();

    private void ScreenshotForm_Load(object sender, EventArgs e)
    {
        Text = "����� �������� ������� <Alt> + <PrintScreen>";
        AltPrintScreenButton.Text = "�������� <Alt> + <PrintScreen>";
    }

    private void AltPrintScreenButton_Click(object sender, EventArgs e) => 
        SendKeys.Send("%{PRTSC}");
}
