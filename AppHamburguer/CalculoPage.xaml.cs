namespace AppHamburguer;

public partial class CalculoPage : ContentPage
{
	public CalculoPage()
	{
		InitializeComponent();
	}

    private void OnLimparCliked(object sender, EventArgs e)
    {

    }

    private void OnCalcularCliked(object sender, EventArgs e)
    {
        //1.Declaração prévie das variáveis
        double etanol;
        double gasolina;

        //2.Vlidação dos campos de texto (conversão para double e verificação de valores)
        if (double.TryParse(precoEtanoltxt.Text, out etanol) && etanol > 0 &&
            double.TryParse(precoGasolinatxt.Text, out gasolina) && gasolina > 0)
        {
            //3. Cálculo da razão/proporção entre Etanol e Gasolina
            //Regra dos 70% do preço da gasolina, vale a pena abastecer com etanol.
            double proporcao = etanol / gasolina;

            //4. Verificação de qual combustível compensa mais
            if(proporcao <= 0.70)
            {
                //Exibe a propor ção em formato percentual com uma casa decimal
                lblResultado.Text = $"Vale a pena abastecer com ETANOL!\n(Proporção: {proporcao:P1})";
                lblResultado.TextColor = Colors.Green;
            }
            else
            {
                lblResultado.Text = $"Vale a pena abastecer com GASOLINA!\n(Proporção: {proporcao:P1})";
                lblResultado .TextColor = Colors.Blue;
            }
        }
        else
        {
            //Mensagem de carro caso algum campo esteja vazio ou inválido
            lblResultado.Text = "Por favol, digite valores válidos e maiores que zero para o etanol e a gasolina";
            lblResultado.TextColor = Colors .Red;
        }

    }
}