using NUnit.Framework;
using UnityEngine;

namespace Tests
{
  public class CollatzFilterTest
  {
    [Test]
    public void CollatzFilterT()
    {
      int[] input = { 3, 2 ,8, 9 , 10, 105};
      int[] output = CollatzFilter.collatz(input); //CubeFilter.cubes(input);
      int[] expected = { 10, 1, 4, 28, 5, 316};
      
      CollectionAssert.AreEqual(expected, output);
    }
  }
}
