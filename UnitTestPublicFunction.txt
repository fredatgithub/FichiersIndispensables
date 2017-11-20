// UnitTestPublicFunction
using StringFunc = FonctionsUtiles.Fred.Csharp.FunctionsString;

[TestMethod]
    public void TestMethod_HasDuplicate_yes_on_Two_items()
    {
      int[] source = { 1, 1 };
      const bool expected = true;
      bool result = StringFunc.HasDuplicate(source);
      Assert.AreEqual(result, expected);
    }
    
