using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE1_30092024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public float[] tratamentodalinhadocsv(string slinha)
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


            // Processar os valores numéricos
            for (int i = 1; i < matches.Count; i++)
            {
                // Substituir a vírgula decimal por ponto
                string valueString = matches[i].Groups[1].Value.Replace(",", ".");

                // Tentar converter para float
                if (float.TryParse(valueString, NumberStyles.Float, CultureInfo.InvariantCulture, out float value))
                {
                    values[i - 1] = value; // Armazenar no array de valores
                }
                else
                {
                    Console.WriteLine($"Erro ao converter o valor: {valueString}");
                }
            }

            //Exemplo de saída dos valores
            //Console.WriteLine($"Data: {dateTime}");
            //for (int i = 0; i < values.Length; i++)
            //{
            //    Console.WriteLine($"Valor {i + 1}: {values[i]}");
            //}

            return values;
        }
        //funcao acionada ao clicar 
        private void button1_Click(object sender, EventArgs e)
        {
            float[] c1 = new float[512 * 512];
            float[] fungo = new float[512 * 512];
            float[] c2 = new float[512 * 512];
            float tre, numerador, flor;
            int i, j, l, wind, flag, ii, jj=0, a=0;

            //-------------------------------------------------
            string filePath= "C:\\Users\\Aline\\Downloads\\Data PicoLog May 27, 2024.csv";//alimentar com o nome do arquivo
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            //------------------------------------------------
            i = 0;
            ii = 0;
            l = 0;
            flag = 0;
            flor = 0;
            numerador = 0f;
            wind = (int)(tamanhojanelaform.Value);//todo: parametrizar para ser configuravel
            tre = float.Parse("0.000125");//todo: parametrizar para ser configuravel

            // Read file content
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //if (float.TryParse(line, out c1[i]))
                    if(l>150001)
                    {
                        c1 = tratamentodalinhadocsv(line);
                        if (a == wind)
                        {
                            a = 0;
                            fungo = new float[512 * 512];
                        }
                        fungo[a] = c1[8];
                        a = a + 1;
                        
                        //------------------
                        if (i == wind - 1)//se o contador i for=ao tamanho da janela -1 vai calcular a media
                        {
                            numerador = 0f;//variavel auxiliar que armazena a soma dos registros dentro da janela é zerada
                            for (j = 0; j < wind; j++)//comando de laço de repetiçao
                            {
                                numerador += fungo[j];//acrescido a variavel de soma dos valores da janela
                            }
                            numerador = numerador/ wind;//calculo da media do numerador somado com os valores da janela pelo tamanho da janela

                            if (numerador > tre)//validaçao caso a media seja maior que o valor estipulado ele considera um potencial de ação
                            {
                                flag = 1;//para determinar que um potencial de ação foi encontrado
                                c2[ii] = numerador;//alimenta segundo array com a media da janela do potencial encontrada
                                ii++;//incrementa o contador de indice do array das medias dos potencias de açao
                            }

                            if (flag == 1 && numerador < tre)
                            {
                                flag = 0;
                                flor = 0f;
                                for (j = 0; j < ii; j++)
                                {
                                    if (c2[j] >= flor)
                                    {
                                        flor = c2[j];
                                        jj = j;
                                    }
                                }
                                Console.WriteLine($"{l} ({l - ii + jj}) {flor} {jj}");
                                ii = 0;
                            }
                            for (j = 0; j < wind - 1; j++)
                            {
                                fungo[j] = fungo[j + 1];
                            }
                            i--;
                        }

                        //----------------------------------------------
                        i++;
                    }
                    l++;
                }
            }
        }
    }
}
