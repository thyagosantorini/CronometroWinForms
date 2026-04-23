using System.Diagnostics;

namespace CronometroWinForms
{
    public partial class Form1 : Form
    {

        Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void AlternateBotoes(bool rodando)
        {
            btIniciar.Enabled = !rodando;
            btnParar.Enabled = rodando;
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer1.Start();
            AlternateBotoes(true);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timer1.Stop();
            AlternateBotoes(false);
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            timer1.Stop();
            AlternateBotoes(false);

            AtualizarCronometro();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarCronometro();
        }

        private void AtualizarCronometro()
        {
            var tempo = stopwatch.Elapsed;
            lblHoras.Text = tempo.ToString("hh");
            lblMinutos.Text = tempo.ToString("mm");
            lblSegundos.Text = tempo.ToString("ss");
            lblMilisegundos.Text = tempo.ToString("ff");
        }
    }
}
