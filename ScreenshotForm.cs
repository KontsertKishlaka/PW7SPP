namespace PW7SPP;

public partial class ScreenshotForm : Form
{
    public ScreenshotForm() => 
        InitializeComponent();

    private void ScreenshotForm_Load(object sender, EventArgs e)
    {
        Text = "Форма имитации нажатие <Alt> + <PrintScreen>";
        AltPrintScreenButton.Text = "Имитация <Alt> + <PrintScreen>";
    }

    private void AltPrintScreenButton_Click(object sender, EventArgs e) => 
        SendKeys.Send("%{PRTSC}");
}
