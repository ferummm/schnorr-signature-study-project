using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;

namespace Shnorr
{
    public partial class Form1 : Form
    {
        List<BigInteger> primeNum;
        private const int max = 100000000;

        public Form1()
        {
            InitializeComponent();
            primeNum = SieveOfEratosthenes(max);

            var ResBox = new List<TextBox> { FileBox, vBox, xBox, eBox, yBox, x_Box, e_Box };
            foreach (TextBox tb in ResBox)
            {
                tb.ReadOnly = true;
            }
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.KeyPress += TextBox_KeyPress;
                }
            }
            foreach (Control control in tabControl1.Controls)
            {
                if (control is TextBox)
                {
                    control.KeyPress += TextBox_KeyPress;
                }
            }
        }
        private void ClearForm_Click(object sender, EventArgs e)
        {
            ClearForm_();
        }

        private void ClearSignTab_Click(object sender, EventArgs e)
        {
            ClearSignTab_();
        }

        private void ClearVerifyTab_Click(object sender, EventArgs e)
        {
            ClearVerifyTab_();
        }
        private void ResetMenuItem_Click(object sender, EventArgs e)
        {
            FileBox.Text = "";
            ClearForm_();
            ClearSignTab_();
            ClearVerifyTab_();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectFileEDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Размер выбранного файла не должен превышать 2Гб.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                if (new FileInfo(ofd.FileName).Length / 1024 / 1024 / 1024 > 2) throw new ArgumentException("Размер выбранного файла превышает 2Гб.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FileBox.Text = ofd.FileName;

        }

        private void ComputeSignTab_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(FileBox.Text)) throw new ArgumentException("Файл, который вы хотите подписать, не существует.");
                byte[] file_bytes = File.ReadAllBytes(FileBox.Text);

                var inputBoxList = new List<TextBox> { pBox, qBox, aBox, sBox, rBox };
                var param = GetParams(inputBoxList);

                CheckPQ(param, new List<TextBox> { pBox, qBox });


                if (BigInteger.ModPow(param[2], param[1], param[0]) != 1)
                {
                    aBox.Text = "";
                    throw new ArgumentException("Параметр a не удовлетворяет условию a^q mod p = 1.");
                }
                if (param[4] < 1 || param[4] > param[1] - 1)
                {
                    sBox.Text = "";
                    throw new ArgumentException("Параметр s не удовлетворяет условию 1 <= s <= q - 1.");
                }
                if (param[3] < 1 || param[3] > param[1] - 1)
                {
                    rBox.Text = "";
                    throw new ArgumentException("Параметр r не удовлетворяет условию 1 <= r <= q - 1.");
                }

                var sign = Sign(file_bytes, param);
                xBox.Text = sign[0].ToString();
                eBox.Text = sign[1].ToString();
                yBox.Text = sign[2].ToString();
                vBox.Text = sign[3].ToString();
                string log = "Протокол подписи документа: " + FileBox.Text + "\n" +
                             "Число p: " + param[0] + "\n" +
                             "Число q: " + param[1] + "\n" +
                             "Число a: " + param[2] + "\n" +
                             "Число v: " + sign[3] + "\n" +
                             "Подпись (e, y): \n" +
                             "e: " + sign[1] + "\n" +
                             "y: " + sign[2];
                byte[] log_bytes = Encoding.Unicode.GetBytes(log);
                SaveToSelectedFile(log_bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Обработчик события KeyPress для textBox
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GenSignTab_Click(object sender, EventArgs e)
        {
            try
            {
                long q;
                if (!long.TryParse(qBox.Text, out q) || !IsPrime(q)) throw new ArgumentException("Не удалось преобразовать в простое число параметр q.");
                if (IsBoxEmpty(sBox))
                {
                    sBox.Text = new Random().NextInt64(1, q).ToString();
                }
                if (IsBoxEmpty(rBox))
                {
                    rBox.Text = new Random().NextInt64(1, q).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public BigInteger FindGCD(BigInteger a, BigInteger b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return a;
        }
        private void ComputeVerifyTab_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(FileBox.Text)) throw new ArgumentException("Файла, для которого вы хотите проверить подпись, не существует.");
                byte[] file_bytes = File.ReadAllBytes(FileBox.Text);

                var inputBoxList = new List<TextBox> { pBox, aBox, v_Box, eSignBox, ySignBox, qBox };
                var param = GetParams(inputBoxList);

                CheckPQ(new BigInteger[] { param[0], param[5] }, new List<TextBox> { pBox, qBox });


                if (BigInteger.ModPow(param[1], param[5], param[0]) != 1)
                {
                    aBox.Text = "";
                    throw new ArgumentException("Параметр a не удовлетворяет условию a^q mod p = 1.");
                }
                if (param[2] < 0)
                {
                    v_Box.Text = "";
                    throw new ArgumentException("Параметр v должен быть неотрицательным");
                }
                if (param[3] < 0)
                {
                    eSignBox.Text = "";
                    throw new ArgumentException("Параметр e должен быть неотрицательным");
                }
                if (param[4] < 0)
                {
                    ySignBox.Text = "";
                    throw new ArgumentException("Параметр y должен быть неотрицательным");
                }

                var sign = Verify(file_bytes, param);
                x_Box.Text = sign[0].ToString();
                e_Box.Text = sign[1].ToString();

                string res = sign[1] == param[3] ? "подтвержденa" : "не подтверждена";

                string log = "Протокол проверки подписи документа: " + FileBox.Text + "\n" +
                             "Число p: " + param[0] + "\n" +
                             "Число q: " + param[5] + "\n" +
                             "Число a: " + param[1] + "\n" +
                             "Число v: " + param[2] + "\n" +
                             "Проверяемая подпись (e, y): \n" +
                             "e: " + param[3] + "\n" +
                             "y: " + param[4] + "\n" +
                             "Вычисления: \n" +
                             "x': " + sign[0] + "\n" +
                             "e': " + sign[1] + "\n" +
                             "Результат: Подпись " + res + "\n";

                byte[] log_bytes = Encoding.Unicode.GetBytes(log);
                MessageBox.Show("Подпись " + res + ".", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveToSelectedFile(log_bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Copy_Click(object sender, EventArgs e)
        {
            v_Box.Text = vBox.Text;
            eSignBox.Text = eBox.Text;
            ySignBox.Text = yBox.Text;
        }

        private void About_Click(object sender, EventArgs e)
        {
            var about = new AboutBox1();
            about.Show();
        }
        private BigInteger[] GetParams(List<TextBox> textBoxes)
        {
            var bigs = new BigInteger[textBoxes.Count];
            bool[] isCorrect = IsNumbers(textBoxes, out bigs);
            if (!isCorrect[0])
            {
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    textBoxes[i].Text = (isCorrect[i + 1]) ? textBoxes[i].Text : "";
                }
                throw new ArgumentException("Не удалось преобразовать параметры в целые числа.");
            }
            return bigs;
        }
        private bool[] IsNumbers(List<TextBox> textBoxes, out BigInteger[] bigInts)
        {
            bigInts = new BigInteger[textBoxes.Count];
            bool[] res = new bool[textBoxes.Count + 1];
            for (int i = 0; i < textBoxes.Count; i++)
            {
                res[i + 1] = BigInteger.TryParse(textBoxes[i].Text, out bigInts[i]);
            }
            res[0] = true;
            foreach (bool f in res)
            {
                res[0] &= f;
            }
            return res;
        }

        static List<BigInteger> SieveOfEratosthenes(int maxNumber)
        {

            bool[] isPrime = new bool[maxNumber + 1];
            for (uint i = 2; i <= maxNumber; i++)
            {
                isPrime[i] = true;
            }

            for (uint p = 2; p * p <= maxNumber; p++)
            {
                if (isPrime[p])
                {
                    for (uint i = p * p; i <= maxNumber; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            var primeNums = new List<BigInteger>();
            int num = 0;
            for (int i = 2; i <= maxNumber; i++)
            {
                if (isPrime[i])
                {
                    num += 1;
                    primeNums.Add(i);
                }
            }
            return primeNums;

        }

        private void GenFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsBoxEmpty(pBox))
                {
                    GenP();
                    GenQ();
                    GenA(new BigInteger[] { BigInteger.Parse(pBox.Text), BigInteger.Parse(qBox.Text) });
                }
                else if (IsBoxEmpty(qBox) || IsBoxEmpty(aBox))
                {
                    if (IsBoxEmpty(qBox)) GenQ();
                    var textBoxes = new List<TextBox> { pBox, qBox };
                    var param = GetParams(textBoxes);
                    CheckPQ(param, textBoxes);
                    GenA(param);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckPQ(BigInteger[] param, List<TextBox> textBoxes)
        {
            var isCorrect = new bool[2];
            isCorrect[0] = IsPrime(param[0]);
            isCorrect[1] = IsPrime(param[1]);
            textBoxes[0].Text = (isCorrect[0]) ? textBoxes[0].Text : "";
            textBoxes[1].Text = (isCorrect[1]) ? textBoxes[1].Text : "";
            if (!isCorrect[1] || !isCorrect[0]) throw new ArgumentException("Параметры p и q должны быть простым.");
            if (param[0] == 2)
            {
                textBoxes[0].Text = "";
                throw new ArgumentException("Параметр p должен быть больше 2.");
            }
            if ((param[0] - 1) % param[1] != 0)
            {
                textBoxes[1].Text = "";
                throw new ArgumentException("Параметр q не является делителем p - 1.");
            }
        }

        private bool IsPrime(BigInteger num)
        {
            if (num < 2) return false;
            if (primeNum.Contains(num)) return true;
            for (var i = primeNum[primeNum.Count - 1]; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        private void GenP()
        {
            pBox.Text = this.primeNum[new Random().Next(0, this.primeNum.Count)].ToString();
        }
        private void GenQ()
        {
            BigInteger p;
            if (!BigInteger.TryParse(pBox.Text, out p))
            {
                pBox.Text = "";
                throw new ArgumentException("Не удалось преобразовать параметр p в целое неотрицательное число.");
            }
            if (!IsPrime(p) || !(p > 2))
            {
                pBox.Text = "";
                throw new ArgumentException("Параметр p должен быть простым и не равным 2.");
            }
            var primeDivisors = PrimeDivisors(p - 1);
            int rand = new Random().Next(0, primeDivisors.Count);
            qBox.Text = primeDivisors[rand].ToString();
        }
        private void GenA(BigInteger[] param)
        {
            BigInteger a = 1;
            var max = 0;
            var exp = (long)(param[0] - 1) / (long)param[1];
            var prim = generator(param[0]);
            BigInteger prim_;
            do
            {
                max++;
                var num = new Random().NextInt64(1, (long)param[0] - 1);
                if (FindGCD(num, param[0] - 1) == 1)
                {
                    prim_ = BigInteger.ModPow(prim, num, param[0]);
                    a = BigInteger.ModPow(prim_, exp, param[0]);
                }
                if (max == Int16.MaxValue) throw new ArgumentException("Не удалось подобрать парметр а.");
            } while (a == 1 || a == 0 || BigInteger.ModPow(a, param[1], param[0]) != 1);
            aBox.Text = a.ToString();
        }

        private BigInteger generator(BigInteger p)
        {
            BigInteger phi = p - 1;
            var fact = PrimeDivisors(phi);

            for (BigInteger res = 2; res <= p; ++res)
            {
                bool ok = true;
                for (int i = 0; i < fact.Count() && ok; ++i)
                    ok &= BigInteger.ModPow(res, phi / fact[i], p) != 1;
                if (ok) return res;
            }
            return -1;
        }

        private List<BigInteger> PrimeDivisors(BigInteger num)
        {

            var primeDivisors = new List<BigInteger>();
            foreach (BigInteger prime in this.primeNum)
            {
                if (prime * prime > num) break;
                while (num % prime == 0)
                {
                    if (!primeDivisors.Contains(prime)) primeDivisors.Add(prime);
                    num /= prime;
                }
            }

            if (num >= 2)
            {
                primeDivisors.Add(num);
            }

            return primeDivisors;
        }
        private bool IsBoxEmpty(TextBox tb)
        {
            return tb.Text == "";
        }


        private BigInteger[] Sign(byte[] data, BigInteger[] param)
        {
            var p = param[0];
            var q = param[1];
            var a = param[2];
            var s = param[3];
            var r = param[4];

            var v = BigInteger.ModPow(a, q - s, p);
            var x = BigInteger.ModPow(a, r, p);


            byte[] Mx = data.Concat(x.ToByteArray()).ToArray();
            byte[] sha = SHA256.Create().ComputeHash(Mx);

            var padding = new byte[] { 0 };
            BigInteger e = new BigInteger(AddHighByte(sha));


            var e_ = BigInteger.ModPow(e, 1, q) + q;
            var y = BigInteger.ModPow(r + s * e_, 1, q);

            return new BigInteger[4] { x, e, y, v };

        }

        private BigInteger[] Verify(byte[] data, BigInteger[] param)
        {
            var p = param[0];
            var a = param[1];
            var v = param[2];
            var eSign = param[3];
            var ySign = param[4];

            var n = BigInteger.ModPow(BigInteger.ModPow(a, 1, p), ySign, p);
            var m = BigInteger.ModPow(BigInteger.ModPow(v, 1, p), eSign, p);

            var x_ = BigInteger.ModPow(n * m, 1, p);


            var Mx = data.Concat(x_.ToByteArray()).ToArray();
            var sha = SHA256.Create().ComputeHash(Mx);

            var e_ = new BigInteger(AddHighByte(sha));

            return new BigInteger[2] { x_, e_ };
        }
        private byte[] AddHighByte(byte[] data)
        {
            var highByte = new byte[] { 0 };
            if (BitConverter.IsLittleEndian)
                return data.Concat(highByte).ToArray();
            else
                return highByte.Concat(data).ToArray();
        }
        private void SaveToSelectedFile(byte[] data)
        {

            var sfd = new SaveFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() != DialogResult.OK) throw new ArgumentException("Не выбран файл для протокола.");

            using Stream stream = sfd.OpenFile();
            stream.Write(data, 0, data.Length);

        }
        private void ClearForm_()
        {
            pBox.Text = "";
            qBox.Text = "";
            aBox.Text = "";
        }
        private void ClearSignTab_()
        {
            sBox.Text = "";
            rBox.Text = "";
            vBox.Text = "";
            xBox.Text = "";
            eBox.Text = "";
            yBox.Text = "";
        }
        private void ClearVerifyTab_()
        {
            v_Box.Text = "";
            x_Box.Text = "";
            e_Box.Text = "";
            eSignBox.Text = "";
            ySignBox.Text = "";
        }
    }
}


