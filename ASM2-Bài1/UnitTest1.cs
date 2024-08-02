namespace ASM2_Bài1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(1.1, 2, 3)]
        [TestCase(-7.6, 2, -5)]
        [TestCase(-5, 2, -3)]
        [TestCase(int.MaxValue, -1, int.MaxValue - 1)]
        [TestCase(0, 0, 0)]
        [TestCase(-17.6, 2, -5)]
        [TestCase(1, 6, 3)]
        [TestCase(-1, 2, 3)]
        [TestCase(-1, -11, -12)]
        public void Test1(double num1, double num2, int x)
        {
            if (num1 == (int)num1 && num2 == (int)num2)
            {
                int sum = (int)num1 + (int)num2;
                Assert.AreEqual(x, sum);
            }
            else
            {
                Assert.AreEqual(x, 0);
            }
        }
        [Test]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        [TestCase(1.1, 2, 2)]
        [TestCase(-7.6, 2, -5)]
        [TestCase(-5, 2, -10)]
        [TestCase(3, 5, 15)]
        [TestCase(0, 0, 0)]
        [TestCase(-17.6, 2, -5)]
        [TestCase(1, 6, 3)]
        [TestCase(-1, 2, -2)]
        [TestCase(-1, -11, 11)]
        public void Test2(double num1, double num2, int x)
        {
            if (num1 == (int)num1 && num2 == (int)num2)
            {
                int tich = (int)num1 * (int)num2;
                Assert.AreEqual(x, tich);
            }
            else
            {
                Assert.AreEqual(x, 0);
            }
        }
        [Test]
        [TestCase(int.MaxValue, 1, int.MaxValue - 1)]
        [TestCase(1.1, 2, 2)]
        [TestCase(-7.6, 2, -5)]
        [TestCase(-5, 2, -10)]
        [TestCase(int.MinValue, -1, int.MinValue + 1)]
        [TestCase(0, 0, 0)]
        [TestCase(-17.6, 2, -5)]
        [TestCase(int.MaxValue, 1, int.MaxValue - 1)]
        [TestCase(-1, 2, -3)]
        [TestCase(-1, -11, 12)]
        public void Test3(double num1, double num2, int x)
        {
            if (num1 == (int)num1 && num2 == (int)num2)
            {
                int hieu = (int)num1 * (int)num2;
                Assert.AreEqual(x, hieu);
            }
            else
            {
                Assert.AreEqual(x, 0);
            }
        }
        [Test]
        [TestCase(new double[] { 1, 2, 3 }, 2)]
        [TestCase(new double[] { -1, -2, -3 }, -2)]
        [TestCase(new double[] { 0, 0, 0 }, 0)]
        [TestCase(new double[] { int.MaxValue, int.MinValue }, 50)]
        [TestCase(new double[] { 6.7, 7.5 }, 7.1) ]
        public void TinhTrungBinhCong_ShouldReturnCorrectResult(double[] numbers, double expected)
        {
            double result = TinhTrungBinhCong(numbers);
            Assert.AreEqual(expected, result);
        }

        public double TinhTrungBinhCong(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Danh sách không được rỗng");
            }

            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}