using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace StepperMotorSCurve
{
    public partial class Form1 : Form
    {

        private Double[] accelerationArray = new Double[10000];  //加速度数组
        private Double[] speedArray = new Double[10000];  //速度数组
        private Double[] pwmCycleArray = new Double[10000];  //Pwm周期数组
        private Double[] timeArray = new Double[10000];  //时间数组
        private Double[] pwmTheoryArray = new Double[10000]; //理论的Pwm值（机器周期整数倍）
        private Int32[] pwmActualArray = new Int32[10000]; //实际的Pwm值（机器周期整数倍）
        private Double[] pwmIncrementArray = new Double[10000]; //Pwm增量（机器周期整数倍）

        private int actualArrayLim = 0;
        private Double maxAcceleration = 0;
        private Double maxSpeed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region 计算参数
        private void textBoxCrystalFrequency_TextChanged(object sender, EventArgs e)
        {
            caculateParameter();
        }

        private void textBoxMachineCycleDivision_TextChanged(object sender, EventArgs e)
        {
            caculateParameter();
        }

        private void textBoxPWMRolloverInit_TextChanged(object sender, EventArgs e)
        {
            caculateParameter();
        }

        private void textBoxPWMRolloverMax_TextChanged(object sender, EventArgs e)
        {
            caculateParameter();
        }

        private void textBoxSpeedRiseTime_TextChanged(object sender, EventArgs e)
        {
            caculateParameter();
        }

        private void radioButtonTriangle_CheckedChanged(object sender, EventArgs e)
        {
            caculateParameter();
        }

        private void radioButtonSinewave_CheckedChanged(object sender, EventArgs e)
        {
            //caculateParameter();
        }

        private void textBoxStageNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double stageNum = Double.Parse(this.textBoxStageNum.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void caculateParameter()
        {
            try
            {
                Double crystalFre = Double.Parse(this.textBoxCrystalFrequency.Text);
                Double machineCycleDivis = Double.Parse(this.textBoxMachineCycleDivision.Text);
                Double pwmRolloverInit = Double.Parse(this.textBoxPWMRolloverInit.Text);
                Double pwmRolloverMax = Double.Parse(this.textBoxPWMRolloverMax.Text);
                Double speedRiseTime = Double.Parse(this.textBoxSpeedRiseTime.Text);
                if (Math.Abs(crystalFre) < 0.0001)
                {
                    MessageBox.Show("“晶振频率”不能小于0.0001");
                    this.textBoxCrystalFrequency.Focus();
                    return;
                }
                if (Math.Abs(machineCycleDivis) < 0.0001)
                {
                    MessageBox.Show("“机器周期分频”不能小于0.0001");
                    this.textBoxMachineCycleDivision.Focus();
                    return;
                }
                if (Math.Abs(pwmRolloverInit) < 0.0001 || Math.Abs(pwmRolloverInit - pwmRolloverMax) < 0.0001)
                {
                    MessageBox.Show("“PWM翻转周期初始值”不能小于0.0001，并且和“最高速时PWM翻转周期”差值不能小于0.0001");
                    this.textBoxPWMRolloverInit.Focus();
                    return;
                }
                if (Math.Abs(pwmRolloverMax) < 0.0001 || Math.Abs(pwmRolloverInit - pwmRolloverMax) < 0.0001)
                {
                    MessageBox.Show("“最高速时PWM翻转周期”不能小于0.0001，并且和“PWM翻转周期初始值”差值不能小于0.0001");
                    this.textBoxPWMRolloverMax.Focus();
                    return;
                }
                if (Math.Abs(speedRiseTime) < 0.0001)
                {
                    MessageBox.Show("S曲线半周期/速度上升期不能小于0.0001");
                    this.textBoxSpeedRiseTime.Focus();
                    return;
                }
                Double crystalCycle = 1 / crystalFre;
                Double MachineCycle = machineCycleDivis * crystalCycle;
                this.textBoxCrystalCycle.Text = crystalCycle.ToString();
                this.textBoxMachineCycle.Text = MachineCycle.ToString();
                if (this.radioButtonTriangle.Checked)
                {
                    Double accelerationSlope = 4 * (1 / (pwmRolloverMax * machineCycleDivis) - 1 / (pwmRolloverInit * machineCycleDivis)) / ((speedRiseTime / 1000) * (speedRiseTime / 1000));
                    this.textBoxAccelerationSlope.Text = accelerationSlope.ToString();
                }
                else if (this.radioButtonSinewave.Checked)
                {
                    Double angularVelocity = 2 * Math.PI / (2 * speedRiseTime / 1000);
                    Double accelerationSlope = (1 / pwmRolloverMax - 1 / pwmRolloverInit) * angularVelocity / 2;

                    this.textBoxAngularVelocity.Text = angularVelocity.ToString();
                    this.textBoxAccelerationSlope.Text = accelerationSlope.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 计算绘图
        private void buttonCalcuDraw_Click(object sender, EventArgs e)
        {
            this.textBoxDataOutputPWMCycleChange.Text = "";
            this.dataGridViewOutput.Rows.Clear(); //清除输出数据
            Double crystalFre = Double.Parse(this.textBoxCrystalFrequency.Text);
            Double crystalCycle = 1 / crystalFre;
            Double machineCycleDivis = Double.Parse(this.textBoxMachineCycleDivision.Text);
            Double MachineCycle = crystalCycle * machineCycleDivis;
            Double pwmRolloverInit = Double.Parse(this.textBoxPWMRolloverInit.Text);
            Double pwmRolloverMax = Double.Parse(this.textBoxPWMRolloverMax.Text);
            Double speedRiseTime = Double.Parse(this.textBoxSpeedRiseTime.Text);
            Double accelerationSlope = Double.Parse(this.textBoxAccelerationSlope.Text);
            Double angularVelocity = Double.Parse(this.textBoxAngularVelocity.Text);
            pwmTheoryArray[0] = pwmRolloverInit;    //6000
            pwmCycleArray[0] = pwmTheoryArray[0] * MachineCycle;    //6000/8000000
            timeArray[0] = pwmCycleArray[0];
            pwmActualArray[0] = Convert.ToInt32(pwmTheoryArray[0].ToString());
            accelerationArray[0] = 6E-6;
            speedArray[0] = 1 / pwmTheoryArray[0];
            pwmIncrementArray[0] = 0;
            addOutputRow(0); //输出0行数据
            if (this.radioButtonTriangle.Checked) //三角波加速度
            {
                int i;
                for (i = 1; i <= 10000; i++)
                {
                    accelerationArray[i] = accelerationArray[i - 1] + accelerationSlope * pwmCycleArray[i - 1];
                    speedArray[i] = speedArray[i - 1] + accelerationArray[i - 1] * pwmCycleArray[i - 1];
                    pwmTheoryArray[i] = 1 / speedArray[i];
                    pwmActualArray[i] = Convert.ToInt32(pwmTheoryArray[i]);
                    pwmIncrementArray[i] = pwmActualArray[i - 1] - pwmActualArray[i];
                    pwmCycleArray[i] = pwmTheoryArray[i] * machineCycleDivis / crystalFre;
                    timeArray[i] = timeArray[i - 1] + pwmCycleArray[i];
                    addOutputRow(i); //输出i行数据
                    if ((timeArray[i] * 1000) > (speedRiseTime / 2))
                    {
                        break;
                    }
                    if (accelerationArray[i] > maxAcceleration)
                    {
                        maxAcceleration = accelerationArray[i];
                    }
                }
                do
                {
                    i++;
                    accelerationArray[i] = accelerationArray[i - 1] - accelerationSlope * pwmCycleArray[i - 1];
                    speedArray[i] = speedArray[i - 1] + accelerationArray[i - 1] * pwmCycleArray[i - 1];
                    pwmTheoryArray[i] = 1 / speedArray[i];
                    pwmActualArray[i] = Convert.ToInt32(pwmTheoryArray[i]);
                    pwmIncrementArray[i] = pwmActualArray[i - 1] - pwmActualArray[i];
                    pwmCycleArray[i] = pwmTheoryArray[i] * machineCycleDivis / crystalFre;
                    timeArray[i] = timeArray[i - 1] + pwmCycleArray[i];
                    addOutputRow(i); //输出i行数据
                    if (speedArray[i] > maxSpeed)
                    {
                        maxSpeed = speedArray[i];
                    }
                } while (accelerationArray[i] >= 0);
                actualArrayLim = i - 1; //数据总行数
            }
            else if (this.radioButtonSinewave.Checked) //正弦波加速度
            {
                int i;
                for (i = 1; i <= 10000; i++)
                {
                    speedArray[i] = speedArray[i-1]+accelerationArray[i-1]*pwmCycleArray[i-1];  //v=v0+at
                    pwmTheoryArray[i] = 1/speedArray[i];   //pwm周期（除以计数周期的值），速度的倒数
                    pwmActualArray[i] = Convert.ToInt32(pwmTheoryArray[i]);  //pwm周期取整
                    pwmIncrementArray[i] = pwmActualArray[i-1]-pwmActualArray[i];  //pwm周期差异
                    pwmCycleArray[i] = pwmTheoryArray[i]*machineCycleDivis/crystalFre;  //pwm周期（实际时间）
                    timeArray[i] = timeArray[i-1]+pwmCycleArray[i]; //时间轴t
                    accelerationArray[i] = accelerationSlope*Math.Sin(angularVelocity*timeArray[i]);  //加速度计算
                    addOutputRow(i); //输出i行数据
                    if ((timeArray[i] * 1000) > (speedRiseTime / 2))
                    {
                        break;
                    }
                    if (accelerationArray[i] > maxAcceleration)
                    {
                        maxAcceleration = accelerationArray[i];
                    }
                }
                do
                {
                    i++;
                    speedArray[i] = speedArray[i - 1] + accelerationArray[i - 1] * pwmCycleArray[i - 1];  //v=v0+at
                    pwmTheoryArray[i] = 1 / speedArray[i];   //pwm周期（除以计数周期的值），速度的倒数
                    pwmActualArray[i] = Convert.ToInt32(pwmTheoryArray[i]);  //pwm周期取整
                    pwmIncrementArray[i] = pwmActualArray[i - 1] - pwmActualArray[i];  //pwm周期差异
                    pwmCycleArray[i] = pwmTheoryArray[i] * machineCycleDivis / crystalFre;  //pwm周期（实际时间）
                    timeArray[i] = timeArray[i - 1] + pwmCycleArray[i]; //时间轴t
                    accelerationArray[i] = accelerationSlope * Math.Sin(angularVelocity * timeArray[i]);  //加速度计算
                    addOutputRow(i); //输出i行数据
                    if (speedArray[i] > maxSpeed)
                    {
                        maxSpeed = speedArray[i];
                    }
                } while (accelerationArray[i] >= 0);
                actualArrayLim = i - 1; //数据总行数
            }
            drawCurve();
        }

        private void addOutputRow(int i)
        {
            this.textBoxDataOutputPWMCycleChange.AppendText(String.Format("{0}, ", Convert.ToInt32(pwmIncrementArray[i])));
            this.dataGridViewOutput.Rows.Add(
                String.Format("{0:n9}", timeArray[i]),
                String.Format("{0:n9}", accelerationArray[i]),
                String.Format("{0:n9}", speedArray[i]),
                String.Format("{0}", Convert.ToInt32(pwmActualArray[i])),
                String.Format("{0}", Convert.ToInt32(pwmIncrementArray[i]))
                //String.Format("{0:E3}", pwmActualArray[i]),
                //String.Format("{0:E2}", pwmIncrementArray[i])
            );
        }

        private void dataGridViewOutput_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(this.dataGridViewOutput.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void drawCurve()
        {
            int width = this.pictureBoxSCurve.Width;
            int height = this.pictureBoxSCurve.Height;

            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                Font textFont = new Font(new FontFamily("Arial"),12,FontStyle.Regular,GraphicsUnit.Pixel);
                Pen penBoard = new Pen(Color.Black);
                Brush brushBoard = new SolidBrush(Color.Black);
                //Pen penSpeed = new Pen(Color.Red);
                Brush brushSpeed = new SolidBrush(Color.Red);
                //Pen penAccele = new Pen(Color.Blue);
                Brush brushAccele = new SolidBrush(Color.Blue);
                g.DrawRectangle(penBoard, 0, 0, width-1, height-1); //画边框
                g.FillRectangle(brushSpeed, 5, 10 , 30, 5);
                g.DrawString(String.Format("速度-最大值:{0}pps(未细分前)", 0), textFont, brushBoard, 40, 7);
                g.FillRectangle(brushAccele, 5, 30, 30, 5);
                g.DrawString(String.Format("加速度-最大值:{0}弧度/S2", 0), textFont, brushBoard, 40, 27);
                for (int i = 0; i < actualArrayLim; i++)
                {
                    int x = Convert.ToInt32(timeArray[i] * width / timeArray[actualArrayLim]);
                    int yAcceleration = Convert.ToInt32(accelerationArray[i] * height / maxAcceleration);
                    int ySpeed = Convert.ToInt32(speedArray[i] * height / maxSpeed);
                    g.FillRectangle(brushSpeed, x, height - ySpeed, 1, 1);
                    g.FillRectangle(brushAccele, x, height - yAcceleration, 1, 1);
                }
            }
            this.pictureBoxSCurve.Image = bitmap;

            
        }

        private void buttonExcelDataOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IDataObject objectSave = Clipboard.GetDataObject();
                    // Choose whether to write header. Use EnableWithoutHeaderText instead to omit header.
                    this.dataGridViewOutput.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    // Select all the cells
                    this.dataGridViewOutput.SelectAll();
                    // Copy (set clipboard)
                    Clipboard.SetDataObject(this.dataGridViewOutput.GetClipboardContent());
                    // Paste (get the clipboard and serialize it to a file)
                    File.WriteAllText(sfd.FileName, Clipboard.GetText(TextDataFormat.CommaSeparatedValue));
                    MessageBox.Show("导出数据成功。");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("导出数据失败。" + ex.Message);
                }
            }
        }
        #endregion

        #region 数据分析

        private string dataAnalyseFilePath;

        private void buttonDataAnalyseLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataAnalyseFilePath = ofd.FileName;
                loadDataAnalyseData();
            }
        }

        private void buttonDataAnalyseRefresh_Click(object sender, EventArgs e)
        {
            loadDataAnalyseData();
        }

        private void loadDataAnalyseData()
        {
            try
            {
                StringBuilder sb = new StringBuilder("序号,     时间,                   数据\r\n");
                string[] lines = File.ReadAllLines(dataAnalyseFilePath);
                for(int i=1; i< lines.Length; i++)
                {
                    string[] columns = lines[i].Split(',');
                    try
                    {
                        sb.Append(i.ToString("000000"));
                        sb.Append(", ");
                        sb.Append(Double.Parse(columns[0]).ToString("N11"));
                        sb.Append(", ");
                        sb.Append(Int32.Parse(columns[1]).ToString());
                        sb.Append("\r\n");
                    }
                    catch {
                        sb.Append("\r\n");
                    }
                }
                this.textBoxDataAnalyse.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载文件失败。" + ex.Message);
            }
        }

        private void buttonDataAnalyseProcess_Click(object sender, EventArgs e)
        {
            int width = this.pictureBoxDataAnalyse.Width;
            int height = this.pictureBoxDataAnalyse.Height;

            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                Font textFont = new Font(new FontFamily("Arial"), 12, FontStyle.Regular, GraphicsUnit.Pixel);
                Pen penBoard = new Pen(Color.Black);
                Brush brushBoard = new SolidBrush(Color.Black);
                //Pen penSpeed = new Pen(Color.Red);
                Brush brushSpeed = new SolidBrush(Color.Red);
                //Pen penAccele = new Pen(Color.Blue);
                Brush brushAccele = new SolidBrush(Color.Blue);
                g.DrawRectangle(penBoard, 0, 0, width - 1, height - 1); //画边框
                //画图例
                g.FillRectangle(brushSpeed, 5, 10, 30, 5);
                g.DrawString(String.Format("速度-最大值:{0}pps(未细分前)", 0), textFont, brushBoard, 40, 7);
                //得到最大速度
                Double maxSpeed = 0;
                Double maxTime = 0;
                Double minTime = Double.MaxValue;
                string[] lines = this.textBoxDataAnalyse.Lines;
                for (int rows = 1; rows < lines.Length; rows++)
                {
                    try
                    {
                        Double timeNow = Double.Parse((lines[rows].Split(','))[1]);
                        Double timeLast = Double.Parse((lines[rows - 1].Split(','))[1]);
                        Double speed = 1 / (timeNow - timeLast);
                        if (speed > maxSpeed)
                        {
                            maxSpeed = speed;
                        }
                        if (timeNow > maxTime)
                        {
                            maxTime = timeNow;
                        }
                        if (timeNow < minTime)
                        {
                            minTime = timeNow;
                        }
                    }
                    catch
                    { 
                    }
                }
                //绘制图形
                for (int rows = 1; rows < lines.Length; rows++)
                {
                    try
                    {
                        Double timeNow = Double.Parse((lines[rows].Split(','))[1]);
                        Double timeLast = Double.Parse((lines[rows - 1].Split(','))[1]);
                        Double speed = 1 / (timeNow - timeLast);
                        int x = Convert.ToInt32((timeNow-minTime) * width / (maxTime-minTime));
                        int ySpeed = Convert.ToInt32(speed * height / maxSpeed);
                        g.FillRectangle(brushSpeed, x, height - ySpeed, 1, 1);
                    }
                    catch
                    {
                    }
                }
            }
            this.pictureBoxDataAnalyse.Image = bitmap;
        }

        #endregion
    }
}
