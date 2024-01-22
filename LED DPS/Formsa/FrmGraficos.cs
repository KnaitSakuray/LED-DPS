using LED_DPS.Class.Conexao;
using LED_DPS.Class.Model;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using ZXing;
using LED_DPS.RJControls;
using Newtonsoft.Json.Linq;

namespace LED_DPS.Formsa
{
    public partial class FrmGraficos : LED_DPS.Forms.ChildForm
    {
        private System.Windows.Forms.Timer timer;
        public FrmGraficos()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 120000; // Tempo em milissegundos (10 segundos neste caso)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Atualize o gráfico de hora em hora
            ExecuteHoraQuery_LoadChart();

            // Atualize os outros gráficos
            Choice_DB();
        }
        private void Btnconsultackd_Click(object sender, EventArgs e)
        {
            // void HORA
            ExecuteHoraQuery_LoadChart();

            Choice_DB();
        }

        private void Choice_DB()
        {

            if (RB_DIA.Checked)
            {
                /// VOID DIA DIA
                ExecuteDiaQuery_LoadChart();
                return;
            }

            if (RB_MES.Checked)
            {
                // VOID  MES MES
                ExecuteMesQuery_LoadChart();
                return;
            }

            if (RB_ANO.Checked)
            {
                //ANO ANO
                ExecuteAnoQuery_LoadChart();
                return;
            }

        }
        // void para cada query, dentro de um while(Read())

        private void ExecuteHoraQuery_LoadChart()
        {

            List<ColumnChart> columnCharts = new List<ColumnChart>();



            using (SqlConnection conm = new SqlConnection(Conexao.ROTA))

            using (SqlCommand cmd = new SqlCommand(@"
                   SELECT DATEPART(HOUR,data_hora) as HORA_HORA,COUNT([sn]) AS TOTAL

                    FROM [DPS].[dbo].[EMBALAGEM] AS E

                    WHERE CAST(data as date) = @dt_data_INICIO

                    GROUP BY DATEPART(HOUR, data_hora)

                    ORDER BY HORA_HORA;", conm))
            {

                cmd.Parameters.AddWithValue("@dt_data_INICIO", Convert.ToDateTime(Dth_data_INICIO.Value.ToShortDateString()));

                conm.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       
                        columnCharts.Add(new ColumnChart
                        {
                            Time = reader["HORA_HORA"].ToString(),
                            Quantidade = Convert.ToInt32(reader["TOTAL"])
                        });

                    }
                }
            }

            LoadChart1(columnCharts);

        }
        private void ExecuteDiaQuery_LoadChart()
        {

            List<ColumnChart> columnCharts = new List<ColumnChart>();

            using (SqlConnection conm = new SqlConnection(Conexao.ROTA))

            using (SqlCommand cmd = new SqlCommand(@"SELECT DATEPART(DAY, data_hora) as DIA_DIA, COUNT([sn]) AS TOTAL 
                    FROM [DPS].[dbo].[EMBALAGEM] AS E
                    WHERE CAST(data_hora as date) BETWEEN @dt_data_INICIO and @dt_data_FIM
                    GROUP BY DATEPART(DAY, data_hora)
                    ORDER BY DIA_DIA;", conm))
            {

                cmd.Parameters.AddWithValue("@dt_data_INICIO", Convert.ToDateTime(Dth_data_INICIO.Value.ToShortDateString()));
                cmd.Parameters.AddWithValue("@dt_data_FIM", Convert.ToDateTime(Dth_data_FIM.Value.ToShortDateString()));

                conm.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        columnCharts.Add(new ColumnChart
                        {
                            Time = reader["DIA_DIA"].ToString(),
                            Quantidade = Convert.ToInt32(reader["TOTAL"])
                        });

                    }
                }
            }

            LoadChart2(columnCharts, "DIA");

        }
        private void ExecuteMesQuery_LoadChart()
        {
            List<ColumnChart> columnCharts = new List<ColumnChart>();

            using (SqlConnection conm = new SqlConnection(Conexao.ROTA))

            using (SqlCommand cmd = new SqlCommand(@"SELECT DATEPART(MONTH,data_hora) as MES_MES,COUNT([sn]) AS TOTAL 
                            FROM [DPS].[dbo].[EMBALAGEM] AS E
                            WHERE 
                            CAST(data as date) BETWEEN @dt_data_INICIO and @dt_data_FIM
                            GROUP BY DATEPART(MONTH, data_hora)
                            ORDER BY MES_MES;", conm))
            {
                cmd.Parameters.AddWithValue("@dt_data_INICIO", Convert.ToDateTime(Dth_data_INICIO.Value.ToShortDateString()));
                cmd.Parameters.AddWithValue("@dt_data_FIM", Convert.ToDateTime(Dth_data_FIM.Value.ToShortDateString()));

                conm.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        columnCharts.Add(new ColumnChart
                        {
                            Time = reader["MES_MES"].ToString(),
                            Quantidade = Convert.ToInt32(reader["TOTAL"])
                        });
                    }
                }
 
            }
            LoadChart3(columnCharts);
        }
        private void ExecuteAnoQuery_LoadChart()
        {
            List<ColumnChart> columnCharts = new List<ColumnChart>();

            using (SqlConnection conm = new SqlConnection(Conexao.ROTA))
            using (SqlCommand cmd = new SqlCommand(@"SELECT DATEPART(YEAR,data_hora) as ANO_ANO,COUNT([sn]) AS TOTAL 
                            FROM [DPS].[dbo].[EMBALAGEM] AS E
                            WHERE 
                            CAST(data as date) BETWEEN @dt_data_INICIO and @dt_data_FIM 
                            GROUP BY DATEPART(YEAR, data_hora)
                            ORDER BY ANO_ANO;", conm))
            {
                cmd.Parameters.AddWithValue("@dt_data_INICIO", Convert.ToDateTime(Dth_data_INICIO.Value.ToShortDateString()));
                cmd.Parameters.AddWithValue("@dt_data_FIM", Convert.ToDateTime(Dth_data_FIM.Value.ToShortDateString()));

                conm.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        columnCharts.Add(new ColumnChart
                        {
                            Time = reader["ANO_ANO"].ToString(),
                            Quantidade = Convert.ToInt32(reader["TOTAL"])
                        });
                    }
                }
            }

            LoadChart4(columnCharts);
        }

