
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;

namespace QuasarNetView {

  public partial class Opti: Form {
    public Opti() {

      InitializeComponent();

    }

    void Button6Click(object sender, EventArgs e) {
      this.Close();
    }

    void Button5Click(object sender, EventArgs e) {
      if (radioButton3.Checked == true) {
        File.WriteAllText(@".\traces\FWL_Change.cmd", "netsh advfirewall set allprofiles state off");
        Process cmd = new Process();
        cmd.StartInfo.FileName = @".\traces\FWL_Change.cmd";
        cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        cmd.Start();
        System.Threading.Thread.Sleep(1000);
        try {
          File.Delete(@".\traces\FWL_Change.cmd");
        } catch {

        }
      }
      if (radioButton4.Checked == true) {
        File.WriteAllText(@".\traces\FWL_Change.cmd", "netsh advfirewall set allprofiles state on");
        Process cmd = new Process();
        cmd.StartInfo.FileName = @".\traces\FWL_Change.cmd";
        cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        cmd.Start();
        System.Threading.Thread.Sleep(1000);
        try {
          File.Delete(@".\traces\FWL_Change.cmd");
        } catch {

        }
      }

      progressBar1.Value = 40;

      if (checkBox3.Checked == true) {
        if (checkBox5.Checked == true) {
          File.WriteAllText(@".\traces\MTUChanger.cmd", "");

          TextWriter TrRoute = new StreamWriter(@".\traces\MTUChanger.cmd");
          TrRoute.WriteLine("netsh interface ipv4 set subinterface Hamachi mtu=1200 store=persistent");
          TrRoute.WriteLine("netsh interface ipv6 set subinterface Hamachi mtu=1200 store=persistent");

          TrRoute.Close();
          Process cmd = new Process();
          cmd.StartInfo.FileName = @".\traces\MTUChanger.cmd";
          cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
          cmd.Start();
        }
        if (radioButton2.Checked == true) {
          //Iniciando configurações para MTU
          if (File.Exists(@".\traces\MTUChanger.cmd")) {
            File.Delete(@".\traces\MTUChanger.cmd");
          }

          foreach(NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces()) {

            if (netInterface.OperationalStatus == OperationalStatus.Up) {

              string adapt = netInterface.NetworkInterfaceType.ToString();
              if (adapt == "Loopback") {
                continue;
              }
              if (adapt == "Hamachi") {
                continue;
              }
              File.WriteAllText(@".\traces\MTUChanger.cmd", "");

              TextWriter TrRoute = new StreamWriter(@".\traces\MTUChanger.cmd");
              TrRoute.WriteLine("netsh interface ipv4 set subinterface " + adapt + " mtu=1500 store=persistent");
              TrRoute.WriteLine("netsh interface ipv6 set subinterface " + adapt + " mtu=1500 store=persistent");

              TrRoute.Close();
              Process cmd = new Process();
              cmd.StartInfo.FileName = @".\traces\MTUChanger.cmd";
              cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
              cmd.Start();

              continue;

              File.WriteAllText(@".\traces\MTUChanger.cmd", "");

              TextWriter TrRoute2 = new StreamWriter(@".\traces\MTUChanger.cmd");
              TrRoute2.WriteLine("netsh interface ipv4 set subinterface " + adapt + " mtu=1500 store=persistent");
              TrRoute2.WriteLine("netsh interface ipv6 set subinterface " + adapt + " mtu=1500 store=persistent");

              TrRoute2.Close();
              Process cmd1 = new Process();
              cmd1.StartInfo.FileName = @".\traces\MTUChanger.cmd";
              cmd1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
              cmd1.Start();
              continue;

              File.WriteAllText(@".\traces\MTUChanger.cmd", "");

              TextWriter TrRoute3 = new StreamWriter(@".\traces\MTUChanger.cmd");
              TrRoute3.WriteLine("netsh interface ipv4 set subinterface " + adapt + " mtu=1500 store=persistent");
              TrRoute3.WriteLine("netsh interface ipv6 set subinterface " + adapt + " mtu=1500 store=persistent");

              TrRoute3.Close();
              Process cmd2 = new Process();
              cmd2.StartInfo.FileName = @".\traces\MTUChanger.cmd";
              cmd2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
              cmd2.Start();
              continue;

              File.WriteAllText(@".\traces\MTUChanger.cmd", "");

              TextWriter TrRoute4 = new StreamWriter(@".\traces\MTUChanger.cmd");
              TrRoute4.WriteLine("netsh interface ipv4 set subinterface " + adapt + " mtu=1500 store=persistent");
              TrRoute4.WriteLine("netsh interface ipv6 set subinterface " + adapt + " mtu=1500 store=persistent");

              TrRoute4.Close();
              Process cmd3 = new Process();
              cmd3.StartInfo.FileName = @".\traces\MTUChanger.cmd";
              cmd3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
              cmd3.Start();
            }
          }
        }
        if (radioButton1.Checked == true) {
          //Iniciando configurações para MTU
          if (File.Exists(@".\traces\MTUChanger.cmd")) {
            File.Delete(@".\traces\MTUChanger.cmd");
          }
          foreach(NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces()) {

            if (netInterface.OperationalStatus == OperationalStatus.Up) {

              string adapt = netInterface.NetworkInterfaceType.ToString();
              if (adapt == "Loopback") {
                continue;
              }
              if (adapt == "Hamachi") {
                continue;
              }
              File.WriteAllText(@".\traces\MTUChanger.cmd", "");

              TextWriter TrRoute = new StreamWriter(@".\traces\MTUChanger.cmd");
              TrRoute.WriteLine("netsh interface ipv4 set subinterface " + adapt + " mtu=1492 store=persistent");
              TrRoute.WriteLine("netsh interface ipv6 set subinterface " + adapt + " mtu=1492 store=persistent");

              TrRoute.Close();
              Process cmd = new Process();
              cmd.StartInfo.FileName = @".\traces\MTUChanger.cmd";
              cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
              cmd.Start();
              continue;

              File.WriteAllText(@".\traces\MTUChanger.cmd", "");

              TextWriter TrRoute2 = new StreamWriter(@".\traces\MTUChanger.cmd");
              TrRoute2.WriteLine("netsh interface ipv4 set subinterface " + adapt + " mtu=1492 store=persistent");
              TrRoute2.WriteLine("netsh interface ipv6 set subinterface " + adapt + " mtu=1492 store=persistent");

              TrRoute2.Close();
              Process cmd1 = new Process();
              cmd1.StartInfo.FileName = @".\traces\MTUChanger.cmd";
              cmd1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
              cmd1.Start();
              continue;

              File.WriteAllText(@".\traces\MTUChanger.cmd", "");

              TextWriter TrRoute3 = new StreamWriter(@".\traces\MTUChanger.cmd");
              TrRoute3.WriteLine("netsh interface ipv4 set subinterface " + adapt + " mtu=1492 store=persistent");
              TrRoute3.WriteLine("netsh interface ipv6 set subinterface " + adapt + " mtu=1492 store=persistent");

              TrRoute3.Close();
              Process cmd2 = new Process();
              cmd2.StartInfo.FileName = @".\traces\MTUChanger.cmd";
              cmd2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
              cmd2.Start();
              continue;

              File.WriteAllText(@".\traces\MTUChanger.cmd", "");

              TextWriter TrRoute4 = new StreamWriter(@".\traces\MTUChanger.cmd");
              TrRoute4.WriteLine("netsh interface ipv4 set subinterface " + adapt + " mtu=1492 store=persistent");
              TrRoute4.WriteLine("netsh interface ipv6 set subinterface " + adapt + " mtu=1492 store=persistent");
              TrRoute4.WriteLine("pause");
              TrRoute4.Close();
              Process cmd3 = new Process();
              cmd3.StartInfo.FileName = @".\traces\MTUChanger.cmd";
              cmd3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
              cmd3.Start();
            }
          }

        }

      }
      progressBar1.Value = 80;

      //Limpeza de Cache DNS e Winsock
      if (checkBox2.Checked == true) {
        File.WriteAllText(@".\traces\FlushDNS.cmd", "");

        TextWriter TrRoute4 = new StreamWriter(@".\traces\FlushDNS.cmd");
        TrRoute4.WriteLine("ifconfig /flushdns");
        TrRoute4.Close();
        Process cmd3 = new Process();
        cmd3.StartInfo.FileName = @".\traces\FlushDNS.cmd";
        cmd3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        cmd3.Start();
      }
      if (checkBox1.Checked == true) {
        File.WriteAllText(@".\traces\FlushDNS.cmd", "");

        TextWriter TrRoute4 = new StreamWriter(@".\traces\FlushDNS.cmd");
        TrRoute4.WriteLine("ifconfig /flushdns");
        TrRoute4.Close();
        Process cmd3 = new Process();
        cmd3.StartInfo.FileName = @".\traces\FlushDNS.cmd";
        cmd3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        cmd3.Start();
      }
      progressBar1.Value = 100;
    }

    void CheckBox3CheckedChanged(object sender, EventArgs e) {
      if (radioButton1.Enabled == false) {
        radioButton1.Enabled = true;
        radioButton2.Enabled = true;
        checkBox5.Enabled = true;
      } else {
        radioButton1.Enabled = false;
        radioButton2.Enabled = false;
        checkBox5.Enabled = false;
      }
    }

    void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      MessageBox.Show("Caso o Firewall do Windows já esteja desativado, a função de desabilitar não irá fazer nada. Caso ele esteja ativado, a função de ativá-lo também não irá fazer nada.", "QuasarNetView");
    }

    void ComboBox1SelectedIndexChanged(object sender, EventArgs e) {

    }
  }
}