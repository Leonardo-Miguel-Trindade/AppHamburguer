namespace AppHamburguer;

public partial class CalcularAutonomia : ContentPage
{
	public CalcularAutonomia()
	{
		InitializeComponent();
	}
	
private void OnCalcularAutonomiaClicked(object sender, EventArgs e)
    {
        // 1. Declaração prévia das variáveis
        double distancia;
        double litros;

        //2. Tenta converter os textos e verifica se são maiores que zero
        if (double.TryParse(txtDistancia.Text, out distancia) && distancia > 0 &&
            double.TryParse(txtLitros.Text, out litros) && litros > 0)
        {
            // 3. Cálculo da autonomia e exibição do resultado
            double autonomia = distancia / litros;
            lblResultado.Text = $"Autonomia: {autonomia:F2} km/l";

        }else
		{
            //Mensagem de erro se algum valor for inválido ou menor/igual a zero
            lblResultado.Text = "Por favor, insira valores válidos e maiores que zero para distância e litros";
		}
    }

    private void OnLimparClicked(object sender, EventArgs e)
    {
        lblResultado.Text = string.Empty;
        txtDistancia.Text = string.Empty;
        txtLitros.Text = string.Empty;
    }
}