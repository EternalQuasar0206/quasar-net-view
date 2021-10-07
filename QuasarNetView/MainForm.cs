using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.IO;
using System.Globalization;

namespace QuasarNetView {
  /// <summary>
  /// Description of MainForm.
  /// </summary>
  /// 

  public partial class MainForm: Form {
      public MainForm() {

          InitializeComponent();

          try {
            File.Delete(@".\traces\FWL_Change.cmd");
          } catch {

          }
          try {
            File.Delete(@".\traces\FlushDNS.cmd");
          } catch {

          }

          webBrowser1.Navigate("about:blank");
          webBrowser1.Document.Write("<body onselectstart='return false' oncontextmenu='return false' bgcolor='#101010'>");
          webBrowser1.Document.Write("</body>");
          button8.Enabled = false;
          //Teste de conexão à internet para inicialização do aplicativo
          try {
            var ping = new System.Net.NetworkInformation.Ping();
            ping.Send("www.google.com");
          } catch {
            MessageBox.Show("Você precisa estar conectado à internet para usar esse aplicativo.", "Erro de Conexão");
            this.Close();
          }
          //Obtenção de IP Local
          IPHostEntry host;
          host = Dns.GetHostEntry(Dns.GetHostName());
          foreach(IPAddress ip in host.AddressList) {
            if (ip.AddressFamily.ToString() == "InterNetwork") {
              ip_local.Text = ip.ToString();
            }

          }
          //Pastas importantes para o funcionamento do aplicativo
          if (Directory.Exists(@".\traces")) {

          } else {
            Directory.CreateDirectory(@".\traces\");
            }
            if (Directory.Exists(@".\logs")) {

            } else {
              Directory.CreateDirectory(@".\logs\");
              }

            }

            //Inicialização de Design de movimento

            protected override void WndProc(ref Message m) {
              switch (m.Msg) {
              case 0x84:
                base.WndProc(ref m);
                if ((int) m.Result == 0x1)
                  m.Result = (IntPtr) 0x2;
                return;
              }

              base.WndProc(ref m);
            }

            void Button4Click(object sender, EventArgs e) {
              MessageBox.Show("QuasarNetView (1.0.0) \nAplicativo desenvolvido por Eternal Quasar (Kayky Vitor Cruz) \nTwitter: @QuasarEternum\n \nO Aplicativo conta com a utilização da API Ipfy para obtenção do protocolo público de internet do usuário.", "QuasarNetView");
            }

            void Button5Click(object sender, EventArgs e) {
              string htmlog = "";
              webBrowser1.Document.Write("<script>document.body.innerHTML = '';</script>");
              webBrowser1.Document.Write("<style>a {text-decoration: underline}</style>");
              pb1.Value = 5;
              //Testes anti-bug
              if (textBox1.Text.Trim() == "") {
                textBox1.Text = "localhost";
                pb1.Value = 6;
              }

              //Início de processos de Verificação de Rede

              int NetErrorLevel = 0;
              pb1.Value = 10;
              //Alterações de Design

              //Limpando possíveis arquivos de uma instância anterior
              string rootFolderPath = @".\";
              string filesToDelete = @"*Tr*.txt";
              string[] fileList = System.IO.Directory.GetFiles(rootFolderPath, filesToDelete);
              foreach(string file in fileList) {
                System.IO.File.Delete(file);
              }
              //Análise dos dados inseridos para evitar bugs e erros

              if (textBox1.Enabled == true) {
                if (textBox1.Text.Contains("http://")) {
                  textBox1.Text = textBox1.Text.Replace("http://", "");
                }
                if (textBox1.Text.Contains("https://")) {
                  textBox1.Text = textBox1.Text.Replace("https://", "");
                }
              }
              pb1.Value = 15;
              //Início dos Gráficos =============================================================================

              //Inicialização da função de análise e log a respeito da conexão com à internet

              webBrowser1.Document.Write("<body onselectstart='return false' oncontextmenu='return false' bgcolor='#101010'>");
              webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>QuasarNetview v1.0 - Log de Análise - " + DateTime.Now + "</font>");
              webBrowser1.Document.Write("<br>");
              webBrowser1.Document.Write("<br>");;
              pb1.Value = 20;
              //Verificação do endereço IP Público da máquina a partir da API "ipfy"
              try {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://api.ipify.org/");
                StreamReader reader = new StreamReader(stream);
                String content = reader.ReadToEnd();
                ip_publico.Text = content;

                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Obtida informação do IP público do usuário: " + content + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Conexão realizada para Ipfy.org</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<br>");
              } catch {
                ip_publico.Text = "Não encontrado";
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Erro na obtenção da informação do IP público</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Conexão não realizada para Ipfy.org</font>");

                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<br>");
              }

              //Verificação de latência da conexão
              try {
                pb1.Value = 25;

                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(textBox1.Text);
                long latencia_net = reply.RoundtripTime;

                System.Threading.Thread.Sleep(200);
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net + "ms</font>");
                //.WriteLine("# -Conexão realizada com " + textBox1.Text);
                //.WriteLine("# --Latência obtida: " + latencia_net + "ms");

              } catch {

                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");

              }
              try {
                pb1.Value = 30;
                Ping pingSender1 = new Ping();
                PingReply reply1 = pingSender1.Send(textBox1.Text);
                long latencia_net1 = reply1.RoundtripTime;

                System.Threading.Thread.Sleep(200);

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (2) realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net1 + "ms</font>");

              } catch {

                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (2) não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");
              }

