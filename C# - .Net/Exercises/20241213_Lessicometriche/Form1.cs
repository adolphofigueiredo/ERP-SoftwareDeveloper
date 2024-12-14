using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _20241213_Lessicometriche
{
    public partial class Form1 : Form
    {
        // Dichiarazione del RichTextBox
        private System.Windows.Forms.RichTextBox richTextBoxRisultati;

        public Form1()
        {
            InitializeComponent();

            // Configura RichTextBox
            this.richTextBoxRisultati = new System.Windows.Forms.RichTextBox
            {
                Location = new System.Drawing.Point(12, 150),
                Size = new System.Drawing.Size(760, 200),
                Name = "richTextBoxRisultati"
            };

            // Aggiungi RichTextBox al Form
            this.Controls.Add(this.richTextBoxRisultati);
        }

        private void btn_eseguire_Click(object sender, EventArgs e)
        {
            string filePath = txtbox_PercorsoFile.Text;

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Seleziona un file valido.");
                return;
            }

            string text = File.ReadAllText(filePath);

            // Mostra la conferma del testo letto
            MessageBox.Show($"File letto con successo. Lunghezza del testo: {text.Length} caratteri");

            // 1. Calcolare il numero di frasi
            var sentences = Regex.Split(text, @"\.\s|\.\n").Where(s => !string.IsNullOrWhiteSpace(s));
            int numberOfSentences = sentences.Count();

            // 2. Contare le parole (token)
            var tokens = text.Split(new[] { ' ', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int numberOfTokens = tokens.Length;

            // 3. Calcolare il vocabolario unico
            var vocabulary = tokens.Select(t => t.ToLower().Trim()).Distinct();
            int vocabularySize = vocabulary.Count();

            // 4. Calcolare la ricchezza lessicale
            double lexicalRichness = (double)vocabularySize / numberOfTokens;

            // 5. Parola più frequente
            var mostFrequentWord = tokens.GroupBy(w => w)
                                         .OrderByDescending(g => g.Count())
                                         .FirstOrDefault();

            string mostFrequentWordStr = mostFrequentWord?.Key;
            int frequency = mostFrequentWord?.Count() ?? 0;

            // 6. Frase più lunga
            var longestSentence = sentences.OrderByDescending(s => s.Length).FirstOrDefault();

            // 7. Hapax Legomena
            int hapaxLegomenaCount = tokens.GroupBy(w => w).Count(g => g.Count() == 1);

            // 8. Densità della punteggiatura
            int punctuationCount = text.Count(c => char.IsPunctuation(c));
            double punctuationDensity = (double)punctuationCount / numberOfTokens;

            // Mostra i risultati nel RichTextBox
            richTextBoxRisultato.Text = $"\nNumero di frasi: {numberOfSentences}\n" +
                                        $"Numero di parole: {numberOfTokens}\n" +
                                        $"Vocabolario unico: {vocabularySize}\n" +
                                        $"Ricchezza lessicale (V/N): {lexicalRichness:F2}\n" +
                                        $"Parola più frequente: {mostFrequentWordStr} (ripetuta {frequency} volte)\n" +
                                        $"Hapax Legomena: {hapaxLegomenaCount}\n" +
                                        $"Densità della punteggiatura: {punctuationDensity:F2}\n";
        }

        private void btn_SelezionaFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "File di testo|*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtbox_PercorsoFile.Text = openFileDialog.FileName;
            }
        }
    }
}