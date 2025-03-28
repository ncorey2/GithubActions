namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_COREY()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_COREY()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_COREY()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
	[TestMethod]
	public void Subtract_Valid_COREY()
	{
		Assert.AreEqual(5, Program.Subtract("9", "4"));
		Assert.AreEqual(9, Program.Subtract("11", "2"));
		Assert.AreEqual(12, Program.Subtract("15", "3"));
	}
	[TestMethod]
	public void Subtract_Invalid_COREY()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}
	[TestMethod]
	public void Subtract_Null_COREY()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
	}
	[TestMethod]
	public void Multiply_Valid_COREY()
	{
		Assert.AreEqual(36, Program.Multiply("9", "4"));
		Assert.AreEqual(22, Program.Multiply("11", "2"));
		//Fixed test case so it is correct now
		Assert.AreEqual(45000, Program.Multiply("150", "300"));
	}
	[TestMethod]
	public void Multiply_Invalid_COREY()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}
	[TestMethod]
	public void Multiply_Null_COREY()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
	}
	[TestMethod]
	public void Divide_Valid_COREY()
	{
		Assert.AreEqual(3, Program.Divide("9", "3"));
		Assert.AreEqual(5.5, Program.Divide("11", "2"));
		Assert.AreEqual(0.5, Program.Divide("150", "300"));
	}
	[TestMethod]
	public void Divide_Invalid_COREY()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
	}
	[TestMethod]
	public void Divide_Null_COREY()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
	}
	[TestMethod]
	public void Power_Valid_COREY()
	{
		Assert.AreEqual(729, Program.Power("9", "3"));
		Assert.AreEqual(121, Program.Power("11", "2"));
		Assert.AreEqual(22500, Program.Power("150", "2"));
	}
	[TestMethod]
	public void Power_Invalid_COREY()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}
	[TestMethod]
	public void Power_Null_COREY()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
	}

}