        private void LoadChart1(List<ColumnChart> data)
        {

            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();

            ColumnSeries col = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = Point => Point.Y.ToString(),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 128, 0)),
                Fill = new SolidColorBrush
                {
                    Color = System.Windows.Media.Color.FromRgb(245, 118, 0),
                    Opacity = .6
                },
                FontSize = 14,
                Foreground = System.Windows.Media.Brushes.Black
            };


            Axis ax = new Axis()
            {
                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "Hora",
                Separator = new Separator()
                {
                    Step = 1,
                    IsEnabled = false,
                }
            };

            ax.Labels = new List<string>();

            foreach (var item in data)
            {

                col.Values.Add(item.Quantidade);

                ax.Labels.Add(item.Time);

            }

            cartesianChart1.Series.Add(col);//Y
            cartesianChart1.AxisX.Add(ax);//X

            cartesianChart1.AxisY.Add(new Axis
            {
                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "Quantidade",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
            });
        }

        private void LoadChart2(List<ColumnChart> data, string Titulo)
        {
            cartesianChart2.Series.Clear();
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisY.Clear();

            ColumnSeries col = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = Point => Point.Y.ToString(),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 128, 0)),
                Fill = new SolidColorBrush
                {
                    Color = System.Windows.Media.Color.FromRgb(245, 118, 0),
                    Opacity = .6
                },
                FontSize = 14,
                Foreground = System.Windows.Media.Brushes.Black
            };


            Axis ax = new Axis()
            {
                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = Titulo,
                Separator = new Separator()
                {
                    Step = 1,
                    IsEnabled = false,
                }
            };

            ax.Labels = new List<string>();

            foreach (var item in data)
            {

                col.Values.Add(item.Quantidade);

                ax.Labels.Add(item.Time);

            }

            cartesianChart2.Series.Add(col);//Y
            cartesianChart2.AxisX.Add(ax);//X

            cartesianChart2.AxisY.Add(new Axis
            {
                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "Quantidade",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
            });
        }

        private void LoadChart3(List<ColumnChart> data)
        {

            cartesianChart2.Series.Clear();
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisY.Clear();

            ColumnSeries col = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = Point => Point.Y.ToString(),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 128, 0)),
                Fill = new SolidColorBrush
                {
                    Color = System.Windows.Media.Color.FromRgb(245, 118, 0),
                    Opacity = .6
                },
                FontSize = 14,
                Foreground = System.Windows.Media.Brushes.Black
            };


            Axis ax = new Axis()
            {
                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "Mes",
                Separator = new Separator()
                {
                    Step = 1,
                    IsEnabled = false,
                }
            };

            ax.Labels = new List<string>();

            foreach (var item in data)
            {

                col.Values.Add(item.Quantidade);

                ax.Labels.Add(item.Time);

            }

            cartesianChart2.Series.Add(col);//Y
            cartesianChart2.AxisX.Add(ax);//X

            cartesianChart2.AxisY.Add(new Axis
            {
                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "Quantidade",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
            });
        }

        private void LoadChart4(List<ColumnChart> data)
        {

            cartesianChart2.Series.Clear();
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisY.Clear();

            ColumnSeries col = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = Point => Point.Y.ToString(),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 128, 0)),
                Fill = new SolidColorBrush
                {
                    Color = System.Windows.Media.Color.FromRgb(245, 118, 0),
                    Opacity = .6
                },
                FontSize = 14,
                Foreground = System.Windows.Media.Brushes.Black
            };


            Axis ax = new Axis()
            {
                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "Ano",
                Separator = new Separator()
                {
                    Step = 1,
                    IsEnabled = false,
                }
            };

            ax.Labels = new List<string>();

            foreach (var item in data)
            {

                col.Values.Add(item.Quantidade);

                ax.Labels.Add(item.Time);

            }

            cartesianChart2.Series.Add(col);//Y
            cartesianChart2.AxisX.Add(ax);//X

            cartesianChart2.AxisY.Add(new Axis
            {
                FontSize = 18,
                Foreground = System.Windows.Media.Brushes.Black,
                Title = "Quantidade",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
            });
        }

        private void FrmGraficos_Load(object sender, EventArgs e)
        {
            // Itera sobre todos os controles do formulário

            //foreach (RJControls.RJDatePicker ctrl in Controls)
            //{
            //    // Verifica se o controle é um DateTimePicker e se o nome começa com "Dth"
            //    if (ctrl is RJDatePicker && ctrl.Name.StartsWith("Dth"))
            //    {
            //        // Converte o controle para DateTimePicker e define a data para hoje
            //        ((RJDatePicker)ctrl).Value = DateTime.Now;
            //    }
            //}

            Dth_data_FIM.Value = DateTime.Now;
            Dth_data_INICIO.Value = DateTime.Now.AddDays(-1);

        }
    }
}
