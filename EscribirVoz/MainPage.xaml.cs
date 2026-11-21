using CommunityToolkit.Maui.Media;
using System.Globalization;

namespace EscribirVoz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void grabando(object? sender, EventArgs e)
        {
            StatusLabel.Text = "Grabando...";
            bool permiso = await SpeechToTextService.RequestPermissionAsync(CancellationToken.None);

            // Aquí puedes agregar la lógica para iniciar la grabación de voz
        }

        private void detener(object? sender, EventArgs e)
        {
            StatusLabel.Text = "Grabación detenida";
            // Aquí puedes agregar la lógica para detener la grabación de voz
        }
    }
}
