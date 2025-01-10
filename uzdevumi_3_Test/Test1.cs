using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using uzdevumi_3;



namespace uzdevumi_3_Test
{

    [TestClass]
    public class ClassMatemātiskiUzdevumiTests
    {
        


        [TestMethod]
        public void Saskaita3VeselusSkaitļusPiemērs_SaņemSkaitļus_AtgriežPatiesuRezultātu()
        {
            //Arrange
            int expected = (6 + 8 + 1);
            //Act
            int result = TrešāStunda.Saskaita3VeselusSkaitļusPiemērs(6, 8, 1);
            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void FunkcijaAtgriežToPašuIntKoTaiPadod_SaņemSkaitli_AtgriežToPašu()
        {
            //Arrange

            //Act
            var result = TrešāStunda.FunkcijaAtgriežToPašuIntKoTaiPadod(99);

            //Assert
            Assert.IsInstanceOfType(result, typeof(int));
            
        }

        [TestMethod]
        public void Uzdevums1Test()
        {
            //Arrange

            //Act
            try
            {
                TrešāStunda.Uzdevums1(6);
            }
            catch (Exception e)
            {
                if (e.Message.Length > 0)
                {
                    Assert.Fail("Šī funkcija sviež exeption, tas nav jādara. Nodzēs throw NotImplementedExeption*();");
                }
                else
                {
                    Assert.IsTrue(true);
                }
            }
            //Assert
        }

        [TestMethod]
        public void HasMethod_DetectsExistingMethod_Test()
        {
            //Arrange
            
            //Act
            bool methodExists = TrešāStunda.HasMethod("Saskaita3VeselusSkaitļusPiemērs");
            //Assert
            Assert.IsTrue(methodExists);   
        }

        [TestMethod]
        public void HasMethod_ReturnsFalseOnNonExistantMethod_test()
        {
            //Arrange

            //Act
            bool methodExists = TrešāStunda.HasMethod("ajsdjajsjhknfvnmdjakkjsedf");
            //Assert
            Assert.IsFalse(methodExists);
        }

        [TestMethod]
        public void Uzdevums2_Eksistē_Test()
        {
            //Arrange

            //Act
            bool methodExists = TrešāStunda.HasMethod("Uzdevums2");
            //Assert
            Assert.IsTrue(methodExists, "Metode Neeksistē");
        }

        [TestMethod]
        public void Uzdevums2_Saņem3Atgriež4_test()
        {
            //Arrange
            string methodName = "Uzdevums2";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            int result = new int();

            //Act
            if(methodExists)
            {
                result = (int)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[1]{ 3});
            }

            //Assert
            Assert.AreEqual(4, result,"Saucot Uzdevums2(3) funkcija neatgrieza 4");
        }

        [TestMethod]
        public void Uzdevums2_Saņem10Atgriež11_test()
        {
            //Arrange
            string methodName = "Uzdevums2";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            int result = new int();

            //Act
            if (methodExists)
            {
                result = (int)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[1] { 10 });
            }

            //Assert
            Assert.AreEqual(11, result, "Saucot Uzdevums2(10) funkcija neatgrieza 11");
        }

        [TestMethod]
        public void Uzdevums3_Eksistē_Test()
        {
            //Arrange
            string functionName = "Uzdevums3";
            //Act
            bool methodExists = TrešāStunda.HasMethod(functionName);
            //Assert
            Assert.IsTrue(methodExists, "Metode Neeksistē");
        }

