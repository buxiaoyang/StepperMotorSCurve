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
        public Form1()
        {
            InitializeComponent();
        }

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
            caculateParameter();
        }

        private void textBoxStageNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double stageNum = Double.Parse(this.textBoxStageNum.Text);
            }
            catch(Exception ex) 
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
    }
}
