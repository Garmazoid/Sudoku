using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Sudoku table = new(3);
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < table.n; i++)
            {
                for (int j = 0; j < table.n; j++)
                {
                    Controls.Add(table.nums[i][j]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // pass
        }
    }

    public class Sudoku
    {
        public List<List<Label>> nums = new List<List<Label>>();
        public List<List<int>> nums1 = new List<List<int>>();
        public int n; // сторона 1й части поля
        public int X = 50; // координата X поля
        public int Y = 50; // координата Y поля

        public Sudoku(int n = 3)
        {
            int indx = 1;
            for (int i = 0; i < n * n; i++)
            {
                nums.Add(new List<Label>());
                nums1.Add(new List<int>());
                for (int j = 0; j < n * n; j++)
                {
                    nums[i].Add(new Label());
                    nums1[i].Add(new int());

                    nums1[i][j] = (i * n + i / n + j) % (n * n) + 1;

                    nums[i][j].Location = new Point(X + i * 10, Y + j * 10);
                    nums[i][j].AutoSize = true;
                    nums[i][j].TabIndex = indx++;
                    nums[i][j].Text = Convert.ToString((i * n + i / n + j) % (n * n) + 1); 
                    nums[i][j].Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    nums[i][j].ForeColor = System.Drawing.Color.Black;
                    nums[i][j].Size = new System.Drawing.Size(84, 54);
                }
            }
            //Print();
        }

        public void Print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                }
            }
        }
    }
}