              try {
                Ping pingSender2 = new Ping();
                PingReply reply2 = pingSender2.Send(textBox1.Text);
                long latencia_net2 = reply2.RoundtripTime;
                pb1.Value = 35;
                System.Threading.Thread.Sleep(200);

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (3) realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net2 + "ms</font>");

              } catch {
                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (3) não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");
              }
              try {
                Ping pingSender3 = new Ping();
                PingReply reply3 = pingSender3.Send(textBox1.Text);
                long latencia_net3 = reply3.RoundtripTime;
                pb1.Value = 40;
                System.Threading.Thread.Sleep(200);

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (4) realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net3 + "ms</font>");

              } catch {
                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (4) não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");
              }

              try {
                Ping pingSender4 = new Ping();
                PingReply reply4 = pingSender4.Send(textBox1.Text);
                long latencia_net4 = reply4.RoundtripTime;
                pb1.Value = 45;
                System.Threading.Thread.Sleep(200);

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (5) realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net4 + "ms</font>");

              } catch {

                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (5) não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");

              }

              try {
                Ping pingSender5 = new Ping();
                PingReply reply5 = pingSender5.Send(textBox1.Text);
                long latencia_net5 = reply5.RoundtripTime;
                pb1.Value = 50;
                System.Threading.Thread.Sleep(200);

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (6) realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net5 + "ms</font>");

              } catch {
                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (6) não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");

              }

              try {
                Ping pingSender6 = new Ping();
                PingReply reply6 = pingSender6.Send(textBox1.Text);
                long latencia_net6 = reply6.RoundtripTime;
                pb1.Value = 55;
                System.Threading.Thread.Sleep(200);

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (7) realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net6 + "ms</font>");

              } catch {
                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (7) não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");

              }

              try {
                Ping pingSender7 = new Ping();
                PingReply reply7 = pingSender7.Send(textBox1.Text);
                long latencia_net7 = reply7.RoundtripTime;
                pb1.Value = 60;
                System.Threading.Thread.Sleep(200);

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (8) realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net7 + "ms</font>");

              } catch {
                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (8) não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");

              }

              try {
                Ping pingSender8 = new Ping();
                PingReply reply8 = pingSender8.Send(textBox1.Text);
                long latencia_net8 = reply8.RoundtripTime;
                pb1.Value = 65;
                System.Threading.Thread.Sleep(200);

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (9) realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net8 + "ms</font>");

              } catch {
                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (9) não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");
              }

              try {
                Ping pingSender9 = new Ping();
                PingReply reply9 = pingSender9.Send(textBox1.Text);
                long latencia_net9 = reply9.RoundtripTime;
                pb1.Value = 70;
                System.Threading.Thread.Sleep(200);

                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (10) realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Latência obtida: " + latencia_net9 + "ms</font>");

              } catch {
                //NETERRORLEVEL INFO
                NetErrorLevel = NetErrorLevel + 1;
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' color='#F0F0F0'>- Conexão (10) não realizada com: " + textBox1.Text + "</font>");
                webBrowser1.Document.Write("<br>");
                webBrowser1.Document.Write("<font face='Helvetica' size='2' color='#F0F0F0'>-- Verifique sua conexão ou contate sua provedora</font>");
                webBrowser1.Document.Write("<br>");
              }

              //Gráficos das perdas de pacote

              webBrowser1.Document.Write("</body>");
              //.Close();

              pb1.Value = 85;
              button8.Enabled = true;
              pb1.Value = 100;
            }

            void Button7Click(object sender, EventArgs e) {
              //Minimizar
              this.WindowState = FormWindowState.Minimized;
            }

            void Button6Click(object sender, EventArgs e) {
              //Finalizar
              this.Close();
            }

            void Panel1Paint(object sender, PaintEventArgs e) {

            }

            void Button1Click(object sender, EventArgs e) {
              Opti f2 = new Opti();
              f2.ShowDialog(); // Shows Form2
            }

            void Button2Click(object sender, EventArgs e) {
              Process.Start(@".\logs\");
              }

              void TextBox1TextChanged(object sender, EventArgs e) {}

              void Label1Click(object sender, EventArgs e) {

              }

              void Chart2Click(object sender, EventArgs e) {

              }

              void Label6Click(object sender, EventArgs e) {

              }

              void Label4Click(object sender, EventArgs e) {

              }

              void Button8Click(object sender, EventArgs e) {
                string html_log_full = "";
                string path_html_log = @".\logs\" + DateTime.Now.ToString("ddMyyyyHHmmss ") + @".html";
                html_log_full = webBrowser1.DocumentText;
                File.WriteAllText(path_html_log, html_log_full);
              }

              void Button3Click(object sender, EventArgs e) {
                MessageBox.Show("As funções de rastreamento de rota avançado estão desativadas devido a seu estágio de desenvolvimento.", "Rastreamento de rota avançado");
              }

              void Button9Click(object sender, EventArgs e) {

              }
            }
          }