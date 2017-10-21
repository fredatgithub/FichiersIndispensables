[TestMethod]
    public void TestMethod_Add_To_Name()
    {
      PrivateType privateTypeObject = new PrivateType(typeof(GetPrimeFiles.FormMain));
      const string methodName = "AddToName";
      const string source = "primes1.txt";
      const string expected = "primes1-Lined.txt";
      object obj = privateTypeObject.InvokeStatic(methodName, source);
      Assert.AreEqual(expected, (string)obj);
    }
