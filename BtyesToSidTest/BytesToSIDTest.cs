using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ConvertSIDByteArayToSIDStirng;

namespace BytesToSidTest
{
    [TestClass]
    public class BytesToSIDTest
    {
        private  List<(int sections, string csvInput, string expected)> testData { get; set; }
        public BytesToSIDTest()
        {
            testData = new List<(int sections, string csvInput, string expected)>
            {
                (5,
                    "1,5,0,255,255,255,255,255,21,0,0,0,213,142,2,34,86,100,158,107,112,120,52,41,246,3,0,0 ",
                    "S-1-1099511627775-21-570592981-1805542486-691304560-1014"
                ),
                (5,
                    "1,5,0,0,0,0,0,5,21,0,0,0,213,142,2,34,86,100,158,107,112,120,52,41,246,3,0,0",
                    "S-1-5-21-570592981-1805542486-691304560-1014"
                ),
                (2,
                    "1,2,0,0,0,0,0,5,32,0,0,0,32,2,0,0",
                    "S-1-5-32-544"
                ),
                (2,
                    "1,2,0,0,0,0,0,5,32,0,0,0,34,2,0,0",
                    "S-1-5-32-546"
                ),
                (1,
                    "1,1,0,0,0,0,0,5,0,0,0,0",
                    "S-1-5-0"
                ),
                (3, "01,03,00,00,00,00,00,05,20,00,00,00,38,02,00,00,2,0,0,0",
                    "S-1-5-20-550-2"
                ),
                (4, "01,4,00,00,00,00,00,05,20,00,00,00,38,02,00,00,2,3,0,0,2,1,0,0",
                    "S-1-5-20-550-770-258"
                )

            };

        }
        
        [TestMethod]
        public void TransformBytesToSIDTest()
        {
            // don't know how or if it's possible to do a theory in this test harness, so using a loop

            foreach (var test in  testData)
            {
                //arrange
                var bytes = TransformBytesToSID.GetSidByteCol(test.csvInput);
                //act
                var b2Sid = new TransformBytesToSID(bytes);
                var b2SidMannino = new TransformBytesToSID(bytes, true);

                //assert
                Assert.AreEqual(test.sections, b2Sid.SectionCount);
                Assert.AreEqual(test.expected, b2Sid.SID);

                Assert.AreEqual(b2SidMannino.SectionCount, b2Sid.SectionCount);
                Assert.AreEqual(b2SidMannino.SID, b2Sid.SID);

            }
        }
    }
}
