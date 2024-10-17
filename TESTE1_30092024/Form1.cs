using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TESTE1_30092024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float tratamentodalinhadocsv(string slinha, int iColunaAlvo)
        {
            float[] arrf=null;

            // Remover aspas e dividir a linha em partes
            // Regex para separar os valores entre aspas, mantendo os valores com vírgulas decimais intactos
            string pattern = "\"([^\"]*)\"";
            MatchCollection matches = Regex.Matches(slinha, pattern);

            // Array para armazenar os valores
            float[] values = new float[matches.Count - 1]; // Excluindo o primeiro que é a data

            // Pegar a data (primeiro valor)
            string dateTimeString = matches[0].Groups[1].Value;
            DateTime dateTime = DateTime.Parse(dateTimeString);
            string valueString = matches[iColunaAlvo].Groups[1].Value.Replace(",", ".");

            // Tentar converter para float
            if (float.TryParse(valueString, NumberStyles.Float, CultureInfo.InvariantCulture, out float value))
            {
                return value; // Armazenar no array de valores
            }
            else
            {
                Console.WriteLine($"Erro ao converter o valor: {valueString}");
                return -1;
            }

            // Processar os valores numéricos
            //for (int i = 1; i < matches.Count; i++)
            //{
            //    // Substituir a vírgula decimal por ponto
            //    string valueString = matches[i].Groups[1].Value.Replace(",", ".");
            //
            //    // Tentar converter para float
            //    if (float.TryParse(valueString, NumberStyles.Float, CultureInfo.InvariantCulture, out float value))
            //    {
            //        values[i - 1] = value; // Armazenar no array de valores
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Erro ao converter o valor: {valueString}");
            //    }
            //}

            //Exemplo de saída dos valores
            //Console.WriteLine($"Data: {dateTime}");
            //for (int i = 0; i < values.Length; i++)
            //{
            //    Console.WriteLine($"Valor {i + 1}: {values[i]}");
            //}

            //return values;
        }
        public List<string> tratamentodalinhadocsvparagrade(string slinha)
        {
            float[] arrf = null;
            List<string> list = new List<string>();
            string valueString = "";
            // Remover aspas e dividir a linha em partes
            // Regex para separar os valores entre aspas, mantendo os valores com vírgulas decimais intactos
            string pattern = "\"([^\"]*)\"";

            MatchCollection matches = Regex.Matches(slinha, pattern);
            // Array para armazenar os valores
            float[] values = new float[matches.Count - 1]; // Excluindo o primeiro que é a data

            // Pegar a data (primeiro valor)
            
            for (int i = 0; i< matches.Count; i++)
            {
                valueString = matches[i].Groups[1].Value.Replace(",", ".");
                list.Add(valueString);
            }
            return list; // Armazenar no array de valores
        }
        public List<float> retornaArrayColuna(int iColunaAlvo, int iLinhaIni, string sArquivo)
        {
            List<float> c1 = new List<float>();// = new ArrayList<float>(); 
            int l = 0;
            float value = 0f;
            DataGridViewRow row;
            //foreach (DataGridViewRow row in dataGridViewArquivo.Rows)
            for (int i =0; i < dataGridViewArquivo.Rows.Count; i++)
            {
                row = dataGridViewArquivo.Rows[i];
                if (row.Cells[iColunaAlvo].Value != null) // Verifica se a célula não é nula
                {
                    var valor = row.Cells[iColunaAlvo].Value.ToString();
                    if (float.TryParse(valor, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                    {
                        c1.Add(value);
                    }
                    //Console.WriteLine($"Valor da célula na coluna {iColunaAlvo}: {valor}");
                }
            }
            //using (StreamReader sr = new StreamReader(sArquivo))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        //if (float.TryParse(line, out c1[i]))
            //        if (l > iLinhaIni)
            //        {
            //            c1.Add(tratamentodalinhadocsv(line, iColunaAlvo));
            //
            //        }
            //        l++;
            //    }
            //}
            return c1;
        }
        public void carregaGrade(string sArquivo, bool bPosCab)
        {
            List<string> valoreslinha = new List<string>();// = new ArrayList<float>(); 
            int l = 0, i =0;
            this.dataGridViewArquivo.Columns.Clear();
            this.dataGridViewArquivo.Rows.Clear();
            using (StreamReader sr = new StreamReader(sArquivo))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //if (float.TryParse(line, out c1[i]))

                    valoreslinha = tratamentodalinhadocsvparagrade(line);
                    if (l ==0)
                    {
                        DataGridViewColumn column = new DataGridViewTextBoxColumn();
                        //column.HeaderText = "Linha"; // Define o título da coluna com o nome da propriedade
                        //column.Name = "Linha"; // Nome interno da coluna
                        //                               //this.dataGridViewArquivo.Columns.Add(column);
                        //dataGridViewArquivo.Invoke(new MethodInvoker(delegate {
                        //    dataGridViewArquivo.Columns.Add(column);
                        //}));

                        if (bPosCab)
                        {
                            valoreslinha.Insert(0, "Linha");
                            for (i =0; i <valoreslinha.Count; i++)
                            {
                                column = new DataGridViewTextBoxColumn();
                                column.HeaderText = valoreslinha[i]; // Define o título da coluna com o nome da propriedade
                                column.Name = valoreslinha[i]; // Nome interno da coluna
                                //this.dataGridViewArquivo.Columns.Add(column);
                                dataGridViewArquivo.Invoke(new MethodInvoker(delegate {
                                    dataGridViewArquivo.Columns.Add(column);
                                }));
                            }
                        }
                        else
                        {
                            for (i = 0; i <= valoreslinha.Count; i++)
                            {
                                column = new DataGridViewTextBoxColumn();
                                column.HeaderText = "Coluna"+i.ToString(); // Define o título da coluna com o nome da propriedade
                                column.Name = "Coluna" + i.ToString(); // Nome interno da coluna
                                this.dataGridViewArquivo.Columns.Add(column);
                                dataGridViewArquivo.Invoke(new MethodInvoker(delegate {
                                    dataGridViewArquivo.Columns.Add(column);
                                }));
                            }
                            valoreslinha.Insert(0, l.ToString());
                            dataGridViewArquivo.Invoke(new MethodInvoker(delegate {
                                this.dataGridViewArquivo.Rows.Add(valoreslinha.ToArray());
                            }));
                            //this.dataGridViewArquivo.Rows.Add(valoreslinha.ToArray());
                        }
                    }
                    else
                    {
                        valoreslinha.Insert(0, l.ToString());
                        dataGridViewArquivo.Invoke(new MethodInvoker(delegate {
                            this.dataGridViewArquivo.Rows.Add(valoreslinha.ToArray());
                        }));
                        //this.dataGridViewArquivo.Rows.Add(valoreslinha.ToArray());
                    }
                    l++;
                }
            }
        }
        //funcao acionada ao clicar 
        private async void  button1_Click(object sender, EventArgs e)
        {
            //Criação de variáveis
            List<float> arrCol = new List<float>();
            List<float> arrfJanela = new List<float>();
            List<float> arrfPicos = new List<float>();
            float tre=0, numerador=0, flor = 0, fMaxMedia=0f, fMaxVar = 0f;
            int i=0, j=0, l=0, wind=0, flag=0, ii=0, jj=0, a=0;
            int iColunaAlvo = 0, iLinhaIni = 0;
            bool bNegativos = false, bPosCab = false;
            string filePath = "";
            int iIndex = -1;
            double dDerivada = 0d;
            List<string> arrsrow;
            filePath = textBoxArquivo.Text;//Pega o arquivo selecionado do computador
            if (!File.Exists(filePath))//Valida caso o arquivo não exista, para abortar o processo
            {
                Console.WriteLine("Arquivo não encontrado!");
                buttonanalise.Text = "Carregar";
                return;
            }
            if (buttonanalise.Text == "Carregar")
            {
                bPosCab = checkBoxPosCab.Checked;
                buttonanalise.Enabled = false;
                await Task.Run(() =>
                {
                    // Coloque aqui a operação demorada
                    
                    carregaGrade(filePath, bPosCab);
                });

                // Atualiza a interface após a conclusão
                buttonanalise.Enabled = true;
                MessageBox.Show("Processamento concluído!");
                buttonanalise.Text = "Analisar";
                return;
            }
            //Seção de resgate das variáveis alimentadas atravéz da UI (User Interface)
            wind = (int)(tamanhojanelaform.Value);
            tre = (float)(formCortePotencial.Value);
            iColunaAlvo = (int)(formColunaAnalise.Value);
            iLinhaIni = (int)(formLinhaInicial.Value);
            dDerivada = (double)(formDerivada.Value);
            bNegativos = checkBoxNegativos.Checked;
            //Realiza chamada ao método que retorna o valor de todas as linhas para a coluna selecionada
            arrCol = retornaArrayColuna(iColunaAlvo, iLinhaIni, filePath) ;
            //Trata chart
            this.chartxY.Series.Clear();
            this.chartxY.Titles.Clear();
            this.chartxY.Titles.Add("Picos de potenciais de ação");
            // Cria uma nova série para o gráfico
            Series serie = new Series("Registros");

            // Define o tipo da série como gráfico de linha
            serie.ChartType = SeriesChartType.Line;
            serie.Points.DataBindY(arrCol);
            // Adiciona a série ao gráfico
            this.chartxY.Series.Add(serie);

            this.chartxY.ChartAreas[0].AxisX.Title = "Tempo (s)";
            this.chartxY.ChartAreas[0].AxisY.Title = "Amplitude (mV)";
            HabilitarZoom();
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = dataGridViewArquivo.Columns[iColunaAlvo].Name; // Nome interno da coluna
            if (dataGridViewResultados.Columns.Count > 0)
            {
                dataGridViewResultados.Columns.Clear();
                dataGridViewResultados.Rows.Clear();

            }
            else iIndex = -1;
                        
            if (iIndex == -1)
            {
                column.HeaderText = dataGridViewArquivo.Columns[iColunaAlvo].HeaderText; // Define o título da coluna com o nome da propriedade
                dataGridViewResultados.Columns.Add(column);
                
                float derivada = 0f;
                List<float> arrfJanelaAnterior = new List<float>(); // Armazenar os valores da janela anterior para cálculo da derivada


                for (l = iLinhaIni; arrCol.Count - wind > l; l++)//Laço de repetição para varredura das linhas da coluna selecionada
                {
                    arrfJanela = new List<float>();//Reset do array de valores da janela
                    arrfJanela = arrCol.GetRange(l,wind);//Adiciona ao array de valores da janela o valor contido na linha atual do array da coluna selecionada

                    //------------------
                
                    numerador = 0f;//variavel auxiliar que armazena a soma dos registros dentro da janela é zerada
                    numerador = arrfJanela.Average();

                    if (arrfJanelaAnterior.Count > 0) derivada = arrfJanela.Average() - arrfJanelaAnterior.Average();
                    arrfJanelaAnterior = new List<float>(arrfJanela);
                    if (numerador >= tre && flag == 0  && derivada > dDerivada)//validaçao caso a media seja maior que o valor estipulado ele considera um potencial de ação
                    {
                        flag = 1;//para determinar que um potencial de ação foi encontrado
                        arrfPicos.Add(numerador);//alimenta segundo array com a media da janela do potencial encontrada
                        ii++;//incrementa o contador de indice do array das medias dos potencias de açao
                        if (numerador > flor)
                        {
                            flor = numerador;
                        }
                        dataGridViewArquivo.Invoke(new MethodInvoker(delegate {
                            arrsrow = new List<string>();
                            arrsrow.Add( $"{l} ({l - ii + jj}) {numerador} {jj} {derivada}" );
                            this.dataGridViewResultados.Rows.Add(arrsrow.ToArray());
                        
                        }));
                    }
                    else if (flag == 1)
                    {
                        flag = 0;
                    }
                    if (fMaxMedia < numerador) fMaxMedia = numerador;
                    if (fMaxVar < derivada) fMaxVar = derivada;
                    l = l + wind - 1;

                    //l++;
                }
                Console.WriteLine($"maior média {fMaxMedia}, e maior derivada {fMaxVar}");
            }
            
        }

        private void HabilitarZoom()
        {
            this.chartxY.ChartAreas[0].CursorX.IsUserEnabled = true;
            this.chartxY.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            this.chartxY.ChartAreas[0].CursorY.IsUserEnabled = true;
            this.chartxY.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            // Permitir o zoom no eixo X
            this.chartxY.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            // Permitir o zoom no eixo Y
            this.chartxY.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            // Definir os botões do mouse para zoom
            this.chartxY.MouseWheel += new MouseEventHandler(chart1_MouseWheel);
        }

        // Evento para capturar o uso da roda do mouse para zoom
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;

            try
            {
                // Verifica se o gráfico tem dados
                if (chart.ChartAreas.Count > 0)
                {
                    // Zoom com rolagem do mouse no eixo X
                    Axis xAxis = chart.ChartAreas[0].AxisX;
                    if (e.Delta < 0) // Zoom out
                    {
                        xAxis.ScaleView.ZoomReset();
                    }
                    else if (e.Delta > 0) // Zoom in
                    {
                        double xMin = xAxis.ScaleView.ViewMinimum;
                        double xMax = xAxis.ScaleView.ViewMaximum;
                        double posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                        double posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;

                        xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    }
                }
            }
            catch { }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Text files (*.csv, *.tsc)|*.csv;*.tsv";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            buttonanalise.Text = "Carregar";
            
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            
            textBoxArquivo.Text = openFileDialog1.FileName;
        }
    }
}
