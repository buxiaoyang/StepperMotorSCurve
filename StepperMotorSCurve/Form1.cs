using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private Point[] AccelPointMatrix = new Point[10000]; //加速度坐标点数组
        private Point[] SpeedPointMatrix = new Point[10000]; //速度坐标点数组
        public Form1()
        {
            InitializeComponent();
        }

        #region CaculateParameter Functions
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


        private void buttonCalcuDraw_Click(object sender, EventArgs e)
        {
            this.dataGridViewOutput.Rows.Clear(); //清除输出数据
            Double maxAcceleration = 0;
            Double maxSpeed = 0;
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
            addDataGirdViewRow(0); //输出0行数据
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
                    addDataGirdViewRow(i); //输出i行数据
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
                    addDataGirdViewRow(i); //输出i行数据
                    if (speedArray[i] > maxSpeed)
                    {
                        maxSpeed = speedArray[i];
                    }
                } while (accelerationArray[i] >= 0);
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
                    addDataGirdViewRow(i); //输出i行数据
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
                    addDataGirdViewRow(i); //输出i行数据
                    if (speedArray[i] > maxSpeed)
                    {
                        maxSpeed = speedArray[i];
                    }
                } while (accelerationArray[i] >= 0);
            }
        }

        private void addDataGirdViewRow(int i)
        {
            this.dataGridViewOutput.Rows.Add(
                String.Format("{0:n9}", timeArray[i]),
                String.Format("{0:n9}", accelerationArray[i]),
                String.Format("{0:n9}", speedArray[i]),
                String.Format("{0:E3}", pwmActualArray[i]),
                String.Format("{0:E2}", pwmIncrementArray[i])
            );
        }

        private void dataGridViewOutput_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(this.dataGridViewOutput.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
