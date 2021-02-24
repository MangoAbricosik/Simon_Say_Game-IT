using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_Say_Game_IT
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      HideAll();
      DefAll();
      label1.Text = "";
    }
    public void HideAll()
    {
      button1.Hide();
      button2.Hide();
      button3.Hide();
      button4.Hide();
    }
    public void ShowAll()
    {
      button1.Show();
      button2.Show();
      button3.Show();
      button4.Show();
    }
    public void DefAll()
    {
      button1.BackColor = Color.Gray;
      button2.BackColor = Color.Gray;
      button3.BackColor = Color.Gray;
      button4.BackColor = Color.Gray;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      button5.Hide();
      ShowAll();
      label1.Text = lvl.ToString();
      GameStartBot();
    }

    string randomzapis = "";
    string igrokzapis = "";
    int cout = 0; int lvl = 0;

    public void PlayerPlay()
    {
      while (cout < lvl + 2)
      {
        cout++;
        return;
      }
      Sverka();
      return;
    }
    public void Sverka()
    {
      if (randomzapis == igrokzapis)
      {
        lvl++;

        label1.Text = lvl.ToString();
        button5.Text = "Далее!";

        DefAll();
        button5.Show();
      }
      else
      {
        label1.Text = "Ты проиграл! Твой счет - " + lvl.ToString();

        lvl = 0;

        DefAll();
        HideAll();

        button5.Show();
      }
    }
    public void GameStartBot()
    {
      Random rand = new Random();
      while (cout < lvl + 2) 
      {
      switch (rand.Next(1,4))
      {
        case 1:
          button1.BackColor = SetColorRand();
          randomzapis += "1";
          break;
        case 2:
          button2.BackColor = SetColorRand();
          randomzapis += "2";
          break;
        case 3:
          button3.BackColor = SetColorRand();
          randomzapis += "3";
          break;
        case 4:
          button4.BackColor = SetColorRand();
          randomzapis += "4";
          break;
      }
        Kastil();
        cout++;
      }
      cout = 0;
    }
    public Color SetColorRand()
    {
      Random rand = new Random();

      switch (rand.Next(1, 8))
      {
        case 1:
          return Color.Green;         
        case 2:
          return Color.Red;
        case 3:
          return Color.Blue;
        case 4:
          return Color.Black;
        case 5:
          return Color.Aquamarine;
        case 6:
          return Color.Yellow;
        case 7:
          return Color.Purple;
        case 8:
          return Color.Brown;
      }
      return Color.DarkBlue;
    }
    public void Kastil()
    {
      for (int i = int.MaxValue/2; i < int.MaxValue; i++) ;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      PlayerPlay();
      igrokzapis += "1";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      PlayerPlay();
      igrokzapis += "2";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      PlayerPlay();
      igrokzapis += "3";
    }

    private void button4_Click(object sender, EventArgs e)
    {
      PlayerPlay();
      igrokzapis += "4";
    }
  }
}