        [TestMethod]
        public void Uzdevums3_SaņemPareizi_atgrižPareiziPareizi_test()
        {
            //Arrange
            string methodName = "Uzdevums3";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";

            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[1] { "Pareizi" });
            }

            //Assert
            Assert.AreEqual("PareiziPareizi", result, "Saucot Uzdevums3(\"Pareizi\") funkcija neatgrieza \"PareiziPareizi\"");
        }

        [TestMethod]
        public void Uzdevums3_SaņemIzpildās_AtgriežIzpildāsIzpildās_test()
        {
            //Arrange
            string methodName = "Uzdevums3";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";
            var prameterToPass = "Izpildās ";

            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[1] { prameterToPass });
            }

            //Assert
            Assert.AreEqual($"{prameterToPass}{prameterToPass}", result, $"Saucot Uzdevums3(\"{prameterToPass}\") funkcija neatgrieza \"{prameterToPass}{prameterToPass}\"");
        }

        [TestMethod]
        public void Uzdevums4_Eksistē_Test()
        {
            //Arrange
            string functionName = "Uzdevums4";
            //Act
            bool methodExists = TrešāStunda.HasMethod(functionName);
            //Assert
            Assert.IsTrue(methodExists, "Metode Neeksistē");
        }

        [TestMethod]
        public void Uzdevums4_SaņemAaaaaa7_AtgriežAaaaaa7_test()
        {
            //Arrange
            string methodName = "Uzdevums4";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";
            var prameterToPass = "aaaaaa";
            var prameterToPass2 = 7;

            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { prameterToPass, prameterToPass2 });
            }

            //Assert
            Assert.AreEqual($"{prameterToPass}{prameterToPass2}", result, $"Saucot Uzdevums4(\"{prameterToPass}\", \"{
                prameterToPass2}\") funkcija neatgrieza \"{prameterToPass}{prameterToPass2}\"");
        }

        [TestMethod]
        public void Uzdevums4_Saņem_lvl_99_Atgriež_lvl99_test()
        {
            //Arrange
            string methodName = "Uzdevums4";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";
            var prameterToPass = "lvl";
            var prameterToPass2 = 99;

            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { prameterToPass, prameterToPass2 });
            }

            //Assert
            Assert.AreEqual($"{prameterToPass}{prameterToPass2}", result, $"Saucot Uzdevums4(\"{prameterToPass}\", \"{prameterToPass2}\") funkcija neatgrieza \"{prameterToPass}{prameterToPass2}\"");
        }

        [TestMethod]
        public void Uzdevums5_Eksistē_Test()
        {
            //Arrange
            string functionName = "Uzdevums5";
            //Act
            bool methodExists = TrešāStunda.HasMethod(functionName);
            //Assert
            Assert.IsTrue(methodExists, "Metode Neeksistē");
        }

        [TestMethod]
        public void Uzdevums5_Saņem_telefonā_13_Atgriež_Manāšobrīdielādētas13izklaidesaplikācijas_test()
        {
            //Arrange
            string methodName = "Uzdevums5";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";
            var prameterToPass = "telefonā";
            var prameterToPass2 = 13;

            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { prameterToPass, prameterToPass2 });
            }

            //Assert
            Assert.AreEqual($"Manā {prameterToPass} šobrīd ielādētas {prameterToPass2} izklaides aplikācijas", result, $"Saucot Uzdevums5(\"{prameterToPass}\", \"{prameterToPass2}\") funkcija neatgrieza \"Manā {prameterToPass} šobrīd ielādētas {prameterToPass2} izklaides aplikācijas\"");
        }

        [TestMethod]
        public void Uzdevums5_Saņem_datorā_4_Atgriež_Manāšobrīdielādētas13izklaidesaplikācijas_test()
        {
            //Arrange
            string methodName = "Uzdevums5";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";
            var prameterToPass = "datorā";
            var prameterToPass2 = 4;

            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { prameterToPass, prameterToPass2 });
            }

            //Assert
            Assert.AreEqual($"Manā { prameterToPass} šobrīd ielādētas { prameterToPass2} izklaides aplikācijas", result, $"Saucot Uzdevums5(\"{prameterToPass}\", \"{prameterToPass2}\") funkcija neatgrieza \"{prameterToPass}{prameterToPass2}\"");
        }

        [TestMethod]
        public void Uzdevums6_Eksistē_Test()
        {
            //Arrange
            string functionName = "Uzdevums6";
            //Act
            bool methodExists = TrešāStunda.HasMethod(functionName);
            //Assert
            Assert.IsTrue(methodExists, "Metode Neeksistē");
        }

        [TestMethod]
        public void Uzdevums6_strādā_test()
        {
            //Arrange
            string methodName = "Uzdevums6";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";
            var prameterToPass = "telefonā";
            var prameterToPass2 = 13;

            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[0] {});
            }

            //Assert
            Assert.AreEqual(
                "Manā telefonā šobrīd ielādētas 13 izklaides aplikācijasManā telefonā šobrīd ielādētas 13 izklaides aplikācijasManā telefonā šobrīd ielādētas 13 izklaides aplikācijasManā telefonā šobrīd ielādētas 13 izklaides aplikācijasManā telefonā šobrīd ielādētas 13 izklaides aplikācijas", 
                result, 
                $"Saucot Uzdevums6() funkcija neatgrieza pareizo tekstu");
        }

        [TestMethod]
        public void Uzdevums7_Eksistē_Test()
        {
            //Arrange
            string functionName = "Uzdevums7";
            //Act
            bool methodExists = TrešāStunda.HasMethod(functionName);
            //Assert
            Assert.IsTrue(methodExists, "Metode Neeksistē");
        }

        [TestMethod]
        public void Uzdevums7_strādā_test()
        {
            //Arrange
            string methodName = "Uzdevums7";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";
            var prameterToPass = "telefonā";
            var prameterToPass2 = 13;

            string teikums1 = $"Manā {prameterToPass} šobrīd ielādētas {prameterToPass2} izklaides aplikācijas";
            string teikums2 = $"Manā {prameterToPass} šobrīd ielādētas {prameterToPass2} izklaides aplikācijas"+ $"Manā {prameterToPass} šobrīd ielādētas {prameterToPass2} izklaides aplikācijas";
            string teikums5 = "";
            string teikums20 = "";
            for(int i = 0; i < 5; i++)
            {
                teikums5 += teikums1;
            }

            for (int i = 0; i < 20; i++)
            {
                teikums20 += teikums1;
            }

            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[0] { });
            }

            //Assert
            Assert.AreEqual(
                 $"Viens teikums {teikums1}, divi teikumi {teikums2}, pieci teikumi {teikums5}, divdesmit teikumi {teikums20}",
                result,
                $"Saucot {methodName} funkcija neatgrieza pareizo tekstu");
        }

        [TestMethod]
        public void Uzdevums8_ejuPusdienāsKadGribasĒst_test()
        {
            //Arrange

            //Act
            var result = TrešāStunda.Uzdevums8_VaiJāietPusdienās(true);
            //Assert
            Assert.IsTrue( result );
        }

        [TestMethod]
        public void Uzdevums8_JaNegribasĒstNekurNavJāiet_test()
        {
            //Arrange

            //Act
            var result = TrešāStunda.Uzdevums8_VaiJāietPusdienās(false);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Uzdevums9_VaiIepauzēšuSpēli_true_true_false_test()
        {
            //Arrange

            //Act
            var result = TrešāStunda.Uzdevums9_VaiIepauzēšuSpēli(true, true);
            //Assert
            Assert.IsFalse(result );
        }

        [TestMethod]
        public void Uzdevums9_VaiIepauzēšuSpēli_true_false_true_test()
        {
            //Arrange

            //Act
            var result = TrešāStunda.Uzdevums9_VaiIepauzēšuSpēli(true, false);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Uzdevums9_VaiIepauzēšuSpēli_false_true_false_test()
        {
            //Arrange

            //Act
            var result = TrešāStunda.Uzdevums9_VaiIepauzēšuSpēli(false, true);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Uzdevums9_VaiIepauzēšuSpēli_false_false_false_test()
        {
            //Arrange

            //Act
            var result = TrešāStunda.Uzdevums9_VaiIepauzēšuSpēli(false, false);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Uzdevums10_Eksistē_Test()
        {
            //Arrange
            string functionName = "Uzdevums10VērtībaIrMaza";
            //Act
            bool methodExists = TrešāStunda.HasMethod(functionName);
            //Assert
            Assert.IsTrue(methodExists, "Metode Neeksistē");
        }

        [TestMethod]
        public void Uzdevums10VērtībaIrMaza_500_500_true_test()
        {
            //Arrange
            string methodName = "Uzdevums10VērtībaIrMaza";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = false;
            

            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] {500, 500 });
            }

            //Assert
            Assert.IsTrue(result, "padots 500, 500, sagaidāms true");
        }

        [TestMethod]
        public void Uzdevums10VērtībaIrMaza_400_601_false_test()
        {
            //Arrange
            string methodName = "Uzdevums10VērtībaIrMaza";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = true;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { 400, 601 });
            }

            //Assert
            Assert.IsFalse(result, "padots 400, 601, sagaidāms false");
        }

        [TestMethod]
        public void Uzdevums10VērtībaIrMaza_400_mīnus600_true_test()
        {
            //Arrange
            string methodName = "Uzdevums10VērtībaIrMaza";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = false;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { 400, -600 });
            }

            //Assert
            Assert.IsTrue(result, "padots 400, -600, sagaidāms true");
        }

        [TestMethod]
        public void Uzdevums11VaiSkaitļiIrVienādi_300_300_true_test()
        {
            //Arrange
            string methodName = "Uzdevums11VaiSkaitļiIrVienādi";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = false;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { 300,  300});
            }

            //Assert
            Assert.IsTrue(result, "padots 300, 300, sagaidāms true");
        }

        [TestMethod]
        public void Uzdevums11VaiSkaitļiIrVienādi_5_6_false_test()
        {
            //Arrange
            string methodName = "Uzdevums11VaiSkaitļiIrVienādi";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = true;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { 5, 6 });
            }

            //Assert
            Assert.IsFalse(result, "padots 5, 6, sagaidāms false");
        }


        [TestMethod]
        public void Uzdevums12IrPāraSkaitlis_12_true_test()
        {
            //Arrange
            string methodName = "Uzdevums12IrPāraSkaitlis";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = false;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[1] {12 });
            }

            //Assert
            Assert.IsTrue(result, "padots 12, sagaidāms true");
        }

        [TestMethod]
        public void Uzdevums12IrPāraSkaitlis_17_false_test()
        {
            //Arrange
            string methodName = "Uzdevums12IrPāraSkaitlis";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = true;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[1] { 17 });
            }

            //Assert
            Assert.IsFalse(result, "padots 17, sagaidāms false");
        }

        [TestMethod]
        public void Uzdevums13IrPozitīvsSkaitlis_17_true_test()
        {
            //Arrange
            string methodName = "Uzdevums13IrPozitīvsSkaitlis";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = false;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[1] { 17 });
            }

            //Assert
            Assert.IsFalse(result, "padots 17, sagaidāms true");
        }

        [TestMethod]
        public void Uzdevums13IrPozitīvsSkaitlis_mīnus3_false_test()
        {
            //Arrange
            string methodName = "Uzdevums13IrPozitīvsSkaitlis";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = true;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[1] { -3 });
            }

            //Assert
            Assert.IsFalse(result, "padots -3, sagaidāms false");
        }

        [TestMethod]
        public void Uzdevums14Lielākais_456_6_test()
        {
            //Arrange
            string methodName = "Uzdevums14Lielākais";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = 0;


            //Act
            if (methodExists)
            {
                result = (int)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[3] { 4, 5, 6 });
            }

            //Assert
            Assert.AreEqual(6, result , "padots 4, 5, 6, sagaidāms 6");
        }

        [TestMethod]
        public void Uzdevums14Lielākais_555_5_test()
        {
            //Arrange
            string methodName = "Uzdevums14Lielākais";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = 0;


            //Act
            if (methodExists)
            {
                result = (int)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[3] { 5,5,5 });
            }

            //Assert
            Assert.AreEqual(5, result, "padots 5,5,5, sagaidāms 5");
        }

        [TestMethod]
        public void Uzdevums14Lielākais_667_7_test()
        {
            //Arrange
            string methodName = "Uzdevums14Lielākais";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = 0;


            //Act
            if (methodExists)
            {
                result = (int)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[3] { 7, 6, 6 });
            }

            //Assert
            Assert.AreEqual(7, result, "padots 7,6,6 sagaidāms 7");
        }


        [TestMethod]
        public void Uzdevums15Kvadrants_1kvad_test()
        {
            //Arrange
            string methodName = "Uzdevums15Kvadrants";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = 0;


            //Act
            if (methodExists)
            {
                result = (int)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { 1,2 });
            }

            //Assert
            Assert.AreEqual(1, result, "padots x=1 y=2 sagaidāms 1");
        }

        [TestMethod]
        public void Uzdevums15Kvadrants_2kvad_test()
        {
            //Arrange
            string methodName = "Uzdevums15Kvadrants";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = 0;


            //Act
            if (methodExists)
            {
                result = (int)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { -1, 2 });
            }

            //Assert
            Assert.AreEqual(2, result, "padots x=-1 y=2 sagaidāms 2");
        }

        [TestMethod]
        public void Uzdevums15Kvadrants_3kvad_test()
        {
            //Arrange
            string methodName = "Uzdevums15Kvadrants";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = 0;


            //Act
            if (methodExists)
            {
                result = (int)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { -1, -2 });
            }

            //Assert
            Assert.AreEqual(3, result, "padots x=-1 y=-2 sagaidāms 3");
        }

        [TestMethod]
        public void Uzdevums15Kvadrants_4kvad_test()
        {
            //Arrange
            string methodName = "Uzdevums15Kvadrants";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = 0;


            //Act
            if (methodExists)
            {
                result = (int)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { 1, -2 });
            }

            //Assert
            Assert.AreEqual(4, result, "padots x=1 y=-2 sagaidāms 3");
        }

        [TestMethod]
        public void Uzdevums16VaiSanākTrijstūris_90_90_90_false_test()
        {
            //Arrange
            string methodName = "Uzdevums16VaiSanākTrijstūris";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = true;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[3] { 90,90,90 });
            }

            //Assert
            Assert.IsFalse(result, "padots 90 90 90 sagaidāms false");
        }

        [TestMethod]
        public void Uzdevums16VaiSanākTrijstūris_103_37_40_true_test()
        {
            //Arrange
            string methodName = "Uzdevums16VaiSanākTrijstūris";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = false;


            //Act
            if (methodExists)
            {
                result = (bool)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[3] { 103, 37, 40 });
            }

            //Assert
            Assert.IsTrue(result, "padots 103 37 40 sagaidāms true");
        }


        [TestMethod]
        public void Uzdevums17PeļņaZaudējumi_900_500_Zaudējumosnorakstāms400euro_test()
        {
            //Arrange
            string methodName = "Uzdevums17PeļņaZaudējumi";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";


            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { 900, 500 });
            }

            //Assert
            Assert.AreEqual($"Žaudējumos norakstāms {900 - 500} euro", result);
        }

        [TestMethod]
        public void Uzdevums17PeļņaZaudējumi_10_17_Peļņāesamsastrādājuši7euro_test()
        {
            //Arrange
            string methodName = "Uzdevums17PeļņaZaudējumi";
            bool methodExists = TrešāStunda.HasMethod(methodName);
            var result = "";

            
            //Act
            if (methodExists)
            {
                result = (string)typeof(TrešāStunda).GetMethod(methodName).Invoke(typeof(TrešāStunda), new object[2] { 10, 17 });
            }

            //Assert
            Assert.AreEqual($"Peļņā esam sastrādājuši {17 - 10} euro!", result);
        }


        //[TestMethod]
        //public void Test1()
        //{
        //    //Arrange

        //    //Act

        //    //Assert
        //}
    }
}
